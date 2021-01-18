using System.Data.Entity;
using TradeSolution.Domain.Entities;

namespace TradeSolution.Infra.Data.Context
{
    public class ContextDb : DbContext
    {
       public DbSet<Trade> Trades { get; set; }
       public DbSet<CategoryRule> CategoryRules { get; set; }

        public ContextDb()
        {
           //To do: Implementar conexão com a base de dados
        }

    }
}
