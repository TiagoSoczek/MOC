namespace Modulo10.Web.Controllers
{
	using System.Web.Mvc;

	public class AdminController : Controller
	{
		[Authorize(Roles = "ADMIN")]
		public ActionResult Index()
		{
			return View();
		}

		[Authorize(Roles = "SUPERVISOR")]
		public ActionResult Supervisor()
		{
			return View();
		}
	}
}