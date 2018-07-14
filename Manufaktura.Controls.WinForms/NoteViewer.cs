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
using Manufaktura.Controls.Rendering;
using System.Drawing;
using System.Windows.Forms;

namespace Manufaktura.Controls.WinForms
{
    public partial class NoteViewer : Control
    {
        private GdiPlusScoreRendererSettings rendererSettings = new GdiPlusScoreRendererSettings();

        public Model.Score DataSource { get; set; }

        public ScoreRenderingModes RenderingMode { get; set; } = ScoreRenderingModes.AllPages;

        protected override bool DoubleBuffered
        {
            get
            {
                return true;    //Important for performance
            }
            set
            {
                //Do nothing
            }
        }

        public void LoadDefaultFont() => rendererSettings.SetPolihymniaFont();

        public void LoadDefaultFontFromPath(string fontPath)
        {
            rendererSettings.SetPolihymniaFontFromPath(fontPath);
        }

        public void LoadFont(string fontName, string metadataJson, float musicFontSize = 25, float graceNoteFontSize = 16, float staffFontSize = 30.5f)
        {
            rendererSettings.LoadSMuFLMetadata(metadataJson);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, fontName, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, fontName, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, fontName, staffFontSize);
        }

        public void LoadFont(string fontName, SMuFLFontMetadata metadata, float musicFontSize = 25, float graceNoteFontSize = 16, float staffFontSize = 30.5f)
        {
            rendererSettings.CurrentFont = new SMuFLMusicFont();
            rendererSettings.CurrentSMuFLMetadata = metadata;
            rendererSettings.SetFont(MusicFontStyles.MusicFont, fontName, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, fontName, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, fontName, staffFontSize);
        }

        public async void LoadFontAsync(string fontName, string metadataJson, float musicFontSize = 25, float graceNoteFontSize = 16, float staffFontSize = 30.5f)
        {
            await rendererSettings.LoadSMuFLMetadataAsync(metadataJson);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, fontName, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, fontName, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, fontName, staffFontSize);
        }

        public void LoadFontFromPath(string fontPath, string metadataJson, float musicFontSize = 25, float graceNoteFontSize = 16, float staffFontSize = 30.5f)
        {
            rendererSettings.LoadSMuFLMetadata(metadataJson);
            rendererSettings.SetFontFromPath(MusicFontStyles.MusicFont, fontPath, musicFontSize);
            rendererSettings.SetFontFromPath(MusicFontStyles.GraceNoteFont, fontPath, graceNoteFontSize);
            rendererSettings.SetFontFromPath(MusicFontStyles.StaffFont, fontPath, staffFontSize);
        }

        public void LoadFontFromPath(string fontPath, SMuFLFontMetadata metadata, float musicFontSize = 25, float graceNoteFontSize = 16, float staffFontSize = 30.5f)
        {
            rendererSettings.CurrentFont = new SMuFLMusicFont();
            rendererSettings.CurrentSMuFLMetadata = metadata;
            rendererSettings.SetFontFromPath(MusicFontStyles.MusicFont, fontPath, musicFontSize);
            rendererSettings.SetFontFromPath(MusicFontStyles.GraceNoteFont, fontPath, graceNoteFontSize);
            rendererSettings.SetFontFromPath(MusicFontStyles.StaffFont, fontPath, staffFontSize);
        }

        public async void LoadFontFromPathAsync(string fontPath, string metadataJson, float musicFontSize = 25, float graceNoteFontSize = 16, float staffFontSize = 30.5f)
        {
            await rendererSettings.LoadSMuFLMetadataAsync(metadataJson);
            rendererSettings.SetFontFromPath(MusicFontStyles.MusicFont, fontPath, musicFontSize);
            rendererSettings.SetFontFromPath(MusicFontStyles.GraceNoteFont, fontPath, graceNoteFontSize);
            rendererSettings.SetFontFromPath(MusicFontStyles.StaffFont, fontPath, staffFontSize);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DataSource == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GdiPlusScoreRenderer renderer = new GdiPlusScoreRenderer(e.Graphics, rendererSettings);
            renderer.Settings.PageWidth = Width;
            renderer.Settings.RenderingMode = RenderingMode;
            renderer.Render(DataSource);
        }
    }
}