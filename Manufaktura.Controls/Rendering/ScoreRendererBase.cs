using Manufaktura.Controls.IoC;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Primitives;
using Manufaktura.Controls.Services;
using System.Collections.Generic;
using System.Linq;

namespace Manufaktura.Controls.Rendering
{
    public abstract class ScoreRendererBase
    {
        protected IAlterationService alterationService = new AlterationService();
        protected IMeasurementService measurementService = new MeasurementService();
        protected IScoreService scoreService = new ScoreService();
        private ManufakturaResolver resolver = new ManufakturaResolver();

        public ScoreRendererSettings Settings { get; internal set; }

        public ScoreRendererState State { get; protected set; }

        public ScoreInfo ScoreInformation { get { return new ScoreInfo(scoreService); } }

        public MusicalSymbolRenderStrategyBase[] Strategies { get; private set; }

        public double TextBlockHeight { get; protected set; }

        protected ScoreRendererBase()
        {
            State = new ScoreRendererState();
            Settings = new ScoreRendererSettings();
            resolver.AddServices(measurementService, alterationService, scoreService);
            Strategies = resolver.ResolveAll<MusicalSymbolRenderStrategyBase>().ToArray();
            TextBlockHeight = 25;
        }

        public void DrawArc(Rectangle rect, double startAngle, double sweepAngle, MusicalSymbol owner)
        {
            DrawArc(rect, startAngle, sweepAngle, new Pen(Settings.DefaultColor, 1), owner);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="rect"></param>
        /// <param name="startAngle"></param>
        /// <param name="sweepAngle"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
        public abstract void DrawArc(Rectangle rect, double startAngle, double sweepAngle, Pen pen, MusicalSymbol owner);

        public void DrawBezier(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, MusicalSymbol owner)
        {
            DrawBezier(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3), new Point(x4, y4), new Pen(Settings.DefaultColor, 1), owner);
        }

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

        public void DrawLine(double startX, double startY, double endX, double endY, MusicalSymbol owner)
        {
            DrawLine(new Point(startX, startY), new Point(endX, endY), new Pen(Settings.DefaultColor, 1), owner);
        }

        public void DrawLine(Point startPoint, Point endPoint, MusicalSymbol owner)
        {
            DrawLine(startPoint, endPoint, new Pen(Settings.DefaultColor, 1), owner);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Be aware of owner.IsVisible property. You should decide how to implement invisibility, for example
        /// not draw anything at all, draw in transparent color, etc.
        /// </remarks>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <param name="pen"></param>
        /// <param name="owner"></param>
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
        /// <param name="location">Location of text block</param>
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

        public MusicalSymbolRenderStrategyBase GetProperRenderStrategy(MusicalSymbol element)
        {
            return Strategies.FirstOrDefault(s => s.SymbolType == element.GetType());
        }

        internal void BreakSystem(double distance = 0)
        {
            scoreService.CurrentSystem.Width = State.CursorPositionX;
            ReturnCarriage();

            scoreService.CurrentSystem.Height = distance == 0 ? (scoreService.CurrentStaffHeight + Settings.LineSpacing ) * scoreService.CurrentScore.Staves.Count : distance;

            List<double> newLinePositions = new List<double>();
            foreach (var position in scoreService.CurrentLinePositions) newLinePositions.Add(position + scoreService.CurrentSystem.Height);
            scoreService.BeginNewSystem();
            scoreService.LinePositions[scoreService.CurrentSystemNo, scoreService.CurrentStaffNo] = newLinePositions.ToArray();
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
            measurementService.LastMeasurePositionX = 0;
        }

        internal void ReturnCarriage()
        {
            State.CursorPositionX = 0;
        }
    }
}