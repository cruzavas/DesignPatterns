using DesignPatterns.Repository;
using DesignPatternsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategies
{
	public interface IBeerStrategy
	{
		public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
	}
}
