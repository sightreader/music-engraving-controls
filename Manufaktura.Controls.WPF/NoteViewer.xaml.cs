/*
 * Copyright 2018 Manufaktura Programów Jacek Salamon http://musicengravingcontrols.com/
 * MIT LICENCE
 
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Interactivity;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;

namespace Manufaktura.Controls.WPF
{
    /// <summary>
    /// Interaction logic for NoteViewer.xaml
    /// </summary>
    public partial class NoteViewer : UserControl
    {
        public static readonly DependencyProperty CurrentPageProperty = DependencyPropertyEx.Register<NoteViewer, int>(v => v.CurrentPage, 1, CurrentPageChanged);
        public static readonly DependencyProperty InvalidatingModeProperty = DependencyPropertyEx.Register<NoteViewer, InvalidatingModes>(v => v.InvalidatingMode, InvalidatingModes.RedrawInvalidatedRegion);
        public static readonly DependencyProperty IsAsyncProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsAsync, false);
        public static readonly DependencyProperty IsInsertModeProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsInsertMode, false);
        public static readonly DependencyProperty IsOccupyingSpaceProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsOccupyingSpace, true);
        public static readonly DependencyProperty IsSelectableProperty = DependencyPropertyEx.Register<NoteViewer, bool>(v => v.IsSelectable, true);
        public static readonly DependencyProperty PlaybackCursorPositionProperty = DependencyPropertyEx.Register<NoteViewer, PlaybackCursorPosition>(v => v.PlaybackCursorPosition, default(PlaybackCursorPosition), PlaybackCursorPositionChanged);
        public static readonly DependencyProperty RenderingModeProperty = DependencyPropertyEx.Register<NoteViewer, ScoreRenderingModes>(v => v.RenderingMode, ScoreRenderingModes.Panorama, RenderingModeChanged);
        public static readonly DependencyProperty ScoreSourceProperty = DependencyPropertyEx.Register<NoteViewer, Score>(v => v.ScoreSource, null, ScoreSourceChanged);
        public static readonly DependencyProperty SelectedElementProperty = DependencyPropertyEx.Register<NoteViewer, MusicalSymbol>(v => v.SelectedElement, null);
        public static readonly DependencyProperty XmlSourceProperty = DependencyPropertyEx.Register<NoteViewer, string>(v => v.XmlSource, null, XmlSourceChanged);
        public static readonly DependencyProperty XmlTransformationsProperty = DependencyPropertyEx.Register<NoteViewer, IEnumerable<XTransformerParser>>(v => v.XmlTransformations, null);
        public static readonly DependencyProperty ZoomFactorProperty = DependencyPropertyEx.Register<NoteViewer, double>(v => v.ZoomFactor, 1d, ZoomFactorChanged);
        private DraggingState _draggingState = new DraggingState();
        private WpfScoreRendererSettings rendererSettings = new WpfScoreRendererSettings();

        private Score _innerScore;

        private Color previousColor;

        public NoteViewer()
        {
            InitializeComponent();
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

        public bool IsAsync
        {
            get { return (bool)GetValue(IsAsyncProperty); }
            set { SetValue(IsAsyncProperty, value); }
        }

        public bool IsInsertMode
        {
            get { return (bool)GetValue(IsInsertModeProperty); }
            set { SetValue(IsInsertModeProperty, value); }
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

        protected WpfCanvasScoreRenderer Renderer { get; set; }

        public void LoadFont(FontFamily family, string metadata, double musicFontSize = 25, double graceNoteFontSize = 16, double staffFontSize = 30.5d)
        {
            rendererSettings.LoadSMuFLMetadata(metadata);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, family, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, family, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, family, staffFontSize);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, family);
        }

        public void LoadFontFromBinaryMetadataStream(FontFamily family, Stream metadataStream, double musicFontSize = 25, double graceNoteFontSize = 16, double staffFontSize = 30.5d)
        {
            rendererSettings.LoadSMuFLMetadataFromBinaryStream(metadataStream);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, family, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, family, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, family, staffFontSize);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, family);
        }

        public async Task LoadFontAsync(FontFamily family, string metadata, double musicFontSize = 25, double graceNoteFontSize = 16, double staffFontSize = 30.5d)
        {
            await rendererSettings.LoadSMuFLMetadataAsync(metadata);
            rendererSettings.SetFont(MusicFontStyles.MusicFont, family, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, family, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, family, staffFontSize);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, family);
        }

        public void LoadFont(FontFamily family, SMuFLFontMetadata metadata, double musicFontSize = 25, double graceNoteFontSize = 16, double staffFontSize = 30.5d)
        {
            rendererSettings.CurrentFont = new SMuFLMusicFont();
            rendererSettings.CurrentSMuFLMetadata = metadata;
            rendererSettings.SetFont(MusicFontStyles.MusicFont, family, musicFontSize);
            rendererSettings.SetFont(MusicFontStyles.GraceNoteFont, family, graceNoteFontSize);
            rendererSettings.SetFont(MusicFontStyles.StaffFont, family, staffFontSize);
            rendererSettings.SetFont(MusicFontStyles.TimeSignatureFont, family);
        }

        public void LoadDefaultFont() => rendererSettings.SetPolihymniaFont();

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
            var children = MainCanvas.Children.OfType<UIElement>();
            foreach (var child in children) child.Measure(availableSize);

            if (children.Any())
            {
                var xx = children.Max(c => Canvas.GetLeft(c) * ZoomFactor + c.DesiredSize.Width * ZoomFactor);
                var yy = children.Max(c => Canvas.GetTop(c) * ZoomFactor + c.DesiredSize.Height * ZoomFactor);
                return new Size(xx, yy);
            }
            return base.MeasureOverride(availableSize);
        }

        private static void CurrentPageChanged(NoteViewer control, int oldValue, int newValue)
        {
            control.RenderOnCanvas(control.InnerScore);
        }

        private static void PlaybackCursorPositionChanged(NoteViewer control, PlaybackCursorPosition oldValue, PlaybackCursorPosition newValue)
        {
            if (control.InnerScore == null) return;
            if (control.Renderer == null) return;

            if (!newValue.IsValid) return;

            control.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => control.Renderer.DrawPlaybackCursor(newValue)));
        }

        private static void RenderingModeChanged(NoteViewer control, ScoreRenderingModes oldValue, ScoreRenderingModes newValue)
        {
            if (control.InnerScore == null) return;
            control.RenderOnCanvas(control.InnerScore);
        }

        private static void ScoreSourceChanged(NoteViewer control, Score oldValue, Score newValue)
        {
            if (oldValue != null) oldValue.Safety.BoundControl = null;
            Score.SanityCheck(newValue, control);

            control.RenderOnCanvas(newValue);
        }

        private static void XmlSourceChanged(NoteViewer contol, string oldValue, string newValue)
        {
            XDocument xmlDocument = XDocument.Parse(newValue);
            //Apply transformations:
            if (contol.XmlTransformations != null)
            {
                foreach (var transformation in contol.XmlTransformations) xmlDocument = transformation.Parse(xmlDocument);
            }

            MusicXmlParser parser = new MusicXmlParser();
            var score = parser.Parse(xmlDocument);
            contol.RenderOnCanvas(score);
        }

        private static void ZoomFactorChanged(NoteViewer control, double oldValue, double newValue)
        {
            control.InvalidateMeasure();
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!IsSelectable) return;
            MainCanvas.CaptureMouse();  //Capture mouse to receive events even if the pointer is outside the control

            //Start dragging:
            _draggingState.StartDragging(WpfCanvasScoreRenderer.ConvertPoint(e.GetPosition(MainCanvas)));

            //Check if element under cursor is staff element:
            FrameworkElement element = e.OriginalSource as FrameworkElement;
            if (element == null) return;
            if (!Renderer.OwnershipDictionary.ContainsKey(element)) return;

            //Set selected element:
            Select(Renderer.OwnershipDictionary[element]);
        }

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

        private void MainCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
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
                strategy.Drag(Renderer, SelectedElement, _draggingState, WpfCanvasScoreRenderer.ConvertPoint(currentPosition));
            }

            if (InvalidatingMode == InvalidatingModes.RedrawAllScore) RenderOnCanvas(_innerScore);
        }

        private void RenderOnCanvas(Measure measure)
        {
            if (Renderer == null) Renderer = new WpfCanvasScoreRenderer(MainCanvas, rendererSettings);
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

            MainCanvas.Children.Clear();
            Renderer = IsAsync ? new DispatcherCanvasScoreRenderer(MainCanvas, this, rendererSettings) : new WpfCanvasScoreRenderer(MainCanvas, rendererSettings);
            Renderer.Settings.RenderingMode = RenderingMode;
            Renderer.Settings.CurrentPage = CurrentPage;
            var brush = Foreground as SolidColorBrush;
            if (brush != null) Renderer.Settings.DefaultColor = Renderer.ConvertColor(brush.Color);
            if (score.Staves.Count > 0) Renderer.Settings.PageWidth = score.Staves[0].Elements.Count * 26;

            if (IsAsync) await Renderer.RenderAsync(score);
            else Renderer.Render(score);

            if (IsAsync) ((DispatcherCanvasScoreRenderer)Renderer).FlushBuffer();
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