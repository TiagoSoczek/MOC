namespace MOC10265.Testes.Services
{
	using System.Linq;
	using MOC10265.Persistence.EF;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model.Repositories;
	using Model.Services;

	[TestClass]
	public class CatalogoServiceTestCase
	{
		private CatalogoService _catalogoService;

		[TestInitialize]
		public void Setup()
		{
			IProdutoRepository produtoRepository = new ProdutoEFRepository();
			IDepartamentoRepository departamentoRepository = new DepartamentoEFRepository();

			_catalogoService = new 
				CatalogoService(produtoRepository, departamentoRepository);
		}

		[TestMethod]
		public void ObterTodosProdutos()
		{
			var produtos = _catalogoService.ObterTodosProdutos();

			Assert.IsTrue(produtos.All(p => p.Departamento != null), 
				"Todos produtos devem ter departamento");
		}
	}
}