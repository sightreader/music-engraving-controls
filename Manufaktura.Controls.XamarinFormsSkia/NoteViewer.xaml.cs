using Manufaktura.Controls.Model;
using Manufaktura.Controls.Skia;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Manufaktura.Controls.XamarinFormsSkia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteViewer : ContentView
    {
        public static readonly BindableProperty ScoreSourceProperty = BindableProperty.Create(nameof(ScoreSource), typeof(Score), typeof(NoteViewer), null);

        public static readonly BindableProperty SettingsProperty = BindableProperty.Create(nameof(Settings), typeof(SKScoreRendererSettings), typeof(NoteViewer), new SKScoreRendererSettings());

        public NoteViewer()
        {
            InitializeComponent();
        }

        public Score ScoreSource
        {
            get { return (Score)GetValue(ScoreSourceProperty); }
            set { SetValue(ScoreSourceProperty, value); }
        }

        public SKScoreRendererSettings Settings
        {
            get { return (SKScoreRendererSettings)GetValue(SettingsProperty); }
            set { SetValue(SettingsProperty, value); }
        }

        private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            using (var renderer = new SKCanvasScoreRenderer(e.Surface.Canvas, Settings))
            {
                renderer.Render(ScoreSource);
            }
        }
    }
}