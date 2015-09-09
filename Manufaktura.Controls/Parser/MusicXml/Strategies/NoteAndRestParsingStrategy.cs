using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Builders;
using Manufaktura.Music.Model;
using Manufaktura.Music.Xml;
using System;
using System.Collections.Generic;
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
            element.IfAttribute("print-object").HasValue(new Dictionary<string, bool> {
                {"yes", true}, {"no", false}}).Then(m => builder.IsVisible = m);
            element.IfAttribute("size").HasValue("cue").Then(() => builder.IsCueNote = true);
            element.IfElement("staff").HasValue<int>().Then(m => builder.Staff = staff.Score.Staves.ElementAt(m - 1)); //TODO: Sprawdzić czy staff to numer liczony od góry strony czy numer w obrębie parta
            element.IfElement("type").HasValue(new Dictionary<string, RhythmicDuration> {
                 { "whole", RhythmicDuration.Whole },
                 { "half", RhythmicDuration.Half },
                 { "quarter",  RhythmicDuration.Quarter },
                 { "eighth", RhythmicDuration.Eighth },
                 { "16th",  RhythmicDuration.Sixteenth },
                 { "32nd",  RhythmicDuration.D32nd },
                 { "64th",  RhythmicDuration.D64th },
                 { "128th",  RhythmicDuration.D128th }}).Then(m => builder.BaseDuration = m);

            element.IfElement("voice").HasValue<int>().Then(m => builder.Voice = m);
            element.IfElement("grace").Exists().Then(() => builder.IsGraceNote = true);
            element.IfElement("chord").Exists().Then(() => builder.IsChordElement = true);
            element.IfElement("accidental").HasValue("natural").Then(() => builder.HasNatural = true);
            element.IfElement("rest").Exists().Then(() => builder.IsRest = true);
            element.ForEachDescendant("dot", f => f.Exists().Then(() => builder.NumberOfDots++));

            var pitchElement = element.Elements().FirstOrDefault(e => e.Name == "pitch");
            if (pitchElement != null)
            {
                pitchElement.IfElement("step").HasAnyValue().Then(v => builder.Step = v);
                pitchElement.IfElement("octave").HasValue<int>().Then(v => builder.Octave = v);
                pitchElement.IfElement("alter").HasValue<int>().Then(v => builder.Alter = v);
            }

            var tieElements = element.Elements().Where(e => e.Name == "tie");
            foreach (var tieElement in tieElements)
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
            element.GetElement("stem").IfAttribute("default-y").HasValue<float>().Then(v =>
                {
                    builder.StemDefaultY = v;
                    builder.CustomStemEndPosition = true;
                });

            element.ForEachDescendant("beam", h => h.HasValue(new Dictionary<string, NoteBeamType> {
                {"begin", NoteBeamType.Start},
                {"end", NoteBeamType.End},
                {"continue", NoteBeamType.Continue},
                {"forward hook", NoteBeamType.ForwardHook},
                {"backward hook", NoteBeamType.BackwardHook}
            }).Then(v => builder.BeamList.Add(v)));

            var notationsNode = element.GetElement("notations");
            var tupletNode = notationsNode.GetElement("tuplet");
            tupletNode.IfAttribute("type").HasValue(new Dictionary<string, TupletType> {
                        {"start", TupletType.Start},
                        {"stop", TupletType.Stop},
                    }).Then(v => builder.Tuplet = v);
            tupletNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
                        {"above", VerticalPlacement.Above},
                        {"below", VerticalPlacement.Below},
                    }).Then(v => builder.TupletPlacement = v);

            notationsNode.IfElement("fermata").HasAnyValue().Then(() => builder.HasFermataSign = true);
            notationsNode.IfElement("sound").Exists().Then(e => e.IfAttribute("dynamics").HasValue<int>().Then(v => state.CurrentDynamics = v));

            notationsNode.IfHasElement("dynamics").Then(d =>
            {
                var dir = new Direction();
                d.IfAttribute("default-y").HasValue<int>().Then(v =>
                {
                    dir.DefaultY = v;
                    dir.Placement = DirectionPlacementType.Custom;
                });
                d.IfAttribute("placement").HasValue(new Dictionary<string, DirectionPlacementType>
                {
                    {"above", DirectionPlacementType.Above},
                    {"below", DirectionPlacementType.Below}
                }).Then(v =>
                {
                    if (dir.Placement != DirectionPlacementType.Custom) dir.Placement = v;
                });
                foreach (XElement dynamicsType in d.Elements())
                {
                    dir.Text = dynamicsType.Name.LocalName;
                }
                staff.Elements.Add(dir);
            });

            notationsNode.IfHasElement("articulations").Then(d =>
            {
                d.IfElement("staccato").HasAnyValue().Then(() => builder.Articulation = ArticulationType.Staccato);
                d.IfElement("accent").HasAnyValue().Then(() => builder.Articulation = ArticulationType.Accent);
                d.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
                        {"above", VerticalPlacement.Above},
                        {"below", VerticalPlacement.Below},
                    }).Then(v => builder.ArticulationPlacement = v);
            });

            //TODO: Refactor to Manufaktura.Music.Xml API
            foreach (XElement noteNode in element.Elements())
            {
                if (noteNode.Name == "notations")
                {
                    foreach (XElement notationNode in noteNode.Elements())
                    {
                        if (notationNode.Name == "ornaments")
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

            var correctStaff = noteOrRest.Staff ?? staff;
            correctStaff.Elements.Add(noteOrRest);
        }
    }
}