namespace Modulo4.Web.Controllers
{
	using System;
	using System.Web.Mvc;
	using Core;
	using Models;

	public class ProdutosController : Controller
	{
		private ProdutoService _produtoService = new ProdutoService();

		public ActionResult Index()
		{
			ProdutosViewModel vm = new ProdutosViewModel();

			vm.Agora = DateTime.Now;
			vm.Preco = 379.99;

			vm.Produtos = _produtoService.ObterTodos();

			return View(vm);
		}

		public ActionResult Novo()
		{
			var vm = new CadastroProdutoViewModel();

			return View(vm);
		}

		public ActionResult Salvar(CadastroProdutoViewModel vm)
		{
			_produtoService.Salvar(vm.Nome, vm.Preco);

			return RedirectToAction("Index");
		}
	}
}