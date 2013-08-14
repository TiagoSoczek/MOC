namespace Modulo11.Web.Controllers
{
	using System;
	using System.Threading;
	using System.Web.Mvc;

	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Listar(int quantidade = 10)
		{
			Thread.Sleep(3000);
			return PartialView(quantidade);
		}

		public ActionResult ObterDadosEmJson()
		{
			// throw new Exception("Eita!");

			return Json(new
			{
				Curso = "MOC 10267",
				Ano = 2013
			}, JsonRequestBehavior.AllowGet);
		}
	}
}