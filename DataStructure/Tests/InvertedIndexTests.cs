﻿using System.Collections.Generic;
using DataStructure.DictionaryTasks.InvertedIndexUtils;
using NUnit.Framework;

namespace DataStructure.Tests
{
    [TestFixture]
    public class InvertedIndexTests
    {
        [TestCaseSource("GetInputs")]
        public void Test(Document[] documents, Dictionary<string, List<int>> expectedInvertedIndex)
        {
            Assert.That(InvertedIndexBuilder.BuildInvertedIndex(documents), Is.EqualTo(expectedInvertedIndex));
            Assert.That(InvertedIndexBuilder.BuildInvertedIndexSecondVersion(documents), Is.EqualTo(expectedInvertedIndex));
        }

        private static IEnumerable<object[]> GetInputs()
        {
            yield return new object[] {new Document[0], new Dictionary<string, List<int>>()};
            yield return new object[]
            {
                new[]{new Document(1, "LOL"), }, 
                new Dictionary<string, List<int>>()
                {
                    {"lol", new List<int>(){1}}
                }
            };
            yield return new object[]
            {
                new[]{new Document(1, "lol Lol"), }, 
                new Dictionary<string, List<int>>()
                {
                    {"lol", new List<int>(){1}}
                }
            };

            yield return new object[]
            {
                new[]{new Document(1, "lol Lol"), new Document(2, "lol, lkfnk45jg lol2"),  new Document(3, "LOL !!!AHAHA Lol2") }, 
                new Dictionary<string, List<int>>()
                {
                    {"lol", new List<int>(){1, 2, 3}},
                    {"lol2", new List<int>(){2, 3}},
                    {"lkfnk45jg", new List<int>(){2}},
                    {"ahaha", new List<int>(){3}}
                }
            };
        } 
    }
}
