using SortCardsApp.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortCardsApp.Data
{
    public class DataFetcher:IDataFetcher
    {     
        public List<CardModel> GetCardDetails(List<string> inputValues)
        {
            List<CardModel> listofCards = new List<CardModel>();
            try
            {
               
                foreach (string inputValue in inputValues)
                {
                    CardModel card = new CardModel();
                    card.CardName = inputValue;
                    if (inputValue.Contains("T"))
                    {
                        card.IsSpecialCard = true;
                    }
                    else
                    {
                        card.IsSpecialCard = false;
                    }

                    //Get the suit name
                    card.SuitName = inputValue.Substring(inputValue.Length - 1, 1);

                    //Get the Rank of Suit as per the priority
                    card.SuitRank = GetSuitRank(card.SuitName);

                    //Get the Value Name apart from SuitName
                    card.ValueName = inputValue.Substring(0, inputValue.Length - 1);

                    //Get the Value Rank from Value Name
                    card.ValueRank = GetValueRank(card.SuitName, card.ValueName);
                    listofCards.Add(card);

                }
            }
            catch(Exception ex)
            {
                throw;
            }

            return listofCards;
        }


        private int GetValueRank(string suitName, string valueName)
        {
            int valueRank = 0;
            if(suitName == "T")
            {
                switch (valueName)
                {
                    case "4":
                        valueRank = 1;
                        break;
                    case "2":
                        valueRank = 2;
                        break;
                    case "S":
                        valueRank = 3;
                        break;
                    case "P":
                        valueRank = 4;
                        break;
                    case "R":
                        valueRank = 5;
                        break;
                }
                return valueRank;
            }
            else
            {
                if(int.TryParse(valueName, out valueRank))
                {
                    return valueRank;
                }
                else
                {
                    switch (valueName)
                    {
                        case "J":
                            valueRank = 11;
                            break;
                        case "Q":
                            valueRank = 12;
                            break;
                        case "K":
                            valueRank = 13;
                            break;
                        case "A":
                            valueRank = 14;
                            break;
                    }
                    return valueRank;

                }
            }
        }

        private int GetSuitRank(string suitName)
        {
            int suitValue = 0;
            switch (suitName)
            {
                case "T":
                    suitValue = 1;
                    break;
                case "D":
                    suitValue = 2;
                    break;
                case "S":
                    suitValue = 3;
                    break;
                case "C":
                    suitValue = 4;
                    break;
                case "H":
                    suitValue = 5;
                    break;

            }

            return suitValue;
        }
    }
}
