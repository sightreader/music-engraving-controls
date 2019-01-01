using System;
using System.Collections.Generic;

namespace Manufaktura.VisualTests.Renderers
{
    internal interface IVisualTestRenderer
    {
        void GenerateImages(string pathToCompare, string outputPath);

        List<Exception> RenderExceptions { get; }
    }
}