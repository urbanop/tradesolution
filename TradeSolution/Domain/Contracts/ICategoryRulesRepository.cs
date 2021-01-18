using System.Collections.Generic;
using TradeSolution.Domain.Entities;

namespace TradeSolution.Domain.Contracts
{
    public interface ICategoryRulesRepository
    {
        IList<CategoryRule> GetCategoryRules();
    }
}
