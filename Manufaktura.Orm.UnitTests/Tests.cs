using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manufaktura.Orm.Builder;
using Manufaktura.Orm.UnitTests.Model;
using System.Diagnostics;
using Manufaktura.Orm.Predicates;
using System.IO;

namespace Manufaktura.Orm.UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMySqlSelect()
        {
            DbRepository repository = new DbRepository(new MySqlDialectProvider("Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;"));
            var melodies = repository.LoadAll<Melody>();
            foreach (var melody in melodies)
            {
                Console.WriteLine(string.Format("{0} {1}", melody.Id, melody.Lyrics));
            }
            Debug.Assert(melodies != null);
            melodies = repository.Load<Melody>(QueryBuilder.Create().SetWindow(0, 10).SetWhereStatement(
                QB.Or(QB.Like("Lyrics", "%dziwce%"), QB.Like("Lyrics", "%kurwie%"))));
        }

        [TestMethod]
        public void TestCreateProvider()
        {
            DbRepository repository = new DbRepository("Manufaktura.Orm.Builder.MySqlDialectProvider", "Manufaktura.Orm.MySql.dll", "Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;");
            var melodies = repository.LoadAll<Melody>();
        }

        [TestMethod]
        public void TestMySqlInsert()
        {
            DbRepository repository = new DbRepository(new MySqlDialectProvider("Server=localhost;Database=kolberg-test;Uid=admin;Pwd=123123;"));
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
}
