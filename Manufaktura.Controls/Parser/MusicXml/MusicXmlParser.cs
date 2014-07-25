using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser
{
    public class MusicXmlParser : ScoreParser<string>
    {
        public override Score Parse(string xmlDocument)  //TODO: Refactor! Exception handling!
        {
            Score score = new Score();
            int skipMeasures = 0;
            string partID = "";
            bool firstLoop = true;
            int currentTempo = 120;
            int currentDynamics = 80;

            XDocument document = XDocument.Parse(xmlDocument);
            foreach (XElement staffNode in document.Descendants(XName.Get("part")))
            {
                Staff staff = new Staff();
                score.Staves.Add(staff);
                foreach (XElement measureNode in staffNode.Descendants(XName.Get("measure")))
                {

                    bool barlineAlreadyAdded = false;
                    if (measureNode.Parent.Name == "part")  //Don't take the other voices than the upper into account / Nie uwzględniaj innych głosów niż górny
                    {
                        if (!firstLoop)
                        {
                            if (measureNode.Parent.Attribute(XName.Get("id")).Value != partID) break;
                        }
                        else
                        {
                            partID = measureNode.Parent.Attribute(XName.Get("id")).Value;
                        }
                    }
                    if (skipMeasures > 0) { skipMeasures--; continue; }
                    if (!measureNode.HasElements) continue;

                    foreach (XElement elementNode in measureNode.Descendants())
                    {
                        if (elementNode.HasElements == false) continue;
                        if (elementNode.Name == "attributes")
                        {
                            foreach (XElement attribute in elementNode.Descendants())
                            {
                                if (attribute.Name == "clef")
                                {
                                    ClefType typeOfClef = ClefType.GClef;
                                    int line = 1;
                                    foreach (XElement clefAttribute in attribute.Descendants())
                                    {
                                        if (clefAttribute.Name == "sign")
                                        {
                                            if (clefAttribute.Value.ToUpper() == "G")
                                            {
                                                typeOfClef = ClefType.GClef;
                                            }
                                            else if (clefAttribute.Value.ToUpper() == "C")
                                            {
                                                typeOfClef = ClefType.CClef;
                                            }
                                            else if (clefAttribute.Value.ToUpper() == "F")
                                            {
                                                typeOfClef = ClefType.FClef;
                                            }
                                            else throw (new Exception("Unknown clef"));
                                        }
                                        if (clefAttribute.Name == "line")
                                        {
                                            line = Convert.ToInt16(clefAttribute.Value);
                                        }

                                    }
                                    staff.Elements.Add(new Clef(typeOfClef, line));

                                }
                                if (attribute.Name == "time")
                                {
                                    uint numberOfBeats = 4;
                                    uint beatType = 4;
                                    TimeSignatureType sType = TimeSignatureType.Numbers;
                                    foreach (XElement timeAttribute in attribute.Descendants())
                                    {
                                        if (timeAttribute.Name == "beats")
                                            numberOfBeats = Convert.ToUInt32(timeAttribute.Value);
                                        if (timeAttribute.Name == "beat-type")
                                            beatType = Convert.ToUInt32(timeAttribute.Value);
                                    }
                                    if (attribute.Attributes().Count() > 0)
                                    {
                                        foreach (XAttribute a in attribute.Attributes())
                                        {
                                            if (a.Name == "symbol")
                                            {
                                                if (a.Value == "common")
                                                    sType = TimeSignatureType.Common;
                                                else if (a.Value == "cut")
                                                    sType = TimeSignatureType.Cut;
                                            }
                                        }
                                    }
                                    staff.Elements.Add(new TimeSignature(sType, numberOfBeats, beatType));

                                }
                                if (attribute.Name == "key")
                                {
                                    foreach (XElement keyAttribute in attribute.Descendants())
                                    {
                                        if (keyAttribute.Name == "fifths")
                                        {
                                            staff.Elements.Add(new Key(Convert.ToInt16(keyAttribute.Value)));
                                        }
                                    }
                                }
                                if (attribute.Name == "measure-style")
                                {
                                    foreach (XElement measureStyleAttribute in attribute.Descendants())
                                    {
                                        if (measureStyleAttribute.Name == "multiple-rest")
                                        {
                                            skipMeasures = Convert.ToInt32(measureStyleAttribute.Value) - 1;
                                        }
                                    }
                                }

                            }
                        }
                        else if (elementNode.Name == "sound")
                        {
                            var attribute = elementNode.Attribute(XName.Get("tempo"));
                            if (attribute != null) currentTempo = Convert.ToInt32(attribute.Value);
                            attribute = elementNode.Attribute(XName.Get("dynamics"));
                            if (attribute != null) currentDynamics = Convert.ToInt32(attribute.Value);
                        }
                        else if (elementNode.Name == "direction")
                        {
                            foreach (XElement directionNode in elementNode.Descendants())
                            {
                                if (directionNode.Name == "sound")
                                {
                                    var attribute = elementNode.Attribute(XName.Get("tempo"));
                                    if (attribute != null) currentTempo = Convert.ToInt32(attribute.Value);
                                    attribute = elementNode.Attribute(XName.Get("dynamics"));
                                    if (attribute != null) currentDynamics = Convert.ToInt32(attribute.Value);
                                }
                                if (directionNode.Name == "direction-type")
                                {
                                    foreach (XElement directionTypeNode in directionNode.Descendants())
                                    {
                                        if (directionTypeNode.Name == "dynamics")
                                        {
                                            DirectionPlacementType placement = DirectionPlacementType.Above;
                                            int defaultY = 0;
                                            string text = "";
                                            var attribute = elementNode.Attribute(XName.Get("default-y"));
                                            if (attribute != null)
                                            {
                                                defaultY = Convert.ToInt32(attribute.Value);
                                                placement = DirectionPlacementType.Custom;
                                            }
                                            attribute = elementNode.Attribute(XName.Get("placement"));
                                            if (attribute != null && placement != DirectionPlacementType.Custom)
                                            {
                                                if (attribute.Value == "above")
                                                    placement = DirectionPlacementType.Above;
                                                else if (attribute.Value == "below")
                                                    placement = DirectionPlacementType.Below;
                                            }
                                            foreach (XElement dynamicsType in directionTypeNode.Descendants())
                                            {
                                                text = dynamicsType.Name.LocalName;
                                            }
                                            Direction dir = new Direction();
                                            dir.DefaultY = defaultY;
                                            dir.Placement = placement;
                                            dir.Text = text;
                                            staff.Elements.Add(dir);
                                        }
                                    }
                                }
                            }
                        }
                        else if (elementNode.Name == "note")
                        {
                            int octave = 0;
                            int alter = 0;
                            string step = "C";
                            bool isRest = false;
                            int numberOfDots = 0;
                            MusicalSymbolDuration duration = MusicalSymbolDuration.Whole;
                            NoteStemDirection stemDirection = NoteStemDirection.Up;
                            NoteTieType tieType = NoteTieType.None;
                            TupletType tuplet = TupletType.None;
                            List<NoteBeamType> beamList = new List<NoteBeamType>();
                            List<LyricsType> lyric = new List<LyricsType>();
                            List<string> lyricText = new List<string>();
                            ArticulationPlacementType articulationPlacement = ArticulationPlacementType.Below;
                            ArticulationType articulation = ArticulationType.None;
                            bool hasNatural = false;
                            bool isGraceNote = false;
                            bool isChordElement = false;
                            bool hasFermataSign = false;
                            float stemDefaultY = 28;
                            bool customStemEndPosition = false;
                            int tremoloLevel = 0;
                            NoteSlurType slur = NoteSlurType.None;
                            NoteTrillMark trillMark = NoteTrillMark.None;
                            int voice = 1;

                            foreach (XElement noteAttribute in elementNode.Descendants())
                            {
                                if (noteAttribute.Name == "pitch")
                                {
                                    foreach (XElement pitchAttribute in noteAttribute.Descendants())
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
                                    if (noteAttribute.Value == "down") stemDirection = NoteStemDirection.Down;
                                    else stemDirection = NoteStemDirection.Up;
                                    foreach (XAttribute xa in noteAttribute.Attributes())
                                    {
                                        if (xa.Name == "default-y")
                                        {
                                            stemDefaultY = float.Parse(xa.Value.Replace('.',  Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator)));
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
                                    foreach (XElement notationAttribute in noteAttribute.Descendants())
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
                                            foreach (XElement dynamicsType in notationAttribute.Descendants())
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
                                            foreach (XElement articulationAttribute in notationAttribute.Descendants())
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
                                                    articulationPlacement = ArticulationPlacementType.Above;
                                                else if (articulationAttribute.Attribute("placement").Value == "below")
                                                    articulationPlacement = ArticulationPlacementType.Below;

                                            }
                                        }
                                        else if (notationAttribute.Name == "ornaments")
                                        {
                                            foreach (XElement ornamentAttribute in notationAttribute.Descendants())
                                            {
                                                if (ornamentAttribute.Name == "trill-mark")
                                                {
                                                    if (ornamentAttribute.Attribute("placement").Value == "above")
                                                        trillMark = NoteTrillMark.Above;
                                                    else if (ornamentAttribute.Attribute("placement").Value == "below")
                                                        trillMark = NoteTrillMark.Below;
                                                }
                                                else if (ornamentAttribute.Name == "tremolo")
                                                {
                                                    tremoloLevel = Convert.ToInt32(ornamentAttribute.Value);
                                                }
                                            }

                                        }
                                        else if (notationAttribute.Name == "slur")
                                        {
                                            if ((Convert.ToInt32(notationAttribute.Attribute("number").Value)) != 1)
                                                continue;
                                            if (notationAttribute.Attribute("type").Value == "start")
                                                slur = NoteSlurType.Start;
                                            else if (notationAttribute.Attribute("type").Value == "stop")
                                                slur = NoteSlurType.Stop;

                                        }
                                        else if (notationAttribute.Name == "fermata")
                                        {
                                            hasFermataSign = true;
                                        }
                                        else if (notationAttribute.Name == "sound")
                                        {
                                            var attribute = notationAttribute.Attribute("dynamics");
                                            if (attribute != null) currentDynamics = Convert.ToInt32(attribute.Value);
                                        }
                                    }
                                }
                                else if (noteAttribute.Name == "lyric")
                                {
                                    foreach (XElement lyricAttribute in noteAttribute.Descendants())
                                    {
                                        if (lyricAttribute.Name == "syllabic")
                                        {
                                            if (lyricAttribute.Value == "begin")
                                            {
                                                lyric.Add(LyricsType.Begin);
                                            }
                                            else if (lyricAttribute.Value == "middle")
                                            {
                                                lyric.Add(LyricsType.Middle);
                                            }
                                            else if (lyricAttribute.Value == "end")
                                            {
                                                lyric.Add(LyricsType.End);
                                            }
                                            else if (lyricAttribute.Value == "single")
                                            {
                                                lyric.Add(LyricsType.Single);
                                            }
                                        }
                                        else if (lyricAttribute.Name == "text")
                                        {
                                            lyricText.Add(lyricAttribute.Value);
                                        }
                                    }
                                }

                            }
                            if (beamList.Count == 0) beamList.Add(NoteBeamType.Single);
                            if (!isRest)
                            {
                                Note nt = new Note(step, alter, octave, duration, stemDirection, tieType, beamList);
                                nt.NumberOfDots = numberOfDots;
                                nt.Tuplet = tuplet;
                                nt.Lyrics = lyric;
                                nt.LyricTexts = lyricText;
                                nt.Articulation = articulation;
                                nt.ArticulationPlacement = articulationPlacement;
                                nt.HasNatural = hasNatural;
                                nt.IsGraceNote = isGraceNote;
                                nt.IsChordElement = isChordElement;
                                nt.StemDefaultY = stemDefaultY;
                                nt.CustomStemEndPosition = customStemEndPosition;
                                nt.CurrentTempo = currentTempo;
                                nt.TrillMark = trillMark;
                                nt.Slur = slur;
                                nt.HasFermataSign = hasFermataSign;
                                nt.TremoloLevel = tremoloLevel;
                                nt.Voice = voice;
                                nt.Dynamics = currentDynamics;
                                staff.Elements.Add(nt);
                            }
                            else
                            {
                                Rest rt = new Rest(duration);
                                rt.NumberOfDots = numberOfDots;
                                rt.Tuplet = tuplet;
                                rt.MultiMeasure = skipMeasures + 1;
                                rt.CurrentTempo = currentTempo;
                                rt.HasFermataSign = hasFermataSign;
                                rt.Voice = voice;
                                staff.Elements.Add(rt);
                            }


                        }
                        else if (elementNode.Name == "barline")
                        {
                            Barline b = new Barline();
                            foreach (XElement barlineAttribute in elementNode.Descendants())
                            {
                                if (barlineAttribute.Name == "repeat")
                                {
                                    var attribute = barlineAttribute.Attribute("direction");
                                    if (attribute != null)
                                    {
                                        if (attribute.Value == "forward") b.RepeatSign = RepeatSignType.Forward;
                                        else if (attribute.Value == "backward") b.RepeatSign = RepeatSignType.Backward;

                                        staff.Elements.Add(b);
                                        barlineAlreadyAdded = true;
                                    }

                                }
                            }
                        }


                    }

                    if (!barlineAlreadyAdded)
                        staff.Elements.Add(new Barline());
                    firstLoop = false;
                }
            }
            return score;

        }

        public override string ParseBack(Score score)
        {
            throw new NotImplementedException("This parser does not support saving to MusicXml.");
        }
    }
}
