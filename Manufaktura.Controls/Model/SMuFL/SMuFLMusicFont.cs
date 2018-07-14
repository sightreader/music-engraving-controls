/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using Manufaktura.Controls.Model.Fonts;
using System;

namespace Manufaktura.Controls.Model.SMuFL
{
    public class SMuFLMusicFont : IMusicFont
    {
        public char AugmentationDot => '\uE1E7';
        public char BraceLeft => '\uE000';
        public char BraceRight => '\uE001';
        public char Bracket => '\uE002';
        public char CClef => '\uE05C';
        public char CommonTime => '\uE08A';
        public char CutTime => '\uE08B';
        public char DoubleFlat => '\uE264';
        public char DoubleSharp => '\uE263';
        public char FClef => '\uE062';
        public char FermataDown => '\uE4C1';
        public char FermataUp => '\uE4C0';
        public char Flat => '\uE260';
        public char GClef => '\uE050';
        public char Mordent => SMuFLGlyphs.Instance.OrnamentMordent.Character;
        public char MordentInverted => SMuFLGlyphs.Instance.OrnamentMordentInverted.Character;
        public char MordentShort => '\uE56C';
        public char Natural => '\uE261';
        public char NoteEighth => throw new NotImplementedException();
        public char NoteFlag128th => '\uE248';
        public char NoteFlag128thRev => '\uE249';
        public char NoteFlag32nd => '\uE244';
        public char NoteFlag32ndRev => '\uE245';
        public char NoteFlag64th => '\uE246';
        public char NoteFlag64thRev => '\uE247';
        public char NoteFlagEighth => '\uE240';
        public char NoteFlagEighthRev => '\uE241';
        public char NoteFlagSixteenth => '\uE242';
        public char NoteFlagSixteenthRev => '\uE243';
        public char NoteHalf => '\uE0A3';
        public char NoteheadBlack => SMuFLGlyphs.Instance.NoteheadBlack.Character;
        public char NoteheadHalf => '\uE0A3';
        public char NoteQuarter => '\uE0A4';
        public char NoteSixteenth => SMuFLGlyphs.Instance.Note16ThUp.Character;
        public char NoteWhole => '\uE0A2';
        public char PercussionClef => '\uE069';
        public char RepeatBackward => '\uE041';
        public char RepeatForward => '\uE040';
        public char Rest32nd => '\uE4E8';
        public char RestEighth => '\uE4E6';
        public char RestHalf => '\uE4E4';
        public char RestQuarter => '\uE4E5';
        public char RestSixteenth => '\uE4E7';
        public char RestWhole => '\uE4E3';
        public char Sharp => '\uE262';
        public char SquareBracketLeft => SMuFLGlyphs.Instance.Bracket.Character;
        public char Staff4Lines => throw new NotImplementedException();
        public char Staff5Lines => throw new NotImplementedException();
        public char Time0 => '\uE080';
        public char Time1 => '\uE081';
        public char Time2 => '\uE082';
        public char Time3 => '\uE083';
        public char Time4 => '\uE084';
        public char Time5 => '\uE085';
        public char Time6 => '\uE086';
        public char Time7 => '\uE087';
        public char Time8 => '\uE088';
        public char Time9 => '\uE089';
        public char Trill => '\uE566';

        public char CClef8va => CClef;

        public char CClef8vb => '\uE05D';

        public char CClef15ma => CClef;

        public char CClef15mb => CClef;

        public char FClef8va => '\uE065';

        public char FClef8vb => '\uE064';

        public char FClef15ma => '\uE066';

        public char FClef15mb => '\uE063';

        public char GClef8va => '\uE053';

        public char GClef8vb => '\uE052';

        public char GClef15ma => '\uE054';

        public char GClef15mb => '\uE051';

        public char NoteheadBlackCue => SMuFLGlyphs.Instance.NoteheadBlack.Character;

        public char NoteheadHalfCue => SMuFLGlyphs.Instance.NoteheadHalf.Character;

        public char NoteheadBlackLarge => SMuFLGlyphs.Instance.NoteheadBlack.Character;

        public char NoteheadHalfLarge => SMuFLGlyphs.Instance.NoteheadHalf.Character;

        public char NoteDoubleWhole => '\uE0A0';

        public char NoteDoubleWholeCue => SMuFLGlyphs.Instance.NoteDoubleWhole.Character;

        public char NoteDoubleWholeLarge => SMuFLGlyphs.Instance.NoteDoubleWhole.Character;

        public char NoteWholeCue => SMuFLGlyphs.Instance.NoteWhole.Character;

        public char NoteWholeLarge => SMuFLGlyphs.Instance.NoteWhole.Character;
    }
}