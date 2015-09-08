using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Builders;
using Manufaktura.Music.Model;
using Manufaktura.Music.Xml;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    internal class NoteAndRestParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "note"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            NoteOrRestBuilder builder = new NoteOrRestBuilder(state);

            element.IfAttribute("default-x").HasValue<double>().Then(m => builder.DefaultX = m);
            element.IfAttribute("measure").HasValue("yes").Then(m => builder.FullMeasure = true);
            element.IfDescendant("staff").HasValue<int>().Then(m => builder.Staff = staff.Score.Staves.ElementAt(m - 1)); //TODO: Sprawdzić czy staff to numer liczony od góry strony czy numer w obrębie parta
            element.IfAttribute("print-object").HasValue("yes").Then(m => builder.IsVisible = true);

            element.IfDescendant("type").HasValue(new Dictionary<string, RhythmicDuration> {
                 { "whole", RhythmicDuration.Whole },
                 { "half", RhythmicDuration.Half },
                 { "quarter",  RhythmicDuration.Quarter },
                 { "eighth", RhythmicDuration.Eighth },
                 { "16th",  RhythmicDuration.Sixteenth },
                 { "32nd",  RhythmicDuration.D32nd },
                 { "64th",  RhythmicDuration.D64th },
                 { "128th",  RhythmicDuration.D128th }}).Then(m => builder.BaseDuration = m);

            element.IfAttribute("size").HasValue("cue").Then(() => builder.IsCueNote = true);
            element.IfDescendant("voice").HasValue<int>().Then(m => builder.Voice = m);
            element.IfDescendant("grace").Exists().Then(() => builder.IsGraceNote = true);
            element.IfDescendant("chord").Exists().Then(() => builder.IsChordElement = true);
            element.IfAttribute("accidental").HasValue("natural").Then(() => builder.HasNatural = true);
            element.IfAttribute("rest").Exists().Then(() => builder.IsRest = true);
            element.ForEachDescendant("dot", f => f.Exists().Then(() => builder.NumberOfDots++));

            var pitchElement = element.Elements().FirstOrDefault(e => e.Name == "pitch");
            if (pitchElement != null)
            {
                pitchElement.IfElement("step").HasAnyValue().Then(v => builder.Step = v);
                pitchElement.IfElement("octave").HasValue<int>().Then(v => builder.Octave = v);
                pitchElement.IfElement("alter").HasValue<int>().Then(v => builder.Alter = v);
            }

            var tieElement = element.Elements().FirstOrDefault(e => e.Name == "tie");
            if (tieElement != null)
            {
                tieElement.IfAttribute("type").HasValue("start").Then(v =>
                {
                    if (builder.TieType == NoteTieType.Stop) builder.TieType = NoteTieType.StopAndStartAnother;
                    else builder.TieType = NoteTieType.Start;
                }).Otherwise(() => builder.TieType = NoteTieType.Stop);
            }

            element.IfElement("stem").HasValue("down")
                .Then(() => builder.StemDirection = VerticalDirection.Down)
                .Otherwise(() => builder.StemDirection = VerticalDirection.Up);
            var stemElement = element.Elements().FirstOrDefault(e => e.Name == "stem");
            if (stemElement != null)
            {
                stemElement.IfAttribute("default-y").HasValue<float>().Then(v =>
                {
                    builder.StemDefaultY = v;
                    builder.CustomStemEndPosition = true;
                });
            }

            //TODO: Refactor to Manufaktura.Music.Xml API
            foreach (XElement noteNode in element.Elements())
            {
                if (noteNode.Name == "beam")
                {
                    if (noteNode.Value == "begin") builder.BeamList.Add(NoteBeamType.Start);
                    else if (noteNode.Value == "end") builder.BeamList.Add(NoteBeamType.End);
                    else if (noteNode.Value == "continue") builder.BeamList.Add(NoteBeamType.Continue);
                    else if (noteNode.Value == "forward hook") builder.BeamList.Add(NoteBeamType.ForwardHook);
                    else if (noteNode.Value == "backward hook") builder.BeamList.Add(NoteBeamType.BackwardHook);
                }
                else if (noteNode.Name == "notations")
                {
                    foreach (XElement notationNode in noteNode.Elements())
                    {
                        if (notationNode.Name == "tuplet")
                        {
                            if (notationNode.Attribute("type").Value == "start")
                            {
                                builder.Tuplet = TupletType.Start;
                            }
                            else if (notationNode.Attribute("type").Value == "stop")
                            {
                                builder.Tuplet = TupletType.Stop;
                            }

                            if (notationNode.Attributes().Any(a => a.Name == "placement"))
                            {
                                if (notationNode.Attribute("placement").Value == "above") builder.TupletPlacement = VerticalPlacement.Above;
                                else if (notationNode.Attribute("placement").Value == "below") builder.TupletPlacement = VerticalPlacement.Below;
                            }
                        }
                        if (notationNode.Name == "dynamics")
                        {
                            DirectionPlacementType placement = DirectionPlacementType.Above;
                            int defaultY = 0;
                            string text = "";
                            var attribute = noteNode.Attribute("default-y");
                            if (attribute != null)
                            {
                                defaultY = Convert.ToInt32(attribute.Value);
                                placement = DirectionPlacementType.Custom;
                            }
                            attribute = noteNode.Attribute("placement");
                            if (attribute != null && placement != DirectionPlacementType.Custom)
                            {
                                if (attribute.Value == "above") placement = DirectionPlacementType.Above;
                                else if (attribute.Value == "below") placement = DirectionPlacementType.Below;
                            }
                            foreach (XElement dynamicsType in notationNode.Elements())
                            {
                                text = dynamicsType.Name.LocalName;
                            }
                            Direction dir = new Direction();
                            dir.DefaultY = defaultY;
                            dir.Placement = placement;
                            dir.Text = text;
                            staff.Elements.Add(dir);
                        }
                        else if (notationNode.Name == "articulations")
                        {
                            foreach (XElement articulationAttribute in notationNode.Elements())
                            {
                                if (articulationAttribute.Name == "staccato")
                                {
                                    builder.Articulation = ArticulationType.Staccato;
                                }
                                else if (articulationAttribute.Name == "accent")
                                {
                                    builder.Articulation = ArticulationType.Accent;
                                }

                                if (articulationAttribute.Attribute("placement").Value == "above")
                                    builder.ArticulationPlacement = VerticalPlacement.Above;
                                else if (articulationAttribute.Attribute("placement").Value == "below")
                                    builder.ArticulationPlacement = VerticalPlacement.Below;
                            }
                        }
                        else if (notationNode.Name == "ornaments")
                        {
                            foreach (XElement ornamentAttribute in notationNode.Elements())
                            {
                                var placementAttribute = ornamentAttribute.Attributes().FirstOrDefault(a => a.Name == "placement");
                                if (ornamentAttribute.Name == "trill-mark")
                                {
                                    if (placementAttribute != null)
                                    {
                                        if (placementAttribute.Value == "above")
                                            builder.TrillMark = NoteTrillMark.Above;
                                        else if (placementAttribute.Value == "below")
                                            builder.TrillMark = NoteTrillMark.Below;
                                    }
                                }
                                else if (ornamentAttribute.Name == "tremolo")
                                {
                                    builder.TremoloLevel = Convert.ToInt32(ornamentAttribute.Value);
                                }
                                else if (ornamentAttribute.Name == "inverted-mordent")
                                {
                                    builder.Mordent = new Mordent() { IsInverted = true };

                                    if (placementAttribute != null)
                                    {
                                        if (placementAttribute.Value == "above")
                                            builder.Mordent.Placement = VerticalPlacement.Above;
                                        else if (placementAttribute.Value == "below")
                                            builder.Mordent.Placement = VerticalPlacement.Below;
                                    }

                                    var attr = ornamentAttribute.Attributes().FirstOrDefault(a => a.Name == "default-x");
                                    if (attr != null) builder.Mordent.DefaultXPosition = UsefulMath.TryParse(attr.Value);
                                    attr = ornamentAttribute.Attributes().FirstOrDefault(a => a.Name == "default-y");
                                    if (attr != null) builder.Mordent.DefaultYPosition = UsefulMath.TryParse(attr.Value);
                                }
                            }
                        }
                        else if (notationNode.Name == "slur")
                        {
                            builder.Slur = new Slur();

                            var number = notationNode.ParseAttribute<int>("number");
                            if (number.HasValue && number != 1)
                                continue;
                            if (notationNode.ParseAttribute("type") == "start")
                                builder.Slur.Type = NoteSlurType.Start;
                            else if (notationNode.ParseAttribute("type") == "stop")
                                builder.Slur.Type = NoteSlurType.Stop;

                            var placement = notationNode.ParseAttribute("placement");
                            if (!string.IsNullOrWhiteSpace(placement)) builder.Slur.Placement = placement == "above" ? VerticalPlacement.Above : VerticalPlacement.Below;
                        }
                        else if (notationNode.Name == "fermata")
                        {
                            builder.HasFermataSign = true;
                        }
                        else if (notationNode.Name == "sound")
                        {
                            var dynamics = notationNode.ParseAttribute<int>("dynamics");
                            if (dynamics.HasValue) state.CurrentDynamics = dynamics.Value;
                        }
                    }
                }
                else if (noteNode.Name == "lyric")
                {
                    //There can be more than one lyrics in one <lyrics> tag. Add lyrics to list once syllable type and text is set.
                    //Then reset these tags so the next <syllabic> tag starts another lyric.
                    Lyrics lyricsInstance = new Lyrics();
                    Lyrics.Syllable syllable = new Lyrics.Syllable();
                    bool isSylabicSet = false;
                    bool isTextSet = false;
                    var defaultYattribute = noteNode.Attributes().FirstOrDefault(a => a.Name == "default-y");
                    if (defaultYattribute != null) lyricsInstance.DefaultYPosition = UsefulMath.TryParse(defaultYattribute.Value);

                    foreach (XElement lyricAttribute in noteNode.Elements())
                    {
                        if (lyricAttribute.Name == "syllabic")
                        {
                            if (lyricAttribute.Value == "begin")
                            {
                                syllable.Type = SyllableType.Begin;
                            }
                            else if (lyricAttribute.Value == "middle")
                            {
                                syllable.Type = SyllableType.Middle;
                            }
                            else if (lyricAttribute.Value == "end")
                            {
                                syllable.Type = SyllableType.End;
                            }
                            else if (lyricAttribute.Value == "single")
                            {
                                syllable.Type = SyllableType.Single;
                            }
                            isSylabicSet = true;
                        }
                        else if (lyricAttribute.Name == "text")
                        {
                            syllable.Text = lyricAttribute.Value;
                            isTextSet = true;
                        }
                        else if (lyricAttribute.Name == "elision")
                        {
                            syllable.ElisionMark = lyricAttribute.Value;
                        }

                        if (isSylabicSet && isTextSet)
                        {
                            lyricsInstance.Syllables.Add(syllable);
                            syllable = new Lyrics.Syllable();
                            isSylabicSet = false;
                            isTextSet = false;
                        }
                    }

                    builder.Lyrics.Add(lyricsInstance);
                }
            }
            if (builder.BeamList.Count == 0) builder.BeamList.Add(NoteBeamType.Single);

            var noteOrRest = builder.Build();
            var rest = noteOrRest as Rest;
            if (rest != null)
            {
                var timeSignature = staff.Elements.OfType<TimeSignature>().LastOrDefault();
                if (timeSignature != null) rest.Duration = new RhythmicDuration(timeSignature.NumberOfBeats / timeSignature.TypeOfBeats);
            }

            var correctStaff = noteOrRest.Staff ?? staff;
            correctStaff.Elements.Add(noteOrRest);
        }
    }
}