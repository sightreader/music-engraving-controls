using Manufaktura.Controls.Audio;
using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Music.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufaktura.Controls.Rendering.Implementations
{
    /// <summary>
    /// Score renderer that renders scores to HTML
    /// </summary>
    /// <typeparam name="TCanvas"></typeparam>
	public abstract class HtmlScoreRenderer<TCanvas> : ScoreRenderer<TCanvas>
	{
		protected TimelineElement<IHasDuration>[] currentPlaybackTimeline;

		protected HtmlScoreRenderer(TCanvas canvas)
			: base(canvas)
		{
		}

		public double ActualHeight { get; protected set; } = 0;
        public double ActualWidth { get; protected set; } = 0;

        public string ScoreElementName { get; set; }

        /// <summary>
        /// Settings cast to HtmlScoreRendererSettings
        /// </summary>
		public HtmlScoreRendererSettings TypedSettings { get { return Settings as HtmlScoreRendererSettings; } }

		protected override void BeforeRenderScore(Score score)
		{
			base.BeforeRenderScore(score);
			currentPlaybackTimeline = new VirtualScorePlayer(score, new Tempo(RhythmicDuration.Quarter, TypedSettings.PlaybackTempo)).CreateTimeline();
		}

        /// <summary>
        /// Creates DOM id for a specific MusicalSymbol
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
		protected string BuildElementId(MusicalSymbol element)
		{
			var sb = new StringBuilder();
			sb.Append($"scoreElement_{element.LongId}");
			return sb.ToString();
		}

        /// <summary>
        /// Builds playback information for JS based MIDI players for a specific MusicalSymbol 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
		protected Dictionary<string, string> BuildPlaybackAttributes(MusicalSymbol element)
		{
			var dict = new Dictionary<string, string>();

			var durationElement = element as IHasDuration;
			if (durationElement != null)
			{
				var timelineElement = currentPlaybackTimeline.FirstOrDefault(p => p.What == durationElement);
				if (timelineElement != null)
				{
					var duration = new RhythmicDuration(durationElement.BaseDuration.Denominator, durationElement.NumberOfDots).ToTimeSpan(new Tempo(RhythmicDuration.Quarter, TypedSettings.PlaybackTempo));
					dict.Add("data-playback-start", ((long)timelineElement.When.TotalMilliseconds).ToString());
					dict.Add("data-playback-duration", ((long)duration.TotalMilliseconds).ToString());
				}
			}

			var midiPitchElement = element as IHasPitch;
			if (midiPitchElement != null)
			{
				dict.Add("data-midi-pitch", midiPitchElement.Pitch.MidiPitch.ToString());
			}

			return dict;
		}

		protected Primitives.Point TranslateTextLocation(Primitives.Point location, MusicFontStyles fontStyle)
		{
			double locationX = location.X + 3d + TypedSettings.MusicalFontShiftX;
			double locationY;
			switch (fontStyle)
			{
				case MusicFontStyles.MusicFont:
                    locationY = location.Y + 25d + TypedSettings.MusicalFontShiftY;
					break;

                case MusicFontStyles.StaffFont:
                    locationY = location.Y + 27d + TypedSettings.MusicalFontShiftY;
                    break;

                case MusicFontStyles.GraceNoteFont:
					locationY = location.Y + 17.5d + TypedSettings.MusicalFontShiftY;
					locationX += 0.7d;
					break;

				default:
					locationY = location.Y + 14d + TypedSettings.MusicalFontShiftY;
					break;
			}
			return new Primitives.Point(locationX, locationY);
		}
	}
}