namespace Modulo15.Web.Controllers
{
	using System;
	using System.Web.Mvc;
	using System.Web.Security;
	using Models;

	public class LoginController : Controller
	{
		public ActionResult Index(string returnUrl)
		{
			var vm = new LoginViewModel
			{
				ReturnUrl = returnUrl
			};

			return View(vm);
		}

		public ActionResult Logar(LoginViewModel vm)
		{
			var usuario = vm.Usuario;

			bool usuarioValido = Membership.ValidateUser(usuario, vm.Senha);

			if (usuarioValido)
			{
				FormsAuthentication.SetAuthCookie(usuario, false);

				if (!string.IsNullOrWhiteSpace(vm.ReturnUrl))
				{
					return Redirect(vm.ReturnUrl);
				}

				return Redirect("~/");
			}

			ModelState.AddModelError("Usuario", "Usuário ou senha inválidos");

			return View("Index", vm);
		}

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			Session.Abandon();

			return Redirect("~/");
		}
	}
}