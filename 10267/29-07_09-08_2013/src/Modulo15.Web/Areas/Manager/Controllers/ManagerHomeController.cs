namespace Modulo15.Web.Areas.Manager.Controllers
{
	using System.Web.Mvc;

	public class ManagerHomeController : SecureController
	{
		public ActionResult Index()
		{
			return Content("Manager");
		}
	}

	public class AdminController : SecureAdminController
	{
		public ActionResult Index()
		{
			return Content("ADMIN");
		}
	}

	public class SupervisorController : SecureSupervisorController
	{
		public ActionResult Index()
		{
			return Content("SUPERVISOR");
		}
	}

}