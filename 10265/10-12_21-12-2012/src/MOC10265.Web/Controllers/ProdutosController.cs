namespace MOC10265.Web.Controllers
{
	using System;
	using System.Web.Mvc;
	using Model;
	using Model.Services;
	using Models;
	using NLog;
	using Persistence.ADO;
	using Persistence.EF;

	public class ProdutosController : Controller
	{
		private readonly CatalogoService _catalogoService;
		private readonly Logger _logger;

		public ProdutosController()
		{
			var factory = new LogFactory();

			_logger = factory.GetLogger("Default");

			_logger.Debug("Criando Controller");

			// var produtoRepository = new ProdutoADORepository();
			var produtoRepository = new ProdutoEFRepository();
			var departamentoRepository = new DepartamentoEFRepository();

			_catalogoService = new CatalogoService(produtoRepository, departamentoRepository);
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
				var mensagem = string.Format("Produto com id '{0}' não encontrado", id);

				_logger.Error(mensagem);

				throw new Exception(mensagem);

				return HttpNotFound(mensagem);
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