using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering;
using System.Linq;

namespace Manufaktura.UnitTests.Rendering
{
	public class UnitTestScoreRenderer : ScoreRenderer<IScoreRenderingTestResultsRepository>
	{
		public UnitTestScoreRenderer(IScoreRenderingTestResultsRepository canvas)
			: base(canvas)
		{
		}

		public override void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner)
		{
			var entry = new ScoreRenderingTestEntry();
			entry.Location = GetTopLeftPoint(new Point(rect.X, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			entry.Size = GetSize(new Point(rect.X, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
			SetIndexes(entry, owner);
			Canvas.Put(entry);
		}

		public override void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner)
		{
			var entry = new ScoreRenderingTestEntry();
			entry.Location = GetTopLeftPoint(p1, p2, p3, p4);
			entry.Size = GetSize(p1, p2, p3, p4);
			entry.Type = owner.GetType().Name;
			SetIndexes(entry, owner);
			Canvas.Put(entry);
		}

		public override void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner)
		{
			var entry = new ScoreRenderingTestEntry();
			entry.Location = GetTopLeftPoint(startPoint, endPoint);
			entry.Size = GetSize(startPoint, endPoint);
			entry.Type = owner.GetType().Name;
			SetIndexes(entry, owner);
			Canvas.Put(entry);
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner)
		{
			var entry = new ScoreRenderingTestEntry();
			entry.Location = location;
			entry.Text = text;
			entry.Type = owner.GetType().Name;
			SetIndexes(entry, owner);
			Canvas.Put(entry);
		}

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner)
		{
		}

		private Point GetSize(params Point[] points)
		{
			return new Point(points.Max(p => p.X) - points.Min(p => p.X), points.Max(p => p.Y) - points.Min(p => p.Y));
		}

		private Point GetTopLeftPoint(params Point[] points)
		{
			return new Point(points.Min(p => p.X), points.Min(p => p.Y));
		}

		private void SetIndexes(ScoreRenderingTestEntry entry, MusicalSymbol symbol)
		{
			entry.Type = symbol.GetType().Name;
			var matchingStaff = CurrentScore.Staves.FirstOrDefault(s => s.Elements.Contains(symbol));
			if (matchingStaff == null) return;
			entry.StaffNo = CurrentScore.Staves.IndexOf(matchingStaff) + 1;
			entry.StaffIndex = CurrentScore.Staves[entry.StaffNo - 1].Elements.IndexOf(symbol);
		}
	}
}