using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF
{
    /// <summary>
    /// Interaction logic for NoteViewer.xaml
    /// </summary>
    public partial class NoteViewer : UserControl
    {
        public RenderModes RenderMode { get; set; }

        public NoteViewer()
        {
            InitializeComponent();
            RenderMode = RenderModes.DrawingContext;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (RenderMode == RenderModes.DrawingContext && DataContext is Score)
            {
                var renderer = new DrawingContextScoreRenderer(drawingContext);
                renderer.State.PageWidth = ActualWidth;
                renderer.Render((Score)DataContext);
            }
        }

        public enum RenderModes
        {
            DrawingContext, Canvas
        }
    }
}
