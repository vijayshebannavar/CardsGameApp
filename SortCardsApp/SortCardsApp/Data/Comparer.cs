using SortCardsApp.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace SortCardsApp.Data
{
    public class Comparer : IComparer<CardModel>
    {
        public int Compare(CardModel x, CardModel y)
        {
            if (x.SuitRank > y.SuitRank)
            {
                return 1;
            }
            else if (x.SuitRank < y.SuitRank)
            {
                return -1;
            }
            else
            {

                if (x.ValueRank > y.ValueRank)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
