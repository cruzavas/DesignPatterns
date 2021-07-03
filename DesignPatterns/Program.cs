using DesignPatterns.DependencyInjection;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using System;
using System.Linq;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			//Singleton
			var log = Singleton.Log.Instance;
			log.Save("a");
			log.Save("b");

			//Factory Method
			SaleFactory storeSaleFactory = new StoreSaleFactory(10);
			SaleFactory internetSaleFactory = new InternetSaleFactory(2);

			ISale sale1 = storeSaleFactory.GetSale();
			sale1.Sell(15);

			ISale sale2 = internetSaleFactory.GetSale();
			sale2.Sell(15);

			//Dependency Injection
			var beerDI = new DependencyInjection.Beer("Negra", "Modelo");
			var drinkWithBeer = new DrinkWithBeer(10, 1, beerDI);
			drinkWithBeer.Build();

			//Repository
			//using(var context = new DesignPatternsContext())
			//{
			//	var lst = context.Beers.ToList();
			//	foreach (var item in lst)
			//	{
			//		Console.WriteLine(item.Name);
			//	}
			//}

			using (var context = new DesignPatternsContext())
			{
				var beerRepository = new BeerRepository(context);
				var beer = new Models.Beer();
				beer.Name = "Corona";
				beer.Style = "Pilsner";

				beerRepository.Add(beer);
				beerRepository.Save();

				foreach (var item in beerRepository.Get())
				{
					Console.WriteLine(item.Name);
				}
			}
		}
	}
}
