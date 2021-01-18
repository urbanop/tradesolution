using System.Collections.Generic;
using System.Linq;
using TradeSolution.Domain.Contracts;
using TradeSolution.Domain.Entities;
using TradeSolution.Infra.Data.Context;

namespace TradeSolution.Infra.Data.Repository
{
    public class CategoryRulesRepository : ICategoryRulesRepository
    {
        private ContextDb _contextDb { get; set; }

        public CategoryRulesRepository()
        {
            _contextDb = new ContextDb();
        }

        public IList<CategoryRule> GetCategoryRules()
        {
            return _contextDb.CategoryRules.ToList();
        }
    }
}
