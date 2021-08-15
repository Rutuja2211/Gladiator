using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnderstandingEFSolution.Models
{
    public class SortLogic : IComparer<Order>
    {
        public int Compare(Order x, Order y)
        {
            return x.ShipCity.CompareTo(y.ShipCity);
        }
    }
}