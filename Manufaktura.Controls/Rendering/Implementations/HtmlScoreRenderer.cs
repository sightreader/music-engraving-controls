using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    public abstract class HtmlScoreRenderer : ScoreRenderer<StringBuilder>
    {
        public HtmlScoreRendererSettings TypedSettings { get { return Settings as HtmlScoreRendererSettings; } }
        public string ScoreElementName { get; set; }
        protected HtmlScoreRenderer(StringBuilder sb)
            : base(sb)
        {
        }


        
    }
}
