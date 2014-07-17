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

namespace Manufaktura.Controls.WindowsPhoneSilverlight
{
    public partial class NoteViewer : UserControl
    {
        public NoteViewer()
        {
            InitializeComponent();
        }

        public void RefreshView()
        {
            if (!(DataContext is Score)) return;
            Canvas canvas = new Canvas();
            canvas.Background = new SolidColorBrush(Colors.White);
            Content = canvas;
            var renderer = new CanvasScoreRenderer(canvas);
            renderer.State.PageWidth = 1200;
            renderer.Render((Score)DataContext);
        }

    }
}
