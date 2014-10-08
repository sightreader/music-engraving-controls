using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manufaktura.Orm.Builder;
using Manufaktura.Orm.UnitTests.Model;
using System.Diagnostics;
using Manufaktura.Orm.Predicates;

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
                new OrPredicate(new LikePredicate("Lyrics", "%dziwce%"), new LikePredicate("Lyrics", "%kurwie%"))));
        }
    }
}
