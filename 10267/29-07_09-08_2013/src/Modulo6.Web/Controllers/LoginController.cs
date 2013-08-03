namespace Modulo6.Web.Controllers
{
	using System;
	using System.Diagnostics;
	using System.Web.Mvc;
	using Core;
	using Models;

	public class LoginController : Controller
	{
		public ActionResult Index()
		{
			var model = new LoginViewModel();

			model.Usuario = "tiago";

			return View(model);
		}

		public ActionResult Logar(LoginViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View("Index", model);
			}

			AutenticacaoService service = new AutenticacaoService();

			Stopwatch sw = Stopwatch.StartNew();

			bool resultado = service.Autenticar(model.Usuario, model.Senha);

			sw.Stop();

			Trace.WriteLine("Autenticar em " + sw.ElapsedMilliseconds);

			if (!resultado)
			{
				ModelState.AddModelError("Usuario",
					"Usuário ou senha inválidos");

				return View("Index", model);
			}

			return Content("TOP SECRET!");
		}
	}
}