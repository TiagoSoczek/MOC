namespace MOC10265.Web.Controllers
{
	using System;
	using System.Web.Mvc;
	using Model;
	using Model.Services;
	using Models;
	using Persistence.ADO;

	public class ProdutosController : Controller
	{
		private readonly CatalogoService _catalogoService;

		public ProdutosController()
		{
			var produtoRepository = new ProdutoADORepository();

			_catalogoService = new CatalogoService(produtoRepository);
		}

		public ActionResult Index()
		{
			var model = new ProdutoModel();

			model.Produtos = _catalogoService.ObterTodosProdutos();

			return View(model);
		}

		public ActionResult Novo()
		{
			var model = new EditarProdutoModel();

			return View(model);
		}

		public ActionResult Editar(int id)
		{
			var produto = _catalogoService.ObterPorId(id);

			if (produto == null)
			{
				throw new Exception(string.Format("Produto com id '{0}' não encontrado", id));

				return HttpNotFound(string.Format("Produto com id '{0}' não encontrado", id));
			}

			var model = new EditarProdutoModel
				            {
					            Produto = produto
				            };

			return View("Novo", model);
		}

		public ActionResult Salvar(EditarProdutoModel model)
		{
			_catalogoService.Salvar(model.Produto);

			return RedirectToAction("Index");
		}

		public ActionResult Remover(int id)
		{
			_catalogoService.Remover(id);

			return RedirectToAction("Index");
		}
	}
}