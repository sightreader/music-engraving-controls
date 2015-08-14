using Android.Graphics;
using Android.Views;
using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.Android
{
    public class NoteViewer : View
    {
        private Score _innerScore;

        public Score InnerScore { get { return _innerScore; } }

        public bool IsPanoramaMode
        {
            get;
            set;
        }

        public Score ScoreSource
        {
            get;
            set;
        }

        public string XmlSource
        {
            get;
            set;
        }

        protected AndroidScoreRenderer Renderer { get; set; }

        public NoteViewer(global::Android.Content.Context context)
            : base(context)
        {

        }

        protected override void OnDraw(Canvas canvas)
        {
            if (ScoreSource == null)
            {
                if (XmlSource == null) return;
                ScoreSource = XmlSource.ToScore();
            }

            _innerScore = ScoreSource;
            if (ScoreSource == null) return;

            Renderer = new AndroidScoreRenderer(canvas);
            Renderer.Settings.IsPanoramaMode = IsPanoramaMode;

            Renderer.Render(_innerScore);
        }
    }
}