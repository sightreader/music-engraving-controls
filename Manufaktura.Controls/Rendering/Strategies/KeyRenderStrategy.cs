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

using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Services;
using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Strategy for rendering a Key.
    /// </summary>
    public class KeyRenderStrategy : MusicalSymbolRenderStrategy<Key>
    {
        /// <summary>
        /// /// Initializes a new instance of KeyRenderStrategy
        /// </summary>
        /// <param name="scoreService"></param>
        public KeyRenderStrategy(IScoreService scoreService) : base(scoreService)
        {
        }

        public bool IsVirtualKey { get; set; }
        public override void Render(Key element, ScoreRendererBase renderer, FontProfile fontProfile)
        {
            if (element.Fifths != 0 && element.Measure != null && element.Measure.Elements.FirstOrDefault() == element)
                scoreService.CursorPositionX += renderer.LinespacesToPixels(1); //Żeby był lekki margines między kreską taktową a symbolem. Być może ta linijka będzie do usunięcia

            scoreService.CurrentKey = element;
            if (!IsVirtualKey) element.TextBlockLocation = new Primitives.Point(scoreService.CursorPositionX, scoreService.CurrentLinePositions[0]);

            if (scoreService.CurrentKey.Fifths > 0)
            {
                var dictionary = CreateDictionary(CircleOfFifths.Sharps, CircleOfFifths.EnumerateSharps, scoreService.CurrentKey.Fifths);
                DrawCharacters(dictionary, renderer, element, fontProfile.MusicFont.DoubleSharp, fontProfile.MusicFont.Sharp);
            }
            else if (scoreService.CurrentKey.Fifths < 0)
            {
                var dictionary = CreateDictionary(CircleOfFifths.Flats, CircleOfFifths.EnumerateFlats, scoreService.CurrentKey.Fifths);
                DrawCharacters(dictionary, renderer, element, fontProfile.MusicFont.DoubleFlat, fontProfile.MusicFont.Flat);
            }

            scoreService.CursorPositionX += 10;
        }

        private Dictionary<Step, int> CreateDictionary(Step[] collection, Func<IEnumerable<Step>> enumerator, int fifths)
        {
            var dictionary = collection.ToDictionary(s => s, s => 0);
            foreach (var step in enumerator().Take(Math.Abs(scoreService.CurrentKey.Fifths)))
            {
                if (fifths > 0) dictionary[step]++;
                else dictionary[step]--;
            }
            return dictionary;
        }

        private void DrawCharacter(char character, double line, ScoreRendererBase renderer, Key element)
        {
            var flatOrSharpPositionY = scoreService.CurrentClef.TextBlockLocation.Y + (scoreService.CurrentClef.Line - line) * renderer.Settings.LineSpacing;
            renderer.DrawCharacter(character, MusicFontStyles.MusicFont, scoreService.CursorPositionX, flatOrSharpPositionY, element);
            scoreService.CursorPositionX += 8;
        }

        private void DrawCharacters(Dictionary<Step, int> dictionary, ScoreRendererBase renderer, Key element, char doubleCharacter, char singleCharacter)
        {
            foreach (var stepContent in dictionary)
            {
                int numberOfSingleAccidentals = Math.Abs(stepContent.Value) % 2;
                int numberOfDoubleAccidentals = Convert.ToInt32(Math.Floor((double)(Math.Abs(stepContent.Value) / 2)));
                var line = GetHighestLineForStep(stepContent.Key);
                for (var i = 0; i < numberOfDoubleAccidentals; i++)
                {
                    DrawCharacter(doubleCharacter, line, renderer, element);
                }
                for (var i = 0; i < numberOfSingleAccidentals; i++)
                {
                    DrawCharacter(singleCharacter, line, renderer, element);
                }
            }
        }

        private double GetHighestLineForStep(Step step)
        {
            var line1 = GetLine(step.ToPitch(scoreService.CurrentClef.Pitch.Octave + 1));

            if (line1 < 6) return line1;

            var line2 = GetLine(step.ToPitch(scoreService.CurrentClef.Pitch.Octave));
            if (line2 < 6) return line2;

            var line3 = GetLine(step.ToPitch(scoreService.CurrentClef.Pitch.Octave - 1));
            return line3;
        }

        private double GetLine(Pitch pitch)
        {
            var stepDistance = (double)Pitch.StepDistance(pitch, scoreService.CurrentClef.Pitch);
            return scoreService.CurrentClef.Line + (stepDistance / 2);
        }
    }
}