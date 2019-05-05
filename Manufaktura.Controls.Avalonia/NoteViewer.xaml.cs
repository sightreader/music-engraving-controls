/*
 * Copyright 2019 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Threading;
using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Avalonia.Bindings;
using Manufaktura.Controls.Avalonia.Renderers;
using Manufaktura.Controls.Interactivity;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Avalonia
{
    /// <summary>
    /// Interaction logic for NoteViewer.xaml
    /// </summary>
    public class NoteViewer : UserControl
    {
        public static readonly StyledProperty<int> CurrentPageProperty = AvaloniaProperty.Register<NoteViewer, int>(nameof(CurrentPage), 1);
        public static readonly StyledProperty<InvalidatingModes> InvalidatingModeProperty = AvaloniaProperty.Register<NoteViewer, InvalidatingModes>(nameof(InvalidatingMode), InvalidatingModes.RedrawInvalidatedRegion);
        public static readonly StyledProperty<bool> IsInsertModeProperty = AvaloniaProperty.Register<NoteViewer, bool>(nameof(IsInsertMode), false);
        public static readonly StyledProperty<bool> IsMusicPaperModeProperty = AvaloniaProperty.Register<NoteViewer, bool>(nameof(IsMusicPaperMode), false);
        public static readonly StyledProperty<bool> IsOccupyingSpaceProperty = AvaloniaProperty.Register<NoteViewer, bool>(nameof(IsOccupyingSpace), true);
        public static readonly StyledProperty<bool> IsSelectableProperty = AvaloniaProperty.Register<NoteViewer, bool>(nameof(IsSelectable), true);
        public static readonly StyledProperty<PlaybackCursorPosition> PlaybackCursorPositionProperty = AvaloniaProperty.Register<NoteViewer, PlaybackCursorPosition>(nameof(PlaybackCursorPosition), default(PlaybackCursorPosition));
        public static readonly StyledProperty<ScoreRenderingModes> RenderingModeProperty = AvaloniaProperty.Register<NoteViewer, ScoreRenderingModes>(nameof(RenderingMode), ScoreRenderingModes.Panorama);
        public static readonly StyledProperty<Score> ScoreSourceProperty = AvaloniaProperty.Register<NoteViewer, Score>(nameof(ScoreSource), null);
        public static readonly StyledProperty<MusicalSymbol> SelectedElementProperty = AvaloniaProperty.Register<NoteViewer, MusicalSymbol>(nameof(SelectedElement), null);
        public static readonly StyledProperty<string> XmlSourceProperty = AvaloniaProperty.Register<NoteViewer, string>(nameof(XmlSource), null);
        public static readonly StyledProperty<IEnumerable<XTransformerParser>> XmlTransformationsProperty = AvaloniaProperty.Register<NoteViewer, IEnumerable<XTransformerParser>>(nameof(XmlTransformations), null);
        public static readonly StyledProperty<double> ZoomFactorProperty = AvaloniaProperty.Register<NoteViewer, double>(nameof(ZoomFactor), 1d);
        private DraggingState _draggingState = new DraggingState();
        private Score _innerScore;
        private Color previousColor;
        private AvaloniaScoreRendererSettings rendererSettings = new AvaloniaScoreRendererSettings();

        public NoteViewer()
        {
            AvaloniaXamlLoader.Load(this);
            this.GetObservable(CurrentPageProperty).Subscribe(v => RenderOnCanvas(InnerScore));
            this.GetObservable(IsMusicPaperModeProperty).Subscribe(v => rendererSettings.IsMusicPaperMode = v);
            this.GetObservable(PlaybackCursorPositionProperty).Subscribe(v =>
            {
                if (InnerScore == null) return;
                if (Renderer == null) return;

                if (!v.IsValid) return;

                Dispatcher.UIThread.InvokeAsync(new Action(() => Renderer.DrawPlaybackCursor(v)), DispatcherPriority.Background);
            });
            this.GetObservable(RenderingModeProperty).Subscribe(v =>
            {
                if (InnerScore == null) return;
                RenderOnCanvas(InnerScore);
            });
            this.GetPropertyChangedObservable(ScoreSourceProperty).Subscribe(p =>
            {
                if (p.OldValue != null) ((Score)p.OldValue).Safety.BoundControl = null;
                Score.SanityCheck((Score)p.NewValue, this);

                RenderOnCanvas((Score)p.NewValue);
            });
            this.GetObservable(XmlSourceProperty).Subscribe(v =>
            {
                if (v == null) return;
                XDocument xmlDocument = XDocument.Parse(v);
                //Apply transformations:
                if (XmlTransformations != null)
                {
                    foreach (var transformation in XmlTransformations) xmlDocument = transformation.Parse(xmlDocument);
                }

                MusicXmlParser parser = new MusicXmlParser();
                var score = parser.Parse(xmlDocument);
                RenderOnCanvas(score);
            });
            this.GetObservable(ZoomFactorProperty).Subscribe(v => InvalidateMeasure());
        }

        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        public Score InnerScore { get { return _innerScore; } }

        public InvalidatingModes InvalidatingMode
        {
            get { return (InvalidatingModes)GetValue(InvalidatingModeProperty); }
            set { SetValue(InvalidatingModeProperty, value); }
        }

        public bool IsInsertMode
        {
            get { return (bool)GetValue(IsInsertModeProperty); }
            set { SetValue(IsInsertModeProperty, value); }
        }

        public bool IsMusicPaperMode
        {
            get { return (bool)GetValue(IsMusicPaperModeProperty); }
            set { SetValue(IsMusicPaperModeProperty, value); }
        }

        /// <summary>
        /// If this property is set to True, the control will calculate it's size to be properly arranged in containers such as ScrollViewer.
        /// If it is set to False, the control will overlap other controls. Default: True.
        /// </summary>
        public bool IsOccupyingSpace
        {
            get { return (bool)GetValue(IsOccupyingSpaceProperty); }
            set { SetValue(IsOccupyingSpaceProperty, value); }
        }

        public bool IsSelectable
        {
            get { return (bool)GetValue(IsSelectableProperty); }
            set { SetValue(IsSelectableProperty, value); }
        }

        public PlaybackCursorPosition PlaybackCursorPosition
        {
            get { return (PlaybackCursorPosition)GetValue(PlaybackCursorPositionProperty); }
            set { SetValue(PlaybackCursorPositionProperty, value); }
        }

        public ScoreRenderingModes RenderingMode
        {
            get { return (ScoreRenderingModes)GetValue(RenderingModeProperty); }
            set { SetValue(RenderingModeProperty, value); }
        }

        public Score ScoreSource
        {
            get { return (Score)GetValue(ScoreSourceProperty); }
            set { SetValue(ScoreSourceProperty, value); }
        }

        public MusicalSymbol SelectedElement
        {
            get { return (MusicalSymbol)GetValue(SelectedElementProperty); }
            set { SetValue(SelectedElementProperty, value); }
        }

        public string XmlSource
        {
            get { return (string)GetValue(XmlSourceProperty); }
            set { SetValue(XmlSourceProperty, value); }
        }

        public IEnumerable<XTransformerParser> XmlTransformations
        {
            get { return (IEnumerable<XTransformerParser>)GetValue(XmlTransformationsProperty); }
            set { SetValue(XmlTransformationsProperty, value); }
        }

        public double ZoomFactor
        {
            get { return (double)GetValue(ZoomFactorProperty); }
            set { SetValue(ZoomFactorProperty, value); }
        }

        protected AvaloniaCanvasScoreRenderer Renderer { get; set; }

        public void SetCustomFont(FontFamily family, double baseline, FontProfile musicFontProfile)
        {
            rendererSettings.SetCustomFontPreset(family, baseline, musicFontProfile);
        }

        public void MoveLayout(StaffSystem system, Point delta)
        {
            if (Renderer == null) return;
            Renderer.MoveLayout(system, delta);
        }

        public void Select(MusicalSymbol element)
        {
            if (SelectedElement != null) ColorElement(SelectedElement, previousColor);   //Reset color on previously selected element
            SelectedElement = element;

            var note = SelectedElement as Note;
            if (note != null) _draggingState.MidiPitchOnStartDragging = note.MidiPitch;

            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);      //Apply color on selected element

            Debug.WriteLine($"{element?.ToString()} Measure: {element?.Measure?.ToString()} System: {element?.Measure?.System?.ToString()}");
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            if (Renderer == null || !IsOccupyingSpace) return base.MeasureOverride(availableSize);
            var mainCanvas = this.FindControl<Canvas>("MainCanvas");
            var children = mainCanvas.Children.OfType<Control>();
            foreach (var child in children) child.Measure(availableSize);

            if (children.Any())
            {
                var xx = children.Max(c => Canvas.GetLeft(c) * ZoomFactor + c.DesiredSize.Width * ZoomFactor);
                var yy = children.Max(c => Canvas.GetTop(c) * ZoomFactor + c.DesiredSize.Height * ZoomFactor);
                return new Size(xx, yy);
            }
            return base.MeasureOverride(availableSize);
        }

        /*private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsSelectable) return;
            MainCanvas.CaptureMouse();  //Capture mouse to receive events even if the pointer is outside the control

            //Start dragging:
            _draggingState.StartDragging(AvaloniaCanvasScoreRenderer.ConvertPoint(e.GetPosition(MainCanvas)));

            //Check if element under cursor is staff element:
            Control element = e.OriginalSource as Control;
            if (element == null) return;
            if (!Renderer.OwnershipDictionary.ContainsKey(element)) return;

            //Set selected element:
            Select(Renderer.OwnershipDictionary[element]);
        }*/

        private void ColorElement(MusicalSymbol element, Color color)
        {
            if (Renderer == null) return;   //If SelectedElement value has been changed by binding and renderer has not yet been created, just ignore this method.
            var ownerships = Renderer.OwnershipDictionary.Where(o => o.Value == SelectedElement);
            foreach (var ownership in ownerships)
            {
                TextBlock textBlock = ownership.Key as TextBlock;
                if (textBlock != null)
                {
                    var brush = textBlock.Foreground as SolidColorBrush;
                    if (brush != null) previousColor = brush.Color;
                    textBlock.Foreground = new SolidColorBrush(color);
                }

                Shape shape = ownership.Key as Shape;
                if (shape != null)
                {
                    var brush = shape.Stroke as SolidColorBrush;
                    if (brush != null) previousColor = brush.Color;
                    shape.Stroke = new SolidColorBrush(color);
                }
            }
        }

        /*private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!IsSelectable) return;
            MainCanvas.ReleaseMouseCapture();
            _draggingState.StopDragging();
        }

        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsSelectable) return;
            if (!_draggingState.IsDragging || _innerScore == null) return;

            Point currentPosition = e.GetPosition(MainCanvas);
            var strategy = DraggingStrategy.For(SelectedElement);
            if (strategy != null)
            {
                strategy.Drag(Renderer, SelectedElement, _draggingState, AvaloniaCanvasScoreRenderer.ConvertPoint(currentPosition));
            }

            if (InvalidatingMode == InvalidatingModes.RedrawAllScore) RenderOnCanvas(_innerScore);
        }*/

        private void RenderOnCanvas(Measure measure)
        {
            var mainCanvas = this.FindControl<Canvas>("MainCanvas");
            if (Renderer == null) Renderer = new AvaloniaCanvasScoreRenderer(mainCanvas, rendererSettings);
            var beamGroupsForThisMeasure = measure.Staff.BeamGroups.Where(bg => bg.Members.Any(m => m.Measure == measure));
            foreach (var beamGroup in beamGroupsForThisMeasure)
            {
                var frameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == beamGroup).Select(d => d.Key).ToList();
                frameworkElements.RemoveAllFrom(Renderer.Canvas);
            }

            foreach (var element in measure.Elements.Where(e => !(e is Barline)))
            {
                var note = element as Note;
                if (note != null)
                {
                    foreach (var lyric in note.Lyrics)
                    {
                        var lyricsFrameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == lyric).Select(d => d.Key).ToList();
                        lyricsFrameworkElements.RemoveAllFrom(Renderer.Canvas);
                    }
                }
                var frameworkElements = Renderer.OwnershipDictionary.Where(d => d.Value == element).Select(d => d.Key).ToList();
                frameworkElements.RemoveAllFrom(Renderer.Canvas);
            }

            var brush = Foreground as SolidColorBrush;
            if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);

            Renderer.Render(measure);
            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);
            InvalidateMeasure();
        }

        private async void RenderOnCanvas(Score score)
        {
            _innerScore = score;
            if (score == null) return;

            score.MeasureInvalidated -= Score_MeasureInvalidated;
            score.StaffInvalidated -= Score_StaffInvalidated;
            score.ScoreInvalidated -= Score_ScoreInvalidated;

            var mainCanvas = this.FindControl<Canvas>("MainCanvas");
            mainCanvas.Children.Clear();
            Renderer = new AvaloniaCanvasScoreRenderer(mainCanvas, rendererSettings);
            Renderer.Settings.RenderingMode = RenderingMode;
            Renderer.Settings.CurrentPage = CurrentPage;
            var brush = Foreground as SolidColorBrush;
            if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);
            if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;

            Renderer.Render(score);

            if (SelectedElement != null) ColorElement(SelectedElement, Colors.Magenta);
            InvalidateMeasure();

            score.MeasureInvalidated += Score_MeasureInvalidated;
            score.StaffInvalidated += Score_StaffInvalidated;
            score.ScoreInvalidated += Score_ScoreInvalidated;
        }

        private void Score_MeasureInvalidated(object sender, Model.Events.InvalidateEventArgs<Measure> e)
        {
            if (InvalidatingMode != InvalidatingModes.RedrawInvalidatedRegion) return;
            var score = (sender as MusicalSymbol)?.Staff?.Score ?? e.InvalidatedObject?.Staff?.Score;
            if (score == null) return;
            score.MeasureInvalidated -= Score_MeasureInvalidated;
            RenderOnCanvas(e.InvalidatedObject);
            score.MeasureInvalidated += Score_MeasureInvalidated;
        }

        private void Score_ScoreInvalidated(object sender, Model.Events.InvalidateEventArgs<Score> e)
        {
            RenderOnCanvas(e.InvalidatedObject);
        }

        private void Score_StaffInvalidated(object sender, Model.Events.InvalidateEventArgs<Staff> e)
        {
            RenderOnCanvas(e.InvalidatedObject.Score);
        }
    }
}