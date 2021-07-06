using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesignPatternsAsp.Controllers
{
	public class ProductDetailController : Controller
	{
		private LocalEarnFactory _localEarnFactory;
		private ForeignEarnFactory _foreignEarnFactory;

		public ProductDetailController(LocalEarnFactory localEarnFactory,
			ForeignEarnFactory foreignEarnFactory)
		{
			_localEarnFactory = localEarnFactory;
			_foreignEarnFactory = foreignEarnFactory;
		}
		public IActionResult Index(decimal total)
		{
			// factories
			//LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
			//ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

			// products
			var localEarn = _localEarnFactory.GetEarn();
			var foreignEarn = _foreignEarnFactory.GetEarn();

			// total
			ViewBag.totalLocal = total + localEarn.Earn(total);
			ViewBag.totalForeign = total + foreignEarn.Earn(total);

			return View();
		}
	}
}
