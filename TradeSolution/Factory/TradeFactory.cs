using System.Collections.Generic;
using TradeSolution.Domain.Contracts;

namespace TradeSolution.Factory
{
    public static class TradeFactory
    {
        public static List<ITrade> BuildPortifolio()
        {
            return new List<ITrade>
            {
                new Trade1(),
                new Trade2(),
                new Trade3(),
                new Trade4()
            };
        }
    }
}
