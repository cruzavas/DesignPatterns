using DesignPatterns.BuilderPattern;
using DesignPatterns.DependencyInjection;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;
using System;
using Beer = DesignPatterns.Models.Beer;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			////Singleton
			//var log = Singleton.Log.Instance;
			//log.Save("a");
			//log.Save("b");

			////Factory Method
			//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
			//SaleFactory internetSaleFactory = new InternetSaleFactory(2);

			//ISale sale1 = storeSaleFactory.GetSale();
			//sale1.Sell(15);

			//ISale sale2 = internetSaleFactory.GetSale();
			//sale2.Sell(15);

			////Dependency Injection
			//var beerDI = new DependencyInjection.Beer("Negra", "Modelo");
			//var drinkWithBeer = new DrinkWithBeer(10, 1, beerDI);
			//drinkWithBeer.Build();

			////Repository
			///*
			//using (var context = new DesignPatternsContext())
			//{
			//	var lst = context.Beers.ToList();
			//	foreach (var item in lst)
			//	{
			//		Console.WriteLine(item.Name);
			//	}
			//}

			//using (var context = new DesignPatternsContext())
			//{
			//	var beerRepository = new BeerRepository(context);
			//	var beer = new Models.Beer();
			//	beer.Name = "Corona";
			//	beer.Style = "Pilsner";

			//	beerRepository.Add(beer);
			//	beerRepository.Save();

			//	foreach (var item in beerRepository.Get())
			//	{
			//		Console.WriteLine(item.Name);
			//	}
			//}*/

			//using (var context = new DesignPatternsContext())
			//{
			//	var beerRepository = new Repository<Beer>(context);
			//	var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };

			//	beerRepository.Add(beer);
			//	beerRepository.Save();

			//	foreach (var item in beerRepository.Get())
			//	{
			//		Console.WriteLine($"{item.BeerId} {item.Name}");
			//	}

			//	var brandRepository = new Repository<Brand>(context);
			//	var brand = new Brand();
			//	brand.Name = "Fuller";
			//	brandRepository.Add(brand);
			//	brandRepository.Save();

			//	foreach (var item in brandRepository.Get())
			//	{
			//		Console.WriteLine(item.Name);
			//	}
			//}

			////Unit Of Work

			//using (var context = new DesignPatternsContext())
			//{
			//	var unitOfWork = new UnitOfWork(context);

			//	var beers = unitOfWork.Beers;
			//	var beer = new Beer() { Name = "Fuller", Style = "Porter" };
			//	beers.Add(beer);

			//	var brands = unitOfWork.Brands;
			//	var brand = new Brand()
			//	{
			//		Name = "Fuller"
			//	};
			//	brands.Add(brand);

			//	unitOfWork.Save();
			//}

			//Strategy Pattern
			//var context = new Context(new CarStrategy());
			//context.Run();
			//context.Strategy = new MotoStrategy();
			//context.Run();
			//context.Strategy = new BicycleStrategy();
			//context.Run();

			//Builder Pattern
			//var builder = new PreparedAlcoholicDrinkConcreteBuilder();
			//var barmanDirector = new BarmanDirector(builder);

			//barmanDirector.PreparePiñaColada();

			//var preparedDrink = builder.GetPreparedDrink();

			//Console.WriteLine(preparedDrink.Result);

			//State Pattern
			var customerContext = new CustomerContext();
			Console.WriteLine(customerContext.GetState());
			customerContext.Request(100);
			Console.WriteLine(customerContext.GetState());

			customerContext.Request(50);
			Console.WriteLine(customerContext.GetState());

			customerContext.Request(100);
			Console.WriteLine(customerContext.GetState());

			customerContext.Request(50);
			Console.WriteLine(customerContext.GetState());

			customerContext.Request(50);
			Console.WriteLine(customerContext.GetState());
		}
	}
}
