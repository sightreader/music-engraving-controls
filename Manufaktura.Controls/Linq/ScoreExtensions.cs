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
        public static MusicalSymbol FirstOrDefault(this IEnumerable<MusicalSymbol> musicalSymbols, MusicalSymbolType type)
        {
            return musicalSymbols.FirstOrDefault(ms => ms.Type == type);
        }

        public static IEnumerable<MusicalSymbol> OfType(this IEnumerable<MusicalSymbol> musicalSymbols, MusicalSymbolType type)
        {
            return musicalSymbols.Where(ms => ms.Type == type);
        }

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