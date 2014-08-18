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
    public partial class Snapper : UserControl
    {
        public Snapper()
        {
            LayoutUpdated += Snapper_LayoutUpdated;
            Snap = PixelSnapType.Closest;
        }

        public PixelSnapType Snap { get; set; }

        void Snapper_LayoutUpdated(object sender, EventArgs e)
        {
            if (Content == null)
                return;

            if (Snap == PixelSnapType.None)
            {
                Content.RenderTransform = null;
                return;
            }

            // Remove existing transform so that it is not a part of the calculations

            if (_transform != null)
            {
                _transform.X = 0;
                _transform.Y = 0;
            }

            // Calculate actual location

            MatrixTransform globalTransform = Content.TransformToVisual(Application.Current.RootVisual) as MatrixTransform;
            Point p = globalTransform.Matrix.Transform(_zero);

            double deltaX = Snap == PixelSnapType.Closest ? Math.Round(p.X) - p.X : (int)p.X - p.X;
            double deltaY = Snap == PixelSnapType.Closest ? Math.Round(p.Y) - p.Y : (int)p.Y - p.Y;

            // Set new transform

            if (deltaX != 0 || deltaY != 0)
            {
                if (_transform == null)
                {
                    _transform = new TranslateTransform();
                    Content.RenderTransform = _transform;
                }

                if (deltaX != 0)
                {
                    _transform.X = deltaX;
                }

                if (deltaY != 0)
                {
                    _transform.Y = deltaY;
                }
            }
        }

        TranslateTransform _transform;
        private static readonly Point _zero = new Point(0, 0);
    }

    public enum PixelSnapType
    {
        None,       // No snapping
        Closest,    // Snap to closest pixel using Math.Round
        TopLeft     // Snap to integral portion of pixel by casting to int
    }
}
