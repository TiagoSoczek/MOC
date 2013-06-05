namespace ExemploNH.Web.Controllers
{
	using System.Web.Mvc;
	using Core.Repositorios;
	using Core.Servicos;
	using Model;
	using Models;

	public class ProdutoController : Controller
	{
		private readonly CatalogoService _catalogoService;

		// TODO: Pesquisar por frameworks de injeção de dependências: Castle.Windsor, Funq, StructureMap

		public ProdutoController()
		{
			ProdutoRepository produtoRepository = new ProdutoRepository(NHIbernateBootstrap.Factory);

			_catalogoService = new CatalogoService(produtoRepository);
		}
		
		public ActionResult Index()
		{
			var todosProdutos = _catalogoService.PesquisarProdutos();

			ProdutosModel model = new ProdutosModel
			{
				Produtos = todosProdutos
			};

			return View(model);
		}

		public ActionResult Novo()
		{
			var produto = new Produto();
			
			return View("Editar", produto);
		}

		public ActionResult Salvar(Produto produto)
		{
			_catalogoService.SalvarProduto(produto);

			return RedirectToAction("Index");
		}

		public ActionResult Editar(int id)
		{
			var produto = _catalogoService.ObterProdutoPorId(id);

			return View("Editar", produto);
		}

		public ActionResult Excluir(int id)
		{
			_catalogoService.ExcluirProduto(id);

			return RedirectToAction("Index");
		}
	}
}