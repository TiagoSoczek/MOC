namespace Modulo4.Web2.Controllers
{
	using System.Web.Mvc;
	using Filters;

	[TesteFiltro]
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{
			return View();
		}

		[Authorize]
		public ActionResult Admin()
		{
			return View();
		}
	}
}