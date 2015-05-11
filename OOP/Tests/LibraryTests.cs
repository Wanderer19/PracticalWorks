using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OOP.LibraryUtils;

namespace OOP.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void SetUp()
        {
            library = new Library();
        }

        [Test]
        public void TestEmptyLibrary()
        {
            Assert.That(library.GetMagazinesWithName("VOGUE"), Is.Empty);
            Assert.That(library.GetMagazinesWithYear(2015), Is.Empty);
            Assert.That(library.GetMagazine(2015, 1, "VOGUE"), Is.Null);
        }


        [Test]
        public void TestFullLibrary()
        {
            var magazine1 = new Magazine("VOGUE", new DateTime(2015, 1, 1));
            magazine1.AddArticle(new Article("title1", "text1", "a1"));
            magazine1.AddArticle(new Article("title2", "text2", "a2"));
            magazine1.AddArticle(new Article("title3", "text3", "a1"));
            magazine1.AddArticle(new Article("title4", "text4", "a2"));


            var magazine2 = new Magazine("VOGUE", new DateTime(2015, 2, 1));
            magazine2.AddArticle(new Article("title1", "text1", "a1"));


            var magazine3 = new Magazine("Nylon", new DateTime(2014, 2, 1));
            magazine3.AddArticle(new Article("title1", "text1", "a1"));


            library.AddMagazine(magazine1);
            library.AddMagazine(magazine2);
            library.AddMagazine(magazine3);

            Assert.That(library.GetMagazine(2015, 1, "VOGUE").MyEquals(magazine1), Is.True);
            Assert.That(library.GetMagazine(2015, 2, "VOGUE").MyEquals(magazine2), Is.True);
            Assert.That(library.GetMagazine(2014, 2, "Nylon").MyEquals(magazine3), Is.True);
            Assert.That(library.GetMagazine(2015, 3, "VOGUE"), Is.Null);

            Assert.That(MagazinesEquals(library.GetMagazinesWithName("VOGUE").ToList(), new List<Magazine>(){magazine1, magazine2}), Is.True);
            Assert.That(MagazinesEquals(library.GetMagazinesWithYear(2014).ToList(), new List<Magazine>(){magazine3}), Is.True);
        }

        private static bool MagazinesEquals(List<Magazine> first, List<Magazine> second)
        {
            if (first.Count() != second.Count())
            {
                return false;
            }

            for (var i = 0; i < first.Count(); ++i)
            {
                if (!first[i].MyEquals(second[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
