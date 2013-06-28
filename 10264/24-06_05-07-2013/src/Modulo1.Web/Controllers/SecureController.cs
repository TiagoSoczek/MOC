namespace Modulo1.Web.Controllers
{
	using System.Web.Mvc;

	[Authorize]
	public abstract class SecureController : Controller
	{
		[AllowAnonymous]
		public ActionResult Teste()
		{
			return View();
		}
	}
}