using System;
using System.Collections.Generic;
using TradeSolution.Domain.Contracts;
using TradeSolution.Domain.Entities;

namespace TradeSolution.Infra.Data.Repository
{
    public sealed class CategoryRulesRepositoryInMemory : ICategoryRulesRepository
    {
        public IList<CategoryRule> GetCategoryRules()
        {
            return new List<CategoryRule> {
                new CategoryRule{ Id=1, Name= "LOWRISK", ClientSector = "Public", MinValue=0, MaxValue=1000000 },
                new CategoryRule{ Id=2, Name= "MEDIUMRISK", ClientSector = "Public", MinValue=1000000, MaxValue=Double.MaxValue },
                new CategoryRule{ Id=3, Name = "HIGHRISK", ClientSector = "Private", MinValue = 1000000, MaxValue = Double.MaxValue } };
            ;
        }
    }
}
