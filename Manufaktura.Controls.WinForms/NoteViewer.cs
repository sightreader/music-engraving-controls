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

        public void LoadFont(string fontName, float fontSize, string metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            rendererSettings.LoadSMuFLMetadata(metadata);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.TrillFont, fontName, fontSize, fontStyle);
        }

        public void LoadFont(string fontName, float fontSize, SMuFLFontMetadata metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            rendererSettings.CurrentFont = new SMuFLMusicFont();
            rendererSettings.CurrentSMuFLMetadata = metadata;
            rendererSettings.SetFont(MusicFontStyles.MusicFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.TrillFont, fontName, fontSize, fontStyle);
        }

        public async Task LoadFontAsync(string fontName, float fontSize, string metadata, FontStyle fontStyle = FontStyle.Regular)
        {
            await rendererSettings.LoadSMuFLMetadataAsync(metadata);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, fontName, fontSize, fontStyle);
            rendererSettings.SetFont(MusicFontStyles.TrillFont, fontName, fontSize, fontStyle);
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