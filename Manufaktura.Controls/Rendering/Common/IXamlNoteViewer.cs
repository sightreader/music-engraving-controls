using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using System.Collections.Generic;

namespace Manufaktura.Controls.Rendering.Common
{
	public interface IXamlNoteViewer
	{
		IEnumerable<XTransformerParser> XmlTransformations { get; }

		void RenderOnCanvas(Score score);

		void Score_MeasureInvalidated(object sender, Model.Events.InvalidateEventArgs<Measure> e);
	}
}