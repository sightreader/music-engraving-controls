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

        public RenderModes RenderMode
        {
            get { return (RenderModes)GetValue(RenderModeProperty); }
            set { SetValue(RenderModeProperty, value); }
        }

        public static readonly DependencyProperty RenderModeProperty =
            DependencyProperty.Register("RenderMode", typeof(RenderModes), typeof(NoteViewer), new PropertyMetadata(RenderModes.DrawingContext, RenderModeChanged));

        private static void RenderModeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            NoteViewer viewer = obj as NoteViewer;
            if ((RenderModes)args.NewValue == RenderModes.DrawingContext) viewer.Content = null;
            else if ((RenderModes)args.NewValue == RenderModes.Canvas) viewer.RenderOnCanvas();
        }
        
        public NoteViewer()
        {
            InitializeComponent();
            DataContextChanged += NoteViewer_DataContextChanged;
        }

        void NoteViewer_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (RenderMode == RenderModes.DrawingContext) InvalidateVisual();
            else if (RenderMode == RenderModes.Canvas) RenderOnCanvas();
        }

        private void RenderOnCanvas()
        {
            if (!(DataContext is Score)) return;
            Canvas canvas = new Canvas();
            Content = canvas;
            var renderer = new CanvasScoreRenderer(canvas);
            renderer.State.PageWidth = 1200;
            renderer.Render((Score)DataContext);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (RenderMode == RenderModes.DrawingContext && DataContext is Score)
            {
                var renderer = new DrawingContextScoreRenderer(drawingContext);
                renderer.State.PageWidth = 1200;
                renderer.Render((Score)DataContext);
            }
        }

        public enum RenderModes
        {
            DrawingContext, Canvas
        }
    }
}
