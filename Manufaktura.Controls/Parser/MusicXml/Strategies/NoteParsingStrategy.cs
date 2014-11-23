using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class NoteParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "note"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            int octave = 0;
            int alter = 0;
            string step = "C";
            bool isRest = false;
            int numberOfDots = 0;
            MusicalSymbolDuration duration = MusicalSymbolDuration.Whole;
            VerticalDirection stemDirection = VerticalDirection.Up;
            NoteTieType tieType = NoteTieType.None;
            TupletType tuplet = TupletType.None;
            VerticalPlacement? tupletPlacement = null;
            List<NoteBeamType> beamList = new List<NoteBeamType>();
            List<Lyrics> lyrics = new List<Lyrics>();
            VerticalPlacement articulationPlacement = VerticalPlacement.Below;
            ArticulationType articulation = ArticulationType.None;
            bool hasNatural = false;
            bool isGraceNote = false;
            bool isCueNote = false;
            bool isChordElement = false;
            bool hasFermataSign = false;
            float stemDefaultY = 28;
            double defaultX = 0;
            bool customStemEndPosition = false;
            int tremoloLevel = 0;
            Slur slur = null;
            NoteTrillMark trillMark = NoteTrillMark.None;
            Mordent mordent = null;
            int voice = 1;

            var defaultXAttribute = element.Attributes().Where(a => a.Name == "default-x").FirstOrDefault();
            if (defaultXAttribute != null) double.TryParse(defaultXAttribute.Value, NumberStyles.Number, CultureInfo.InvariantCulture, out defaultX);

            foreach (XElement noteAttribute in element.Elements())
            {
                if (noteAttribute.Name == "pitch")
                {
                    foreach (XElement pitchAttribute in noteAttribute.Elements())
                    {

                        if (pitchAttribute.Name == "step")
                        {
                            step = pitchAttribute.Value;
                        }
                        else if (pitchAttribute.Name == "octave")
                        {
                            octave = Convert.ToInt16(pitchAttribute.Value);
                        }
                        else if (pitchAttribute.Name == "alter")
                        {
                            alter = Convert.ToInt16(pitchAttribute.Value);
                        }
                    }
                }
                else if (noteAttribute.Name == "voice")
                {
                    voice = Convert.ToInt32(noteAttribute.Value);
                }
                else if (noteAttribute.Name == "grace")
                {
                    isGraceNote = true;
                }
                else if (noteAttribute.Name == "chord")
                {
                    isChordElement = true;
                }
                else if (noteAttribute.Name == "type")
                {
                    if (noteAttribute.Value == "whole") duration = MusicalSymbolDuration.Whole;
                    else if (noteAttribute.Value == "half") duration = MusicalSymbolDuration.Half;
                    else if (noteAttribute.Value == "quarter") duration = MusicalSymbolDuration.Quarter;
                    else if (noteAttribute.Value == "eighth") duration = MusicalSymbolDuration.Eighth;
                    else if (noteAttribute.Value == "16th") duration = MusicalSymbolDuration.Sixteenth;
                    else if (noteAttribute.Value == "32nd") duration = MusicalSymbolDuration.d32nd;
                    else if (noteAttribute.Value == "64th") duration = MusicalSymbolDuration.d64th;
                    else if (noteAttribute.Value == "128th") duration = MusicalSymbolDuration.d128th;

                    var noteSizeAttribute = noteAttribute.Attributes().FirstOrDefault(a => a.Name == "size");
                    if (noteSizeAttribute != null)
                    {
                        isCueNote = noteSizeAttribute.Value == "cue";
                    }
                }
                else if (noteAttribute.Name == "accidental")
                {
                    if (noteAttribute.Value == "natural") hasNatural = true;
                }
                else if (noteAttribute.Name == "tie")
                {
                    var attribute = noteAttribute.Attribute(XName.Get("type"));
                    if (attribute.Value == "start")
                    {

                        if (tieType == NoteTieType.Stop)
                            tieType = NoteTieType.StopAndStartAnother;
                        else tieType = NoteTieType.Start;
                    }
                    else
                    {
                        tieType = NoteTieType.Stop;
                    }
                }
                else if (noteAttribute.Name == "rest")
                {
                    isRest = true;
                }
                else if (noteAttribute.Name == "dot")
                {
                    numberOfDots++;
                }
                else if (noteAttribute.Name == "stem")
                {
                    if (noteAttribute.Value == "down") stemDirection = VerticalDirection.Down;
                    else stemDirection = VerticalDirection.Up;
                    foreach (XAttribute xa in noteAttribute.Attributes())
                    {
                        if (xa.Name == "default-y")
                        {
                            stemDefaultY = float.Parse(xa.Value.Replace('.', Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)));
                            customStemEndPosition = true;
                        }
                    }
                }
                else if (noteAttribute.Name == "beam")
                {
                    if (noteAttribute.Value == "begin") beamList.Add(NoteBeamType.Start);
                    else if (noteAttribute.Value == "end") beamList.Add(NoteBeamType.End);
                    else if (noteAttribute.Value == "continue") beamList.Add(NoteBeamType.Continue);
                    else if (noteAttribute.Value == "forward hook") beamList.Add(NoteBeamType.ForwardHook);
                    else if (noteAttribute.Value == "backward hook") beamList.Add(NoteBeamType.BackwardHook);
                }
                else if (noteAttribute.Name == "notations")
                {
                    foreach (XElement notationAttribute in noteAttribute.Elements())
                    {
                        if (notationAttribute.Name == "tuplet")
                        {
                            if (notationAttribute.Attribute("type").Value == "start")
                            {
                                tuplet = TupletType.Start;
                            }
                            else if (notationAttribute.Attribute("type").Value == "stop")
                            {
                                tuplet = TupletType.Stop;
                            }

                            if (notationAttribute.Attributes().Any(a => a.Name == "placement"))
                            {
                                if (notationAttribute.Attribute("placement").Value == "above") tupletPlacement = VerticalPlacement.Above;
                                else if (notationAttribute.Attribute("placement").Value == "below") tupletPlacement = VerticalPlacement.Below;
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
                                    articulation = ArticulationType.Staccato;
                                }
                                else if (articulationAttribute.Name == "accent")
                                {
                                    articulation = ArticulationType.Accent;
                                }

                                if (articulationAttribute.Attribute("placement").Value == "above")
                                    articulationPlacement = VerticalPlacement.Above;
                                else if (articulationAttribute.Attribute("placement").Value == "below")
                                    articulationPlacement = VerticalPlacement.Below;

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
                                            trillMark = NoteTrillMark.Above;
                                        else if (placementAttribute.Value == "below")
                                            trillMark = NoteTrillMark.Below;
                                    }
                                }
                                else if (ornamentAttribute.Name == "tremolo")
                                {
                                    tremoloLevel = Convert.ToInt32(ornamentAttribute.Value);
                                }
                                else if (ornamentAttribute.Name == "inverted-mordent")
                                {
                                    mordent = new Mordent() { IsInverted = true };
                                    
                                    if (placementAttribute != null)
                                    {
                                        if (placementAttribute.Value == "above")
                                            mordent.Placement = VerticalPlacement.Above;
                                        else if (placementAttribute.Value == "below")
                                            mordent.Placement = VerticalPlacement.Below;
                                    }

                                    var attr = ornamentAttribute.Attributes().FirstOrDefault(a => a.Name == "default-x");
                                    if (attr != null) mordent.DefaultXPosition = UsefulMath.TryParse(attr.Value);
                                    attr = ornamentAttribute.Attributes().FirstOrDefault(a => a.Name == "default-y");
                                    if (attr != null) mordent.DefaultYPosition = UsefulMath.TryParse(attr.Value);
                                }
                            }

                        }
                        else if (notationAttribute.Name == "slur")
                        {
                            slur = new Slur();

                            if ((Convert.ToInt32(notationAttribute.Attribute("number").Value)) != 1)
                                continue;
                            if (notationAttribute.Attribute("type").Value == "start")
                                slur.Type = NoteSlurType.Start;
                            else if (notationAttribute.Attribute("type").Value == "stop")
                                slur.Type = NoteSlurType.Stop;

                            var placementAttribute = notationAttribute.Attributes().FirstOrDefault(a => a.Name == "placement");
                            if (placementAttribute != null) slur.Placement = placementAttribute.Value == "above" ? VerticalPlacement.Above : VerticalPlacement.Below;

                        }
                        else if (notationAttribute.Name == "fermata")
                        {
                            hasFermataSign = true;
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

                    lyrics.Add(lyricsInstance);
                }
            }
            if (beamList.Count == 0) beamList.Add(NoteBeamType.Single);
            if (!isRest)
            {
                Note nt = new Note(step, alter, octave, duration, stemDirection, tieType, beamList);
                nt.NumberOfDots = numberOfDots;
                nt.Tuplet = tuplet;
                nt.TupletPlacement = tupletPlacement;
                nt.Lyrics = lyrics;
                nt.Articulation = articulation;
                nt.ArticulationPlacement = articulationPlacement;
                nt.HasNatural = hasNatural;
                nt.IsGraceNote = isGraceNote;
                nt.IsCueNote = isCueNote;
                nt.IsChordElement = isChordElement;
                nt.StemDefaultY = stemDefaultY;
                nt.DefaultXPosition = defaultX;
                nt.CustomStemEndPosition = customStemEndPosition;
                nt.CurrentTempo = state.CurrentTempo;
                nt.TrillMark = trillMark;
                nt.Slur = slur;
                nt.HasFermataSign = hasFermataSign;
                nt.TremoloLevel = tremoloLevel;
                nt.Voice = voice;
                nt.Dynamics = state.CurrentDynamics;
                if (mordent != null) nt.Ornaments.Add(mordent);
                staff.Elements.Add(nt);
            }
            else
            {
                Rest rt = new Rest(duration);
                rt.NumberOfDots = numberOfDots;
                rt.Tuplet = tuplet;
                rt.TupletPlacement = tupletPlacement;
                rt.MultiMeasure = state.SkipMeasures + 1;
                rt.CurrentTempo = state.CurrentTempo;
                rt.HasFermataSign = hasFermataSign;
                rt.Voice = voice;
                rt.DefaultXPosition = defaultX;
                staff.Elements.Add(rt);
            }

        }
    }
}
