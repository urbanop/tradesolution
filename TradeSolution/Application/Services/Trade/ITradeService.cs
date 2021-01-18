using System.Collections.Generic;
using TradeSolution.Domain.Contracts;

namespace TradeSolution.Application.Services.Trade
{
    public interface ITradeService
    {
        List<string> GetTradeCategories(List<ITrade> trades);
    }
}
