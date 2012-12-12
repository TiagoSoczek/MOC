namespace MOC10265.Web.Controllers
{
	using System.Web.Mvc;
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
	}
}