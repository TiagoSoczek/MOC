namespace Modulo4.Web.Controllers
{
	using System.Web.Mvc;

	public class LoginController : Controller
	{
		public ActionResult Index()
		{
			return Content("Isso é um formulário de login");
		}
	}
}