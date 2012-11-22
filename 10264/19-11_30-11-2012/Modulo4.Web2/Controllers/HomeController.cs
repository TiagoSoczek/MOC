namespace Modulo4.Web2.Controllers
{
	using System;
	using System.Reflection;
	using System.Web.Mvc;
	using Filters;

	[Exemplo2(Order = 2), Exemplo(Order = 1), ExemploMalandro(Order = 3)]
	/*[ExemploMalandro]
	[Exemplo]
	[Exemplo2]*/
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			// var attr = Attribute.GetCustomAttributes(typeof (HomeController));
			
			return View();
		}

		[HandleError(View = "Erro")]
		public ActionResult ComProblema()
		{
			throw new Exception("Erro qualquer");
		}

		[Authorize]
		public ActionResult Admin()
		{
			return View();
		}
	}
}