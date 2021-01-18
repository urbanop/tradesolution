using System;
using System.Collections.Generic;
using System.Linq;
using TradeSolution.Domain.Contracts;
using TradeSolution.Domain.Entities;

namespace TradeSolution.Application.Services.Trade
{
    public class TradeService : ITradeService
    {
        private readonly ICategoryRulesRepository _categoryRulesRepository;

        public TradeService(ICategoryRulesRepository categoryRulesRepository)
        {
            _categoryRulesRepository = categoryRulesRepository;
        }

        public List<string> GetTradeCategories(List<ITrade> trades)
        {
            List<string> tradeCategories = new List<string>();

            try
            {
                if (trades?.Count > 0)
                {
                    List<CategoryRule> categoryRules = _categoryRulesRepository.GetCategoryRules().ToList();

                    foreach (var item in trades)
                    {
                        tradeCategories.Add(
                        categoryRules.Where(o => o.ClientSector == item.ClientSector
                        && o.MinValue < item.Value
                        && o.MaxValue > item.Value)
                        .Select(n => n.Name).FirstOrDefault());
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return tradeCategories;
        }
    }
}
