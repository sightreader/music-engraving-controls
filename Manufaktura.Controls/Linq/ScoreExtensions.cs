using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Parser.Digest;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Linq
{
    /// <summary>
    /// Extensions methods for operations on Scores
    /// </summary>
	public static class ScoreExtensions
	{
		/// <summary>
		/// Returns the largest denominator (pulse) of note collection
		/// </summary>
		/// <param name="noteOrRests"></param>
		/// <returns></returns>
		public static double Pulse(this IEnumerable<NoteOrRest> noteOrRests)
		{
			return noteOrRests.Max(n => n.BaseDuration.Denominator);
		}

		/// <summary>
		/// Creates a Score from stream.
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static Score ReadMusicXmlScoreToEnd(this StreamReader reader)
		{
			return ToScore(reader.ReadToEnd());
		}

        /// <summary>
        /// Returns interval array obtained from MelodicContourDigestParser
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
		public static int[] ToIntervals(this Score score)
		{
			MelodicContourDigestParser parser = new MelodicContourDigestParser();
			return parser.ParseBack(score);
		}

        /// <summary>
        /// Returns lyrics digest obtained by LyricsDigestParser
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
		public static string ToLyricsDigest(this Score score)
		{
			LyricsDigestParser parser = new LyricsDigestParser();
			return parser.ParseBack(score);
		}

		/// <summary>
		/// Calculates rhythmic digest of specified score.
		/// </summary>
		/// <param name="score"></param>
		/// <returns></returns>
		public static string ToRhythmDigest(this Score score)
		{
			RhythmDigestParser parser = new RhythmDigestParser();
			return parser.ParseBack(score);
		}

        /// <summary>
        /// Returns rhythm digest obtained with RhythmDigestParser
        /// </summary>
        /// <param name="score"></param>
        /// <param name="markRests"></param>
        /// <param name="includeBarlines"></param>
        /// <returns></returns>
		public static string ToRhythmDigest(this Score score, bool markRests, bool includeBarlines)
		{
			RhythmDigestParser parser = new RhythmDigestParser { MarkRests = markRests, IncludeBarlines = includeBarlines };
			return parser.ParseBack(score);
		}

		/// <summary>
		/// Converts MusicXml string to Score.
		/// </summary>
		/// <param name="document">MuicXml document as string</param>
		/// <returns>Score</returns>
		public static Score ToScore(this string document)
		{
			return ToScore(XDocument.Parse(document));
		}

        /// <summary>
        /// Converts MusicXML string to Score
        /// </summary>
        /// <param name="document"></param>
        /// <param name="transformer"></param>
        /// <returns></returns>
		public static Score ToScore(this string document, XTransformerParser transformer)
		{
			return ToScore(XDocument.Parse(document), transformer);
		}

        /// <summary>
        /// Converts MusicXml XDocument to Score
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
		public static Score ToScore(this XDocument document)
		{
			return ToScore(document, null);
		}

		/// <summary>
		/// Reads a score from MusicXml document with specific XTransformerParser.
		/// </summary>
		/// <param name="document"></param>
		/// <param name="transformer"></param>
		/// <returns></returns>
		public static Score ToScore(this XDocument document, XTransformerParser transformer)
		{
			MusicXmlParser parser = new MusicXmlParser();
			if (transformer != null)
			{
				document = transformer.Parse(document);
			}
			return parser.Parse(document);
		}
	}
}