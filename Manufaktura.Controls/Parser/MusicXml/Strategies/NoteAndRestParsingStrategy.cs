using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Builders;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class NoteAndRestParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "note"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            NoteOrRestBuilder builder = new NoteOrRestBuilder(state);

            var defaultXAttribute = element.Attributes().Where(a => a.Name == "default-x").FirstOrDefault();
            if (defaultXAttribute != null)
            {
                var parsedValue = UsefulMath.TryParse(defaultXAttribute.Value);
                if (parsedValue.HasValue) builder.DefaultX = parsedValue.Value;
            }

            var printObjectAttribute = element.Attributes().Where(a => a.Name == "print-object").FirstOrDefault();
            if (printObjectAttribute != null) builder.IsVisible = "yes".Equals(printObjectAttribute.Value, StringComparison.OrdinalIgnoreCase);

            foreach (XElement noteAttribute in element.Elements())
            {
                if (noteAttribute.Name == "pitch")
                {
                    foreach (XElement pitchAttribute in noteAttribute.Elements())
                    {

                        if (pitchAttribute.Name == "step")
                        {
                            builder.Step = pitchAttribute.Value;
                        }
                        else if (pitchAttribute.Name == "octave")
                        {
                            builder.Octave = Convert.ToInt16(pitchAttribute.Value);
                        }
                        else if (pitchAttribute.Name == "alter")
                        {
                            builder.Alter = Convert.ToInt16(pitchAttribute.Value);
                        }
                    }
                }
                else if (noteAttribute.Name == "voice")
                {
                    builder.Voice = Convert.ToInt32(noteAttribute.Value);
                }
                else if (noteAttribute.Name == "grace")
                {
                    builder.IsGraceNote = true;
                }
                else if (noteAttribute.Name == "chord")
                {
                    builder.IsChordElement = true;
                }
                else if (noteAttribute.Name == "type")
                {
                    if (noteAttribute.Value == "whole") builder.Duration = MusicalSymbolDuration.Whole;
                    else if (noteAttribute.Value == "half") builder.Duration = MusicalSymbolDuration.Half;
                    else if (noteAttribute.Value == "quarter") builder.Duration = MusicalSymbolDuration.Quarter;
                    else if (noteAttribute.Value == "eighth") builder.Duration = MusicalSymbolDuration.Eighth;
                    else if (noteAttribute.Value == "16th") builder.Duration = MusicalSymbolDuration.Sixteenth;
                    else if (noteAttribute.Value == "32nd") builder.Duration = MusicalSymbolDuration.d32nd;
                    else if (noteAttribute.Value == "64th") builder.Duration = MusicalSymbolDuration.d64th;
                    else if (noteAttribute.Value == "128th") builder.Duration = MusicalSymbolDuration.d128th;

                    var noteSizeAttribute = noteAttribute.Attributes().FirstOrDefault(a => a.Name == "size");
                    if (noteSizeAttribute != null)
                    {
                        builder.IsCueNote = noteSizeAttribute.Value == "cue";
                    }
                }
                else if (noteAttribute.Name == "accidental")
                {
                    if (noteAttribute.Value == "natural") builder.HasNatural = true;
                }
                else if (noteAttribute.Name == "tie")
                {
                    var attribute = noteAttribute.Attribute(XName.Get("type"));
                    if (attribute.Value == "start")
                    {

                        if (builder.TieType == NoteTieType.Stop) builder.TieType = NoteTieType.StopAndStartAnother;
                        else builder.TieType = NoteTieType.Start;
                    }
                    else
                    {
                        builder.TieType = NoteTieType.Stop;
                    }
                }
                else if (noteAttribute.Name == "rest")
                {
                    builder.IsRest = true;
                }
                else if (noteAttribute.Name == "dot")
                {
                    builder.NumberOfDots++;
                }
                else if (noteAttribute.Name == "stem")
                {
                    if (noteAttribute.Value == "down") builder.StemDirection = VerticalDirection.Down;
                    else builder.StemDirection = VerticalDirection.Up;
                    foreach (XAttribute xa in noteAttribute.Attributes())
                    {
                        if (xa.Name == "default-y")
                        {
                            builder.StemDefaultY = float.Parse(xa.Value.Replace('.', Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)));
                            builder.CustomStemEndPosition = true;
                        }
                    }
                }
                else if (noteAttribute.Name == "beam")
                {
                    if (noteAttribute.Value == "begin") builder.BeamList.Add(NoteBeamType.Start);
                    else if (noteAttribute.Value == "end") builder.BeamList.Add(NoteBeamType.End);
                    else if (noteAttribute.Value == "continue") builder.BeamList.Add(NoteBeamType.Continue);
                    else if (noteAttribute.Value == "forward hook") builder.BeamList.Add(NoteBeamType.ForwardHook);
                    else if (noteAttribute.Value == "backward hook") builder.BeamList.Add(NoteBeamType.BackwardHook);
                }
                else if (noteAttribute.Name == "notations")
                {
                    foreach (XElement notationAttribute in noteAttribute.Elements())
                    {
                        if (notationAttribute.Name == "tuplet")
                        {
                            if (notationAttribute.Attribute("type").Value == "start")
                            {
                                builder.Tuplet = TupletType.Start;
                            }
                            else if (notationAttribute.Attribute("type").Value == "stop")
                            {
                                builder.Tuplet = TupletType.Stop;
                            }

                            if (notationAttribute.Attributes().Any(a => a.Name == "placement"))
                            {
                                if (notationAttribute.Attribute("placement").Value == "above") builder.TupletPlacement = VerticalPlacement.Above;
                                else if (notationAttribute.Attribute("placement").Value == "below") builder.TupletPlacement = VerticalPlacement.Below;
                            }
                        }
                        if (notationAttribute.Name == "dynamics")
                        {
                            DirectionPlacementType placement = DirectionPlacementType.Above;
                            int defaultY = 0;
                            string text = "";
                            var attribute = noteAttribute.Attribute("default-y");
                            if (attribute != null)
                            {
                                defaultY = Convert.ToInt32(attribute.Value);
                                placement = DirectionPlacementType.Custom;
                            }
                            attribute = noteAttribute.Attribute("placement");
                            if (attribute != null && placement != DirectionPlacementType.Custom)
                            {
                                if (attribute.Value == "above") placement = DirectionPlacementType.Above;
                                else if (attribute.Value == "below") placement = DirectionPlacementType.Below;
                            }
                            foreach (XElement dynamicsType in notationAttribute.Elements())
                            {
                                text = dynamicsType.Name.LocalName;
                            }
                            Direction dir = new Direction();
                            dir.DefaultY = defaultY;
                            dir.Placement = placement;
                            dir.Text = text;
                            staff.Elements.Add(dir);
                        }
                        else if (notationAttribute.Name == "articulations")
                        {
                            foreach (XElement articulationAttribute in notationAttribute.Elements())
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
                        else if (notationAttribute.Name == "ornaments")
                        {
                            foreach (XElement ornamentAttribute in notationAttribute.Elements())
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
                        else if (notationAttribute.Name == "slur")
                        {
                            builder.Slur = new Slur();

                            if ((Convert.ToInt32(notationAttribute.Attribute("number").Value)) != 1)
                                continue;
                            if (notationAttribute.Attribute("type").Value == "start")
                                builder.Slur.Type = NoteSlurType.Start;
                            else if (notationAttribute.Attribute("type").Value == "stop")
                                builder.Slur.Type = NoteSlurType.Stop;

                            var placementAttribute = notationAttribute.Attributes().FirstOrDefault(a => a.Name == "placement");
                            if (placementAttribute != null) builder.Slur.Placement = placementAttribute.Value == "above" ? VerticalPlacement.Above : VerticalPlacement.Below;

                        }
                        else if (notationAttribute.Name == "fermata")
                        {
                            builder.HasFermataSign = true;
                        }
                        else if (notationAttribute.Name == "sound")
                        {
                            var attribute = notationAttribute.Attribute("dynamics");
                            if (attribute != null) state.CurrentDynamics = Convert.ToInt32(attribute.Value);
                        }
                    }
                }
                else if (noteAttribute.Name == "lyric")
                {
                    //There can be more than one lyrics in one <lyrics> tag. Add lyrics to list once syllable type and text is set. 
                    //Then reset these tags so the next <syllabic> tag starts another lyric. 
                    Lyrics lyricsInstance = new Lyrics();
                    Lyrics.Syllable syllable = new Lyrics.Syllable();
                    bool isSylabicSet = false;
                    bool isTextSet = false;
                    var defaultYattribute = noteAttribute.Attributes().FirstOrDefault(a => a.Name == "default-y");
                    if (defaultYattribute != null) lyricsInstance.DefaultYPosition = UsefulMath.TryParse(defaultYattribute.Value);

                    foreach (XElement lyricAttribute in noteAttribute.Elements())
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
            staff.Elements.Add(builder.Build());
        }
    }
}
