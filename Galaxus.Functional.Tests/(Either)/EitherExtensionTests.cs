using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Galaxus.Functional.Tests
{
    [TestFixture]
    public class EitherExtensionTests
    {
        [Test]
        public void SelectASelectBAreEvaluatedCorrectly()
        {
            var eithers = new List<Either<string, int>>
            {
                new Either<string, int>(1),
                new Either<string, int>("Hello"),
                new Either<string, int>(2),
                new Either<string, int>("World")
            };

            var aEntries = eithers.SelectA().ToList();
            var bEntries = eithers.SelectB().ToList();
            
            CollectionAssert.AreEqual(new List<string> { "Hello", "World" }, aEntries);
            CollectionAssert.AreEqual(new List<int> { 1, 2 }, bEntries);
        }

        [Test]
        public void SelectASelectBSelectCAreEvaluatedCorrectly()
        {
            var eithers = new List<Either<string, int, bool>>
            {
                new Either<string, int, bool>(1),
                new Either<string, int, bool>("Hello"),
                new Either<string, int, bool>(true),
                new Either<string, int, bool>(2),
                new Either<string, int, bool>("World")
            };

            var aEntries = eithers.SelectA().ToList();
            var bEntries = eithers.SelectB().ToList();
            var cEntries = eithers.SelectC().ToList();
            
            CollectionAssert.AreEqual(new List<string> { "Hello", "World" }, aEntries);
            CollectionAssert.AreEqual(new List<int> { 1, 2 }, bEntries);
            CollectionAssert.AreEqual(new List<bool> { true }, cEntries);
        }
    }
}
