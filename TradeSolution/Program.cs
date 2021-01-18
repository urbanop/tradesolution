using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using TradeSolution.Application.Factory;
using TradeSolution.Application.Services.Trade;
using TradeSolution.Domain.Contracts;
using TradeSolution.Infra.Data.Repository;

namespace TradeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            ITradeService tradeService = host.Services.GetRequiredService<ITradeService>();
            
            List<ITrade> portifolio = TradeFactory.BuildPortifolio();
            List<string> tradeCategories = tradeService.GetTradeCategories(portifolio);

            Console.WriteLine("tradeCategories = {0}", string.Join(", ", tradeCategories));
        }

       static IHostBuilder CreateHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args)
           .ConfigureServices((_, services) =>
               services.AddTransient<ITradeService, TradeService>()
                       .AddScoped<ICategoryRulesRepository, CategoryRulesRepositoryInMemory>());

    }
}
