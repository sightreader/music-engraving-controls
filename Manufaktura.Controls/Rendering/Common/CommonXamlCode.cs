using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using System.Xml.Linq;

namespace Manufaktura.Controls.Rendering.Common
{
	public class CommonXamlCode
	{
		public static void ScoreSourceChanged(IXamlNoteViewer viewer, Score oldValue, Score newValue)
		{
			if (oldValue != null) oldValue.Safety.BoundControl = null;
			Score.SanityCheck(newValue, viewer);

			newValue.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(newValue);
			newValue.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}

		public static void XmlSourceChanged(IXamlNoteViewer viewer, string oldValue, string newValue)
		{
			XDocument xmlDocument = XDocument.Parse(newValue);
			//Apply transformations:
			if (viewer.XmlTransformations != null)
			{
				foreach (var transformation in viewer.XmlTransformations) xmlDocument = transformation.Parse(xmlDocument);
			}

			MusicXmlParser parser = new MusicXmlParser();
			var score = parser.Parse(xmlDocument);
			score.MeasureInvalidated -= viewer.Score_MeasureInvalidated;
			viewer.RenderOnCanvas(score);
			score.MeasureInvalidated += viewer.Score_MeasureInvalidated;
		}
	}
}