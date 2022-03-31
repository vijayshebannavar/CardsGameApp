using Moq;
using NUnit.Framework;
using SortCardsApp.Controllers;
using SortCardsApp.Controllers.Models;
using SortCardsApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace SortsGameApp.Test
{
    [TestFixture]
    public class Tests
    {
        private List<CardModel> cardList = new List<CardModel>();
        private List<string> inputCardList = new List<string>();
        Mock<IDataFetcher> dataFetcherMock = new Mock<IDataFetcher>();

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
        public void SortDataMethodShouldReturnSortedCards()
        {
            dataFetcherMock
                .Setup(dataFetch => dataFetch.GetCardDetails(inputCardList))
                .Returns(new List<CardModel>{ new CardModel { CardName = "AD", SuitRank = 2, ValueRank = 14, IsSpecialCard = false }, 
                                                new CardModel { CardName = "KH", SuitRank = 5, ValueRank = 13, IsSpecialCard = false },
                                                new CardModel { CardName = "8C", SuitRank = 4, ValueRank = 8, IsSpecialCard = false },
                                                new CardModel { CardName = "4T", SuitRank = 1, ValueRank = 1, IsSpecialCard = true },
                                                new CardModel { CardName = "6S", SuitRank = 3, ValueRank = 6, IsSpecialCard = false }});


            CardsController cardsController = new CardsController(dataFetcherMock.Object);
            var resultObject = cardsController.SortData(inputCardList).ToList();
            Assert.AreEqual(5, resultObject.Count);
            Assert.AreEqual("4T", resultObject[0]);
            Assert.AreEqual("AD", resultObject[1]);
            Assert.AreEqual("6S", resultObject[2]);
            Assert.AreEqual("8C", resultObject[3]);
            Assert.AreEqual("KH", resultObject[4]);

        }
    }
}