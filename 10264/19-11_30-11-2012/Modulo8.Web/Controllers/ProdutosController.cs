using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modulo8.Model;

namespace Modulo8.Web.Controllers
{
	using Models;


	public class ProdutosController : Controller
    {
        //
        // GET: /Produtos/

        public ActionResult Index(string termo)
        {
	        var model = new PesquisaProdutosModel();

	        model.Termo = termo;

			Modulo8Entities objectContext = new Modulo8Entities();

			if (string.IsNullOrWhiteSpace(termo))
			{
				model.Produtos = objectContext.Produto.ToList();
			}
			else
			{
				model.Produtos = objectContext.Produto.
					Where(p => p.Nome.Contains(termo)).ToList();
			}

			return View(model);
        }

		public ActionResult Novo()
		{
			var produto = new Produto();

			return View(produto);
		}

		public ActionResult Salvar(Produto produto)
		{
			Modulo8Entities objectContext = new Modulo8Entities();

			objectContext.Produto.Add(produto);
			objectContext.SaveChanges();

			return RedirectToAction("Index");
		}
    }
}
