using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modulo13.Web.Controllers
{
	using Models;

	public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

		[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
		public ActionResult ConteudoParcial()
		{
			// return Content(DateTime.Now.ToString());

			return PartialView("ConteudoParcial");
		}

		public ActionResult ObterClientes()
		{
#if DEBUG
			Console.WriteLine("Debugando...");
#else
			Console.WriteLine("Rodando em modo Release...");
#endif
			var clientes = new List<Modulo13.Web.Models.Cliente>();

			for (int i = 0; i < new Random().Next(10, 50); i++)
			{
				var cliente = new Modulo13.Web.Models.Cliente();
				cliente.Id = i;
				cliente.Nome = "Cliente #" + i;
				cliente.DataNascimento = DateTime.Now.AddMonths(-i);
				cliente.TotalPedidos = i;

				clientes.Add(cliente);
			}

			return Json(clientes, JsonRequestBehavior.AllowGet);
		}
    }
}
