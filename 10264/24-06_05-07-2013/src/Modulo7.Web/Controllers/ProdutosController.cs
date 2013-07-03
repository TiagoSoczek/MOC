namespace Modulo7.Web.Controllers
{
	using System;
	using System.Diagnostics;
	using System.Web.Mvc;
	using Models;

	public class ProdutosController : Controller
	{
		public ActionResult Index()
		{
			return View("Form", new ProdutoModel());
		}

		public ActionResult Salvar(ProdutoModel model)
		{
			if (!TryValidateModel(model))
			{
				foreach (var state in ModelState)
				{
					Trace.WriteLine(state.Key);
					Trace.WriteLine(state.Value);
				}

				return View("Form", model);
			}

			// TODO: Salvar no banco!

			return Redirect("~/");
		}
	}
}