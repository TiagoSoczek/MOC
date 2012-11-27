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
		private ProdutoService _produtoService;

		public ProdutosController()
		{
			_produtoService = new ProdutoService();
		}

		public ActionResult Index(string termo)
        {
	        var model = new PesquisaProdutosModel();

	        model.Termo = termo;

			model.Produtos = _produtoService.PesquisarProdutos(termo);

			return View(model);
        }

		public ActionResult Novo()
		{
			var produto = new Produto();

			return View(produto);
		}

		public ActionResult Salvar(Produto produto)
		{
			_produtoService.Salvar(produto);

			return RedirectToAction("Index");
		}
    }
}
