using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.Silverlight
{
    public partial class NoteViewer : UserControl
    {
        public NoteViewer()
        {
            InitializeComponent();
            DataContextChanged += NoteViewer_DataContextChanged;
        }

        void NoteViewer_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            RenderOnCanvas();
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

    }
}
