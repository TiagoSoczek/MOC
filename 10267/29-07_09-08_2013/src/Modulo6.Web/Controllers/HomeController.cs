namespace Modulo6.Web.Controllers
{
	using System.Web.Mvc;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult SemLayout()
		{
			return View();
		}
	}
}