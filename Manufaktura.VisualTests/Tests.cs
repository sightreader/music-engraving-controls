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
    [TestClass]
    public class Tests
    {
        private const string testPath = @"D:\Dokumenty\Manufaktura programów\VisualTests";

        private DateTime lastAcceptedTestDateTime;
        private List<DateTime> testHistory = new List<DateTime>();

        [TestMethod]
        public void PerformVisualTests()
        {
            UriParser.Register(new GenericUriParser(GenericUriParserOptions.GenericAuthority), "pack", -1);

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

            var tests = CreatePathDictionary();
            var firstNotAcceptedTest = tests.Any(d => d.Key > lastAcceptedTestDateTime) ? tests.FirstOrDefault(d => d.Key > lastAcceptedTestDateTime).Value : null;

            var renderDate = DateTime.Now;
            var outputPath = Path.Combine(firstNotAcceptedTest, $"Test_{renderDate.ToString("yyyyMMddHHmmss")}");
            new WpfTestRenderer(new FileTestScoreProvider(testPath)).GenerateImages(firstNotAcceptedTest, outputPath);
        }

        private Dictionary<DateTime, string> CreatePathDictionary ()
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