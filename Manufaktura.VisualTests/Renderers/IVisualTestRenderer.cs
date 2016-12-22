using System;
using System.Collections.Generic;

namespace Manufaktura.VisualTests.Renderers
{
    internal interface IVisualTestRenderer
    {
        void GenerateImages();

        List<Exception> RenderExceptions { get; }
    }
}