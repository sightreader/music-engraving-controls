using Manufaktura.VisualTests.Configurators;
using Manufaktura.VisualTests.Providers;
using Manufaktura.VisualTests.Renderers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Manufaktura.VisualTests
{
    /// <summary>
    /// How to use visual tests:
    /// 1. Create a testPath folder.
    /// 2. Create Scores folder in a testPath folder if you use FileTestScoreProvider. Put MusicXmls in it.
    /// 3. Run test.
    /// 4. Add call to AcceptTo with date slighty after the test.
    /// 5. Run test again to generate unaccepted test. If unaccapted test exists each run will generate differences between the first unaccepted test.
    /// </summary>
    [TestClass]
    public class Tests
    {
        private DateTime lastAcceptedTestDateTime;
        private List<DateTime> testHistory = new List<DateTime>();

        static Tests ()
        {
            UriParser.Register(new GenericUriParser(GenericUriParserOptions.GenericAuthority), "pack", -1);
        }

        [TestMethod]
        public void PerformVisualTests()
        {
            var testPath = @"D:\Dokumenty\Manufaktura programów\VisualTests";

            AcceptTo(DateTime.MinValue);
            AcceptTo(new DateTime(2016, 12, 29, 22, 45, 00));   //Bug związany z rysowaniem łuków
            AcceptTo(new DateTime(2016, 12, 30, 19, 35, 00));   //Regresja - niewłaściwe parsowanie wielu sylab na jednej nucie
            AcceptTo(new DateTime(2016, 12, 30, 20, 31, 00));   //Fermaty, podwójne kreski taktowe. Test uratował przed regresją - nieotwieranie kolejnego taktu po podwójnej kresce.
            AcceptTo(new DateTime(2016, 12, 30, 21, 01, 00));   //Przekreślone przednutki
            AcceptTo(new DateTime(2017, 1, 2, 9, 35, 00));      //Nowe nuty w bibliotece. Chcę poprawić błąd z rysowaniem łuków gdy nuty mają przeciwne ogonki
            AcceptTo(new DateTime(2017, 1, 2, 10, 31, 00));     //Poprawka łuków
            AcceptTo(new DateTime(2017, 1, 17, 19, 52, 00));    //Problem z beamami w akordach
            AcceptTo(new DateTime(2017, 1, 18, 23, 08, 00));    //default-x liczony do stema, a nie noteheada
            AcceptTo(new DateTime(2017, 1, 18, 23, 13, 00));    //poprawa slurów po ostatnim teście
            AcceptTo(new DateTime(2017, 1, 21, 16, 50, 00));    //Duża poprawka rysowania slurów
            AcceptTo(new DateTime(2017, 1, 21, 17, 07, 00));    //Kreski taktowe przerywane i ukryte
            AcceptTo(new DateTime(2017, 1, 22, 11, 50, 00));    //Obsługa wielu slurów, poprawki fakapów ze slurami w niektórych plikach
            AcceptTo(new DateTime(2017, 1, 22, 14, 27, 00));    //Poprawka algorytmu omijania nut przez slury (uwzględnia teraz także główki)
            AcceptTo(new DateTime(2017, 1, 22, 15, 14, 00));    //Położenie mordentów
            AcceptTo(new DateTime(2017, 1, 25, 23, 11, 00));    //Położenie pauz (regresja po "default-x liczony do stema, a nie noteheada")
            AcceptTo(new DateTime(2017, 1, 31, 21, 45, 00));    //Nuty rysowane w niewłaściwym miejscu (w rezultacie "krzaki") w partii liczącej więcej niż jeden staff
            AcceptTo(new DateTime(2017, 2, 1, 19, 12, 00));     //Złe położenie drugiej pięciolini w dwupięcioliniowych partach w trybie AllPages
            AcceptTo(new DateTime(2017, 2, 1, 20, 07, 00));     //Issue #71: Niedodawanie barline'a do drugiej pięciolinii w parcie
            AcceptTo(new DateTime(2017, 5, 14, 15, 02, 00));    //Klucze perkusyjne i obsługa nut bez picza
            AcceptTo(new DateTime(2017, 12, 03, 11, 24, 00));   //Obsługa atrybutu size na elemencie type (cue notes)
            AcceptTo(new DateTime(2018, 2, 18, 19, 25, 00));    //Zmiany w celu uzyskania kompatybilności z CSHTML5
            AcceptTo(new DateTime(2018, 3, 5, 21, 15, 00));     //Poprawki rozmieszczenia nut w akordach dla Ricardo Garcii
            AcceptTo(new DateTime(2018, 4, 11, 21, 17, 00));    //Duża zmiana obsługi współrzędnych rysowanych znaków, obsługa fontów SMuFL
            AcceptTo(new DateTime(2018, 4, 18, 20, 29, 00));    //Wiele poprawek regresji i nowych funkcjonalności
            AcceptTo(new DateTime(2018, 4, 20, 13, 12, 00));    //Poprawka regresji związanej ze zmianą tonacji, klucza lub metrum na końcu systemu
            AcceptTo(new DateTime(2018, 4, 24, 21, 00, 00));    //Poprawka powyższej poprawki dot. zmiany tonacji
            AcceptTo(new DateTime(2018, 4, 25, 19, 22, 00));    //Duży lifting triol
            AcceptTo(new DateTime(2018, 7, 22, 22, 05, 00));    //Problems with refreshing measures in manual note entering mode
            AcceptTo(new DateTime(2019, 1, 04, 10, 16, 00));    //Stem length fix

            var tests = CreatePathDictionary(testPath);
            var firstNotAcceptedTest = tests.Any(d => d.Key > lastAcceptedTestDateTime) ? tests.FirstOrDefault(d => d.Key > lastAcceptedTestDateTime).Value : null;

            var renderDate = DateTime.Now;
            var outputPath = Path.Combine(testPath, $"Test_{renderDate.ToString("yyyyMMddHHmmss")}");
            new WpfTestRenderer(new FileTestScoreProvider(testPath), new DefaultFontConfigurator()).GenerateImages(firstNotAcceptedTest, outputPath);
        }

        [TestMethod]
        public void PerformVisualTests_Bravura()
        {
            var testPath = @"D:\Dokumenty\Manufaktura programów\VisualTests_Bravura";

            AcceptTo(DateTime.MinValue);
            AcceptTo(new DateTime(2019, 01, 03, 16, 06, 00));   //Initial stem length fix for flags
            AcceptTo(new DateTime(2019, 01, 03, 17, 11, 00));   //Grace note stem fix
            AcceptTo(new DateTime(2019, 01, 04, 10, 11, 00));   //Collision-free beams
            AcceptTo(new DateTime(2019, 01, 06, 21, 05, 00));   //Centering of time signatures

            var tests = CreatePathDictionary(testPath);
            var firstNotAcceptedTest = tests.Any(d => d.Key > lastAcceptedTestDateTime) ? tests.FirstOrDefault(d => d.Key > lastAcceptedTestDateTime).Value : null;

            var renderDate = DateTime.Now;
            var outputPath = Path.Combine(testPath, $"Test_{renderDate.ToString("yyyyMMddHHmmss")}");
            var fontConfigurator = new BravuraFontConfigurator();
            new WpfTestRenderer(new FileTestScoreProvider(testPath), fontConfigurator).GenerateImages(firstNotAcceptedTest, outputPath);
            new WpfTestRenderer(new PlaineAndEasieTestScoreProvider(), fontConfigurator).GenerateImages(firstNotAcceptedTest, outputPath);
        }

        private static Dictionary<DateTime, string> CreatePathDictionary(string testPath)
        {
            var dict = new Dictionary<DateTime, string>();
            foreach (var directory in Directory.EnumerateDirectories(testPath, "Test*"))
            {
                var unparsedDate = Path.GetFileName(directory).Replace("Test_", "");
                DateTime dt;
                if (DateTime.TryParseExact(unparsedDate, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out dt))
                    dict.Add(dt, directory);
            }
            return dict.OrderBy(d => d.Key).ToDictionary(d => d.Key, d => d.Value);
        }

        private void AcceptTo(DateTime testTime)
        {
            lastAcceptedTestDateTime = testTime;
            testHistory.Add(testTime);
        }
    }
}