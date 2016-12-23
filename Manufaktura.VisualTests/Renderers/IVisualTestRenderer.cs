using System;
using System.Collections.Generic;

namespace Manufaktura.VisualTests.Renderers
{
    internal interface IVisualTestRenderer
    {
        void GenerateImages(string pathToCompare);

        List<Exception> RenderExceptions { get; }
    }
}