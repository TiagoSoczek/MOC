namespace Modulo4.Web.Controllers
{
	using System;
	using System.Web.Mvc;
	using Models;

	public class ProdutosController : Controller
	{
		public ActionResult Index()
		{
			ProdutosViewModel vm = new ProdutosViewModel();

			vm.Agora = DateTime.Now;
			vm.Preco = 379.99;

			return View(vm);
		}

		public ActionResult Novo()
		{
			var vm = new CadastroProdutoViewModel();

			return View(vm);
		}

		public ActionResult Salvar(CadastroProdutoViewModel vm)
		{
			// TODO: Salvar

			return RedirectToAction("Index");
		}
	}
}