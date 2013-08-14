namespace Modulo15.Web.Controllers
{
	using System.Web.Mvc;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[Authorize]
		public ActionResult Restrita()
		{
			return View();
		}

		[Authorize(Roles = "ADMIN")]
		public ActionResult SomenteAdmin()
		{
			return Content("Somente ADMIN!!!");
		}

		[Authorize(Roles = "ADMIN,SUPERVISOR")]
		public ActionResult AdminOuSupervisor()
		{
			return Content("ADMIN ou SUPERVISOR!");
		}

		[Authorize(Roles = "SUPERVISOR")]
		public ActionResult SomenteSupervisor()
		{
			return Content("Somente SUPERVISOR!");
		}
	}
}