using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modulo8.Model;
using Modulo8.Model.Services;

namespace Modulo8.Web.Controllers
{
	using Models;

	public class ProdutosController : Controller
	{
		private ProductService _productService;

		public ProdutosController()
		{
			_productService = new ProductService();
		}

		public ActionResult Index(string termo)
        {
	        var model = new PesquisaProdutosModel();

	        model.Termo = termo;

			model.Produtos = _productService.PesquisarProdutos(termo);

			return View(model);
        }

		public ActionResult Novo()
		{
			var produto = new Produto();

			return View(produto);
		}

		public ActionResult Salvar(Produto produto)
		{
			_productService.Salvar(produto);

			return RedirectToAction("Index");
		}
    }
}
