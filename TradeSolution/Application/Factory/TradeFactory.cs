using System.Collections.Generic;
using TradeSolution.Domain.Contracts;
using TradeSolution.Domain.Entities;

namespace TradeSolution.Application.Factory
{
    public static class TradeFactory
    {
        public static List<ITrade> BuildPortifolio()
        {
            return new List<ITrade>
            {
                new Trade(2000000, "Private"),
                new Trade(400000, "Public"),
                new Trade(500000, "Public"),
                new Trade(3000000, "Public")
            };
        }
    }
}
