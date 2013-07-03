namespace Modulo5.Web.Controllers
{
	using System;
	using System.Web.Mvc;
	using System.Web.Security;
	using Models;

	public class LoginController : Controller
	{
		public ActionResult Index(LoginModel model)
		{
			return View(model);
		}

		public ActionResult Logar(LoginModel model)
		{
			if ("tiago".Equals(model.Usuario, StringComparison.InvariantCultureIgnoreCase) && 
						model.Senha.Equals("soczek"))
			{
				FormsAuthentication.SetAuthCookie(model.Usuario, true);

				if (!string.IsNullOrWhiteSpace(model.ReturnUrl))
				{
					return Redirect(model.ReturnUrl);
				}

				return Redirect("~/");
			}
			
			model.Erro = true;
			model.Mensagem = "Usuario ou senha incorretos";

			return View("Index", model);
		}

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();

			return Redirect("~/");
		}
	}
}