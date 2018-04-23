using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Rendering;
using System.Drawing;
using System.Threading.Tasks;
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

        public void LoadFont(MusicFontStyles style, string fontName, float fontSize, string metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            rendererSettings.LoadSMuFLMetadata(metadata);
            rendererSettings.SetFont(style, fontName, fontSize, fontStyle);
        }

        public void LoadFont(MusicFontStyles style, string fontName, float fontSize, SMuFLFontMetadata metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            rendererSettings.CurrentFont = new SMuFLMusicFont();
            rendererSettings.CurrentSMuFLMetadata = metadata;
            rendererSettings.SetFont(style, fontName, fontSize, fontStyle);
        }

        public async Task LoadFontAsync(MusicFontStyles style, string fontName, float fontSize, string metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            await rendererSettings.LoadSMuFLMetadataAsync(metadata);
            rendererSettings.SetFont(style, fontName, fontSize, fontStyle);
        }

        public void LoadFontFromPath(MusicFontStyles style, string fontPath, float fontSize, string metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            rendererSettings.LoadSMuFLMetadata(metadata);
            rendererSettings.SetFontFromPath(style, fontPath, fontSize, fontStyle);
        }

        public void LoadFontFromPath(MusicFontStyles style, string fontPath, float fontSize, SMuFLFontMetadata metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            rendererSettings.CurrentFont = new SMuFLMusicFont();
            rendererSettings.CurrentSMuFLMetadata = metadata;
            rendererSettings.SetFontFromPath(style, fontPath, fontSize, fontStyle);
        }

        public async Task LoadFontFromPathAsync(MusicFontStyles style, string fontPath, float fontSize, string metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            await rendererSettings.LoadSMuFLMetadataAsync(metadata);
            rendererSettings.SetFontFromPath(style, fontPath, fontSize, fontStyle);
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