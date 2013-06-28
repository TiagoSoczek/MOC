namespace Modulo5.Web.Areas.Admin.Controllers
{
	using System.Web.Mvc;

	public class ProdutosController : SecureController
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}