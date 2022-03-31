using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortCardsApp.Controllers.Models
{
    public enum SpecialCard
    {
        _4T,
        _2T,
        ST,
        PT,
        RT,
    }

    public enum Suit
    {
        D,
        S,
        C,
        H
    }

    public enum Value
    {
        _2,
        _3,
        _4,
        _5,
        _6,
        _7,
        _8,
        _9,
        _10,
        J,
        Q,
        K,
        A
    }
    public class CardModel
    {
        public string CardName { get; set; }
        public string SuitName { get; set; }

        public string ValueName { get; set; }
        
        //SuitRank gives the priority based on Suit
        public int SuitRank { get; set; }

        //ValueRank gives the priority based on Value of the Card

        public int ValueRank { get; set; }

        //Indicates whether the given card is SpecialCard
        public bool IsSpecialCard { get; set; }

    }

}
