namespace Modulo4.Web.Controllers
{
	using System.Web.Mvc;

	public class HomeController : Controller
	{
		[Authorize]
		public ActionResult Admin()
		{
			return Content("Conteúdo Restrito");
		}

		public ActionResult Index()
		{
			return Content("Conteúdo Público");
		}
	}
}