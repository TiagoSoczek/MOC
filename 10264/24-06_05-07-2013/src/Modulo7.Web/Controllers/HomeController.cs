namespace Modulo7.Web.Controllers
{
	using System.Web.Mvc;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Produtos()
		{
			return View();
		}

		public ActionResult Hero(string title)
		{
			return PartialView("_HeroHeader", title);
		}
	}
}