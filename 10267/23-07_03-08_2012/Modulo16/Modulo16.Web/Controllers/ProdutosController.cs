using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modulo16.Web.Controllers
{
	using Modulo16.Web.Models;

	public class ProdutosController : Controller
    {
        public ActionResult Index()
        {
			ProdutosViewModel model = new ProdutosViewModel();

	        model.PrecoMedio = 123.98;
	        model.Qtde = 9000;

            return View(model);
        }

		public ActionResult Teste(int? qtde, double? precoMedio)
		{
			ProdutosViewModel model = new ProdutosViewModel();

			model.PrecoMedio = precoMedio.GetValueOrDefault();
			model.Qtde = qtde.GetValueOrDefault();

			return View("Index", model);
		}
    }
}
