﻿using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Rendering;
using Manufaktura.Controls.Xamarin.Shapes;
using System.Collections.Generic;
using Xamarin.Forms;
using X = Xamarin.Forms;
using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Primitives;
using System;

namespace Manufaktura.Controls.Xamarin
{
	public class AbsoluteLayoutScoreRenderer : ScoreRenderer<AbsoluteLayout>
	{
		public AbsoluteLayoutScoreRenderer(AbsoluteLayout canvas) : base(canvas)
		{
			OwnershipDictionary = new Dictionary<VisualElement, MusicalSymbol>();
		}

		public Dictionary<VisualElement, MusicalSymbol> OwnershipDictionary { get; private set; }

		public X.Color ConvertColor(Primitives.Color color)
		{
			return X.Color.FromRgba(color.R, color.G, color.B, color.A);
		}

		public Primitives.Color ConvertColor(X.Color color)
		{
			return new Primitives.Color((byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255), (byte)(color.A * 255));
		}

		public override void DrawArc(Primitives.Rectangle rect, double startAngle, double sweepAngle, Primitives.Pen pen, MusicalSymbol owner)
		{
			var arc = new Arc();
			arc.TranslationX = rect.X;
			arc.TranslationY = rect.Y;
			arc.RX = rect.Width;
			arc.RY = rect.Height;
			arc.Thickness = pen.Thickness;
			arc.Color = pen.Color;

			Canvas.Children.Add(arc);
			OwnershipDictionary.Add(arc, owner);
		}

		public override void DrawBezier(Primitives.Point p1, Primitives.Point p2, Primitives.Point p3, Primitives.Point p4, Primitives.Pen pen, MusicalSymbol owner)
		{
			var bezierCurve = new BezierCurve();
			bezierCurve.Thickness = pen.Thickness;
			bezierCurve.Color = pen.Color;
			bezierCurve.TranslationX = p1.X;
			bezierCurve.TranslationY = p1.Y;
			bezierCurve.X2 = p2.X;
			bezierCurve.Y2 = p2.Y;
			bezierCurve.X3 = p3.X;
			bezierCurve.Y3 = p3.Y;
			bezierCurve.X4 = p4.X;
			bezierCurve.Y4 = p4.Y;

			Canvas.Children.Add(bezierCurve);
			OwnershipDictionary.Add(bezierCurve, owner);
		}

		public override void DrawLine(Primitives.Point startPoint, Primitives.Point endPoint, Primitives.Pen pen, MusicalSymbol owner)
		{
			if (Settings.RenderingMode != ScoreRenderingModes.Panorama)
			{
				startPoint = startPoint.Translate(CurrentScore.DefaultPageSettings);
				endPoint = endPoint.Translate(CurrentScore.DefaultPageSettings);
			}

			var line = new Line();
			line.TranslationX = startPoint.X;
			line.TranslationY = startPoint.Y;
			line.EndX = endPoint.X;
			line.EndY = endPoint.Y;
			line.Color = pen.Color;
			line.Thickness = pen.Thickness;
			//var width = Math.Abs(line.EndX - line.TranslationX);
			//var height = Math.Abs(line.EndY - line.TranslationY);
			//if (width == 0) width = line.Thickness;
			//if (height == 0) height = line.Thickness;
			//AbsoluteLayout.SetLayoutBounds(line, new X.Rectangle(line.TranslationX, line.TranslationY, width, height));

			Canvas.Children.Add(line);
			OwnershipDictionary.Add(line, owner);
		}

		public override void DrawString(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Color color, MusicalSymbol owner)
		{
			if (Settings.RenderingMode != ScoreRenderingModes.Panorama) location = location.Translate(CurrentScore.DefaultPageSettings);

			var label = new Text();
			label.TranslationX = location.X;
			label.TranslationY = location.Y;
			label.Text = text;
			label.FontFamily = Fonts.Get(fontStyle).FontFamily;
			label.FontAttributes = Fonts.Get(fontStyle).Attributes;
			label.FontSize = Fonts.Get(fontStyle).FontSize;
			label.TextColor = X.Color.Black;

			Canvas.Children.Add(label);
			OwnershipDictionary.Add(label, owner);
		}

		public override void DrawStringInBounds(string text, MusicFontStyles fontStyle, Primitives.Point location, Primitives.Size size, Primitives.Color color, MusicalSymbol owner)
		{
		}

		protected override void DrawPlaybackCursor(PlaybackCursorPosition position, Primitives.Point start, Primitives.Point end)
		{
			throw new NotImplementedException();
		}
	}
}