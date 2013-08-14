namespace Modulo15.Web.Areas.Manager.Controllers
{
	using System.Web.Mvc;

	[Authorize]
	public abstract class SecureController : Controller
	{
	}

	[Authorize(Roles = "ADMIN")]
	public abstract class SecureAdminController : Controller
	{
	}

	[Authorize(Roles = "SUPERVISOR")]
	public abstract class SecureSupervisorController : Controller
	{
	}
}