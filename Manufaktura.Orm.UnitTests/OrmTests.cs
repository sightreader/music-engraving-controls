using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manufaktura.Orm.Builder;
using Manufaktura.Orm.UnitTests.Model;
using System.Diagnostics;
using Manufaktura.Orm.Predicates;
using System.IO;
using Manufaktura.Orm.SpecialColumns;
using Manufaktura.Controls.Rendering.Implementations;
using Manufaktura.Controls.Model;
using System.Collections.Generic;
using Manufaktura.Controls.Parser;
using System.Xml.Linq;
using Manufaktura.Orm;
using Manufaktura.Controls.Model.Fonts;

namespace Manufaktura.UnitTests
{
    [TestClass]
    public class OrmTests
    {

        [TestMethod]
        public void TestMySqlSelect()
        {
            using (var repository = new DbRepository(new MySqlDialectProvider("Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;")))
            {
                var melodies = repository.LoadAll<Melody>();
                foreach (var melody in melodies)
                {
                    Console.WriteLine(string.Format("{0} {1}", melody.Id, melody.Lyrics));
                }
                Debug.Assert(melodies != null);
                melodies = repository.Load<Melody>(QueryBuilder.Create().SetWindow(0, 10).SetWhereStatement(
                    QB.Or(QB.Like("Lyrics", "%dziwce%"), QB.Like("Lyrics", "%kurwie%"))));
                Debug.Assert(melodies != null);
            }
        }

        [TestMethod]
        public void TestMySqlUpdateSchema()
        {
            using (var repository = new DbRepository(new MySqlDialectProvider("Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;")))
            {
                repository.UpdateSchema(new Provenance());
                repository.UpdateSchema(new ProvenanceToPage());
            }
        }

        [TestMethod]
        public void TestCreateProvider()
        {
            using (var repository = new DbRepository("Manufaktura.Orm.Builder.MySqlDialectProvider", "Manufaktura.Orm.MySql.dll", "Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;"))
            {
                var melodies = repository.LoadAll<Melody>();
            }
        }

        [TestMethod]
        public void TestSpecifyColumns()
        {
            using (var repository = new DbRepository("Manufaktura.Orm.Builder.MySqlDialectProvider", "Manufaktura.Orm.MySql.dll", "Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;"))
            {
                long count = repository.ExecuteScalar<Melody, long>(QueryBuilder.Create().SpecifyColumns(null).AddSpecialColumn(new CountSpecialColumn("Id", "MelodyCount")));

            }
        }

        [TestMethod]
        public void TestMySqlInsert()
        {
            return;
            using (var repository = new DbRepository(new MySqlDialectProvider("Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;")))
            {
                string path = @"D:\Dokumenty\Manufaktura programów\Dane do bazy\2014-10-10 DWOK tom 1, s. 117 nr 2,3, 6-8";
                foreach (var fileName in Directory.GetFiles(path))
                {
                    string xml = File.ReadAllText(fileName);
                    Melody melody = new Melody();
                    melody.Xml = xml;
                    repository.Save(melody);
                }
            }
        }

        [TestMethod]
        public void TestRenderHtml()
        {
            Dictionary<MusicFontStyles, HtmlFontInfo> fonts = new Dictionary<MusicFontStyles, HtmlFontInfo>();
            fonts.Add(MusicFontStyles.MusicFont, new HtmlFontInfo("Polihymnia", 24d, "../fonts/Polihymnia.ttf"));
            fonts.Add(MusicFontStyles.GraceNoteFont, new HtmlFontInfo("Polihymnia", 12d,"../fonts/Polihymnia.ttf"));
            fonts.Add(MusicFontStyles.LyricsFont, new HtmlFontInfo("Open Sans", 10d, "../fonts/OpenSans-Regular.ttf"));
            fonts.Add(MusicFontStyles.TimeSignatureFont, new HtmlFontInfo("Open Sans", 14d,"../fonts/OpenSans-Regular.ttf"));
            fonts.Add(MusicFontStyles.DirectionFont, new HtmlFontInfo("Open Sans", 10d, "../fonts/OpenSans-Regular.ttf"));

            using (var repository = new DbRepository(new MySqlDialectProvider("Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;")))
            {
                var melodies = repository.Load<Melody>(QueryBuilder.Create().SetWindow(0, 10));
                var scores = new List<Score>();
                foreach (var melody in melodies)
                {
                    MusicXmlParser parser = new MusicXmlParser();
                    scores.Add(parser.Parse(XDocument.Parse(melody.Xml)));
                }
                //Score2HtmlCanvasBuilder builder = new Score2HtmlCanvasBuilder(scores, fonts, "scoreCanvas");
                //string html = builder.Build();
                //Console.WriteLine(html);
            }

        }
    }
}
