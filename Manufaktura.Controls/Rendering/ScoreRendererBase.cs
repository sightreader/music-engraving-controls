using Manufaktura.Controls.IoC;
using Manufaktura.Controls.Linq;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Rendering.Postprocessing;
using Manufaktura.Controls.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRendererBase
    {
        protected IAlterationService alterationService = new AlterationService();
        protected IBeamingService beamingService = new BeamingService();
        protected IMeasurementService measurementService = new MeasurementService();
        protected IScoreService scoreService = new ScoreService();
        private ManufakturaResolver resolver = new ManufakturaResolver();

        public virtual Score CurrentScore { get; internal set; }

        public virtual List<Exception> Exceptions { get; protected set; }

        public virtual IFinishingTouch[] FinishingTouches { get; private set; }

        public virtual ScoreInfo ScoreInformation { get { return new ScoreInfo(scoreService); } }

        public virtual ScoreRendererSettings Settings { get; internal set; }

        internal virtual MusicalSymbolRenderStrategyBase[] Strategies { get; private set; }

        protected ScoreRendererBase()
        {
            Settings = new ScoreRendererSettings();
            resolver.AddServices(measurementService, alterationService, scoreService, beamingService);
            Strategies = resolver.ResolveAll<MusicalSymbolRenderStrategyBase>().ToArray();
            FinishingTouches = resolver.ResolveAll<IFinishingTouch>().ToArray();
            Exceptions = new List<Exception>();
        }

        public void DrawArc(Rectangle rect, double startAngle, double sweepAngle, MusicalSymbol owner)
        {
            DrawArc(rect, startAngle, sweepAngle, new Pen(Settings.DefaultColor, 1), owner);
        }

        /// <summary>
        /// Draws arc.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="rect">Rectangle within which arc should be drawn</param>
        /// <param name="startAngle">Start angle</param>
        /// <param name="sweepAngle">Sweep angle</param>
        /// <param name="pen">Pen settings</param>
        /// <param name="owner">Owning symbol</param>
        public abstract void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner);

        /// <summary>
        /// Draws Bezier curve.
        /// </summary>
        /// <param name="x1">Start point X</param>
        /// <param name="y1">Start point Y</param>
        /// <param name="x2">Control point 1 X</param>
        /// <param name="y2">Control point 1 Y</param>
        /// <param name="x3">Control point 2 X</param>
        /// <param name="y3">Control point 2 Y</param>
        /// <param name="x4">End point X</param>
        /// <param name="y4">End point Y</param>
        /// <param name="owner">Owning symbol</param>
        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, MusicalSymbol owner)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), new Pen(Settings.DefaultColor, 1), owner);
        }

        /// <summary>
        /// Draws Bezier curve.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="x1">Start point X</param>
        /// <param name="y1">Start point Y</param>
        /// <param name="x2">Control point 1 X</param>
        /// <param name="y2">Control point 1 Y</param>
        /// <param name="x3">Control point 2 X</param>
        /// <param name="y3">Control point 2 Y</param>
        /// <param name="x4">End point X</param>
        /// <param name="y4">End point Y</param>
        /// <param name="pen">Pen settings</param>
        /// <param name="owner">Owning symbol</param>
        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, Pen pen, MusicalSymbol owner)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), pen, owner);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
        public abstract void DrawBezier(Point p1, Point p2, Point p3, Point p4, Pen pen, MusicalSymbol owner);

        /// <summary>
        /// Draws line from startPoint to endPoint.
        /// </summary>
        /// <param name="startX">Start point X coordinate.</param>
        /// <param name="startY">Start point Y coordinate.</param>
        /// <param name="endX">End point Y coordinate.</param>
        /// <param name="endY">End point Y coordinate.</param>
        /// <param name="owner">Owner element</param>
        public void DrawLine(double startX, double startY, double endX, double endY, MusicalSymbol owner)
        {
            DrawLine(new Point(startX, startY), new Point(endX, endY), new Pen(Settings.DefaultColor, 1), owner);
        }

        /// <summary>
        /// Draws line from startPoint to endPoint.
        /// </summary>
        /// <param name="startPoint">Start point</param>
        /// <param name="endPoint">End point</param>
        /// <param name="owner">Owner element</param>
        public void DrawLine(Point startPoint, Point endPoint, MusicalSymbol owner)
        {
            DrawLine(startPoint, endPoint, new Pen(Settings.DefaultColor, 1), owner);
        }

        /// <summary>
        /// Draws line from startPoint to endPoint with specific pen.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="startPoint">Start point</param>
        /// <param name="endPoint">End point</param>
        /// <param name="pen">Pen</param>
        /// <param name="owner">Owner element</param>
        public abstract void DrawLine(Point startPoint, Point endPoint, Pen pen, MusicalSymbol owner);

        /// <summary>
        /// Draws text (i.e. note heads, lyrics, articulation symbols) in default color in proper location with proper fontStyle.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="text">Text to draw</param>
        /// <param name="fontStyle">Fontstyle of text</param>
        /// <param name="owner">Owning MusicalSymbol</param>
        public void DrawString(string text, MusicFontStyles fontStyle, double x, double y, MusicalSymbol owner)
        {
            DrawString(text, fontStyle, new Point(x, y), Settings.DefaultColor, owner);
        }

        /// <summary>
        /// Draws text (i.e. note heads, lyrics, articulation symbols) in default color in proper location with proper fontStyle.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="text">Text to draw</param>
        /// <param name="fontStyle">Fontstyle of text</param>
        /// <param name="location">Location of text block</param>
        /// <param name="owner">Owning MusicalSymbol</param>
        public void DrawString(string text, MusicFontStyles fontStyle, Point location, MusicalSymbol owner)
        {
            DrawString(text, fontStyle, location, Settings.DefaultColor, owner);
        }

        /// <summary>
        /// Draws text (i.e. note heads, lyrics, articulation symbols) in given color in proper location with proper fontStyle.
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="text">Text to draw</param>
        /// <param name="fontStyle">Fontstyle of text</param>
        /// <param name="location">Location of text block</param>
        /// <param name="color">Color of text</param>
        /// <param name="owner">Owning MusicalSymbol</param>
        public abstract void DrawString(string text, MusicFontStyles fontStyle, Point location, Color color, MusicalSymbol owner);

        public abstract void DrawStringInBounds(string text, MusicFontStyles fontStyle, Point location, Size size, Color color, MusicalSymbol owner);

        public abstract void Render(Score score);

        internal void BreakSystem(double distance = 0)
        {
            //var sumOfMeasures = scoreService.AllMeasures
            //    .Where(m => m.Width.HasValue && m.System == scoreService.CurrentSystem && m.Staff == scoreService.CurrentStaff).Sum(m => m.Width.Value);
            scoreService.CurrentSystem.Width = scoreService.CursorPositionX;
            ReturnCarriage();

            if (scoreService.CurrentSystem.Height == 0)
            {
                scoreService.CurrentSystem.Height = distance == 0 ? (scoreService.CurrentStaffHeight + Settings.LineSpacing) * scoreService.CurrentScore.Staves.Count : distance;
            }

            List<double> newLinePositions = new List<double>();
            foreach (var position in scoreService.CurrentLinePositions) newLinePositions.Add(position + scoreService.CurrentSystem.Height);
            scoreService.BeginNewSystem();
            scoreService.LinePositions[scoreService.CurrentSystemNo, scoreService.CurrentStaffNo] = newLinePositions.ToArray();
            scoreService.CurrentSystem.LinePositions = scoreService.LinePositions[scoreService.CurrentSystemNo];
            measurementService.LastMeasurePositionX = 0;
        }

        internal void BreakToNextStaff(double distance = 0)
        {
            if (scoreService.CurrentStaff == null)
            {
                scoreService.BeginNewStaff();
                double sharpLineModifier = 0.5;

                for (int i = 0; i < 5; i++)
                {
                    scoreService.CurrentLinePositions[i] = Settings.PaddingTop + i * Settings.LineSpacing + sharpLineModifier;
                    scoreService.CurrentSystem.LinePositions = scoreService.LinePositions[scoreService.CurrentSystemNo];
                }
                return;
            }
            if (scoreService.CurrentScore.Staves.Count < 2)
            {
                return;
            }

            ReturnCarriage();
            scoreService.CurrentStaff.Height = distance == 0 ? scoreService.CurrentStaffHeight + Settings.LineSpacing + 30 : distance;

            List<double> newLinePositions = new List<double>();
            scoreService.ReturnToFirstSystem();
            foreach (var position in scoreService.CurrentLinePositions) newLinePositions.Add(position + scoreService.CurrentStaff.Height);
            scoreService.BeginNewStaff();

            scoreService.LinePositions[scoreService.CurrentSystemNo, scoreService.CurrentStaffNo] = newLinePositions.ToArray();
            scoreService.CurrentSystem.LinePositions = scoreService.LinePositions[scoreService.CurrentSystemNo];
            measurementService.LastMeasurePositionX = 0;
        }

        internal void ReturnCarriage()
        {
            scoreService.CursorPositionX = 0;
        }

        protected void DetermineClef(Staff staff)
        {
            var clef = staff.Elements.FirstOrDefault(MusicalSymbolType.Clef) as Clef;
            if (clef == null) return;

            scoreService.CurrentClef = clef;
            var clefPositionY = scoreService.CurrentLinePositions[4] - ((clef.Line - 1) * Settings.LineSpacing);
            clef.TextBlockLocation = new Point(scoreService.CursorPositionX, clefPositionY - Settings.TextBlockHeight);
            DrawString(clef.MusicalCharacter, MusicFontStyles.MusicFont, clef.TextBlockLocation.X, clef.TextBlockLocation.Y, clef);
            scoreService.CursorPositionX += 20;
        }

        protected MusicalSymbolRenderStrategyBase GetProperRenderStrategy(MusicalSymbol element)
        {
            return Strategies.FirstOrDefault(s => s.SymbolType == element.GetType());
        }

        protected void RenderStaff(Staff staff)
        {
            BreakToNextStaff();
            if (!Settings.IgnoreCustomElementPositions && Settings.IsPanoramaMode)
            {
                double newPageWidth = staff.Measures.Where(m => m.Width.HasValue).Sum(m => m.Width.Value * Settings.CustomElementPositionRatio);
                if (newPageWidth > Settings.PageWidth) Settings.PageWidth = newPageWidth;
            }

            DetermineClef(staff);
            alterationService.Reset();

            foreach (MusicalSymbol symbol in staff.Elements)
            {
                try
                {
                    var renderStrategy = GetProperRenderStrategy(symbol);
                    if (renderStrategy != null) renderStrategy.Render(symbol, this);
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }

            scoreService.CurrentSystem.Width = scoreService.CursorPositionX;
            foreach (var finishingTouch in FinishingTouches) finishingTouch.PerformOnStaff(staff, this);
        }
    }
}