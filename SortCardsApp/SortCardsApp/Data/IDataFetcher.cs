using SortCardsApp.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortCardsApp.Data
{
    public interface IDataFetcher
    {
        List<CardModel> GetCardDetails(List<string> inputValues);
    }
}
