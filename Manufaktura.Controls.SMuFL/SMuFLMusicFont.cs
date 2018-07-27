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
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Core.Serialization;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Manufaktura.Controls.SMuFL
{
    public class SMuFLMusicFont : IMusicFont
    {
        public static SMuFLFontProfile CreateFromJsonString(string json, bool useLazyProxy = true)
        {
            var metadata = useLazyProxy ? LazyLoadJsonProxy<ISMuFLFontMetadata>.Create(json) : JsonConvert.DeserializeObject<SMuFLFontMetadata>(json);
            return new SMuFLFontProfile(metadata);
        }

        public static SMuFLFontProfile CreateFromBinaryStream(Stream binaryStream)
        {
            var binaryFormatter = new BinaryFormatter();
            var metadata = binaryFormatter.Deserialize(binaryStream) as ISMuFLFontMetadata;
            return new SMuFLFontProfile(metadata);
        }

        public static SMuFLFontProfile CreateFromBinaryArray(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
                return CreateFromBinaryStream(ms);
        }

        public static SMuFLFontProfile CreateFromJsonStream(Stream jsonStream, bool useLazyProxy = true)
        {
            using (var reader = new StreamReader(jsonStream))
            {
                string json = reader.ReadToEnd();
                return CreateFromJsonString(json, useLazyProxy);
            }
        }

        public static SMuFLFontProfile CreateFromJsonResource(Assembly assembly, string resourceFullName, bool useLazyProxy = true)
        {
            using (var stream = assembly.GetManifestResourceStream(resourceFullName))
            using (var reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return CreateFromJsonString(result, useLazyProxy);
            }
        }

        public static SMuFLFontProfile CreateFromJsonResource<TNamespace>(string resourceFileName, bool useLazyProxy = true)
        {
            var assembly = typeof(TNamespace).GetTypeInfo().Assembly;
            var resourceName = $"{typeof(TNamespace).Namespace}.{resourceFileName}";
            return CreateFromJsonResource(assembly, resourceName, useLazyProxy);
        }

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

        public bool IsSMuFLFont => true;

        public string BuildTimeSignature(int number)
        {
            var sb = new StringBuilder();
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit == '0') sb.Append(SMuFLGlyphs.Instance.TimeSig0.Character);
                if (digit == '1') sb.Append(SMuFLGlyphs.Instance.TimeSig1.Character);
                if (digit == '2') sb.Append(SMuFLGlyphs.Instance.TimeSig2.Character);
                if (digit == '3') sb.Append(SMuFLGlyphs.Instance.TimeSig3.Character);
                if (digit == '4') sb.Append(SMuFLGlyphs.Instance.TimeSig4.Character);
                if (digit == '5') sb.Append(SMuFLGlyphs.Instance.TimeSig5.Character);
                if (digit == '6') sb.Append(SMuFLGlyphs.Instance.TimeSig6.Character);
                if (digit == '7') sb.Append(SMuFLGlyphs.Instance.TimeSig7.Character);
                if (digit == '8') sb.Append(SMuFLGlyphs.Instance.TimeSig8.Character);
                if (digit == '9') sb.Append(SMuFLGlyphs.Instance.TimeSig9.Character);
            }
            return sb.ToString();
        }

        public string BuildTupletNumber(int number)
        {
            var sb = new StringBuilder();
            var digits = number.ToString();
            foreach (var digit in digits)
            {
                if (digit == '0') sb.Append(SMuFLGlyphs.Instance.Tuplet0.Character);
                if (digit == '1') sb.Append(SMuFLGlyphs.Instance.Tuplet1.Character);
                if (digit == '2') sb.Append(SMuFLGlyphs.Instance.Tuplet2.Character);
                if (digit == '3') sb.Append(SMuFLGlyphs.Instance.Tuplet3.Character);
                if (digit == '4') sb.Append(SMuFLGlyphs.Instance.Tuplet4.Character);
                if (digit == '5') sb.Append(SMuFLGlyphs.Instance.Tuplet5.Character);
                if (digit == '6') sb.Append(SMuFLGlyphs.Instance.Tuplet6.Character);
                if (digit == '7') sb.Append(SMuFLGlyphs.Instance.Tuplet7.Character);
                if (digit == '8') sb.Append(SMuFLGlyphs.Instance.Tuplet8.Character);
                if (digit == '9') sb.Append(SMuFLGlyphs.Instance.Tuplet9.Character);
            }
            return sb.ToString();
        }
    }
}