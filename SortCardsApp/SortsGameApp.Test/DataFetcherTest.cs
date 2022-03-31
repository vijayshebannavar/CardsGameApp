using NUnit.Framework;
using SortCardsApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortsGameApp.Test
{
    [TestFixture]
    public class DataFetcherTest
    {
        private List<string> inputCardList = new List<string>();

        [SetUp]
        public void Setup()
        {
            inputCardList.Add("AD");
            inputCardList.Add("KH");
            inputCardList.Add("8C");
            inputCardList.Add("4T");
            inputCardList.Add("6S");
        }

        [Test]
        public void GetCardMethodShouldReturnSortedCards()
        {
            IDataFetcher dataFetch = new DataFetcher();
            var result = dataFetch.GetCardDetails(inputCardList);
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(2, result[0].SuitRank);
            Assert.AreEqual(14, result[0].ValueRank);
            Assert.AreEqual(12, result[1].ValueRank);
        }
    }
}
