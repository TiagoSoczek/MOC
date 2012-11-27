using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Modulo8.Web.Controllers
{
	public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Login(string usuario, string senha)
		{
			bool usuarioValido = Membership.ValidateUser(usuario, senha);

			if (usuarioValido)
			{
				FormsAuthentication.SetAuthCookie(usuario, false);
				FormsAuthentication.RedirectFromLoginPage(usuario, false);

				return RedirectToAction("Index", "Admin");
			}

			return RedirectToAction("Index");
		}
    }
}
