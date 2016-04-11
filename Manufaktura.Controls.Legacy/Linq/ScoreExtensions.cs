using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Parser.Digest;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Linq
{
    public static class ScoreExtensions
    {
        /// <summary>
        /// Returns first symbol with specific MusicalSymbolType.
        /// </summary>
        /// <param name="musicalSymbols">Sequence to search</param>
        /// <param name="type">Type of musical symbol</param>
        /// <returns>Found element od default</returns>
        public static MusicalSymbol FirstOrDefault(this IEnumerable<MusicalSymbol> musicalSymbols, MusicalSymbolType type)
        {
            return musicalSymbols.FirstOrDefault(ms => ms.Type == type);
        }

        /// <summary>
        /// Returns enumerator of symbols with specific MusicalSymbolType.
        /// </summary>
        /// <param name="musicalSymbols">Sequence to search</param>
        /// <param name="type">Type of musical symbol</param>
        /// <returns>Enumerator of symbols with specific MusicalSymbolType</returns>
        public static IEnumerable<MusicalSymbol> OfType(this IEnumerable<MusicalSymbol> musicalSymbols, MusicalSymbolType type)
        {
            return musicalSymbols.Where(ms => ms.Type == type);
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

        public static int[] ToIntervals(this Score score)
        {
            MelodicContourDigestParser parser = new MelodicContourDigestParser();
            return parser.ParseBack(score);
        }

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

        public static Score ToScore(this string document, XTransformerParser transformer)
        {
            return ToScore(XDocument.Parse(document), transformer);
        }

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