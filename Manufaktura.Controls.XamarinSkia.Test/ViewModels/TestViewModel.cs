/*
 * Copyright 2019 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Controls.Extensions;
using Manufaktura.Controls.Model;
using Manufaktura.Music.Model;
using Manufaktura.Music.Model.MajorAndMinor;

namespace Manufaktura.Controls.XamarinSkia.Test.ViewModels
{
    public class TestViewModel : ViewModel
    {
        private Score testScore;

        public Score TestScore { get => testScore; set { testScore = value; OnPropertyChanged(); } }

        public TestViewModel()
        {
            var score = Score.CreateOneStaffScore(Clef.Treble, MajorScale.G);
            score.FirstStaff.AddRange(StaffBuilder
                .FromPitches(new[] { Pitch.C4, Pitch.E4, Pitch.G4, Pitch.B4, Pitch.D5 })
                .AddUniformRhythm(RhythmicDuration.Quarter));
            TestScore = score;
        }
    }
}