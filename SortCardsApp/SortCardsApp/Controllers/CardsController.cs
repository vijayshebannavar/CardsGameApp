using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SortCardsApp.Controllers.Models;
using SortCardsApp.Data;

namespace SortCardsApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardsController : Controller
    {
        private IDataFetcher dataFetcher = null;
        public CardsController(IDataFetcher _dataFetcher)
        {
            dataFetcher = _dataFetcher;
            
        }
        // GET: CardsController
        [HttpPost]
        public IEnumerable<string> SortData([FromBody] List<string> listofInputs)
        {
            try
            {
                //Get the Card Details from DataFetcher Class
                List<CardModel> listOfCards = dataFetcher.GetCardDetails(listofInputs);
                //Sorts the Input Cards based on the Suit Rank and Its Value Rank
                var sortedList = GetSortedList(listOfCards);
                return sortedList;
            }
            catch(Exception ex)
            {
                //Handle Exception Logger

            }
            return new List<string>();
        }

        private List<string> GetSortedList(List<CardModel> listOfCards)
        {
            Comparer cardsComparer = new Comparer();
            listOfCards.Sort(cardsComparer);
            return listOfCards.Select(x => x.CardName).ToList();
        }
    }
}
