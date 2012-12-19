namespace MOC10265.Testes.Services
{
	using System.Linq;
	using MOC10265.Persistence.EF;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;
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

		[TestMethod]
		public void Salvar()
		{
			var produto = new Produto();

			produto.Nome = "Celular Teste";
			produto.Preco = 1499;
			produto.Quantidade = 123;
			produto.Ativo = true;

			var departamento = new Departamento();

			departamento.Nome = "Departamento Teste";

			produto.Departamento = departamento;

			var produtoSalvo = _catalogoService.Salvar(produto);

			Assert.IsNotNull(produtoSalvo);
			Assert.IsTrue(produtoSalvo.Id > 0);

			Assert.IsNotNull(produtoSalvo.Departamento);
			Assert.IsTrue(produtoSalvo.Departamento.Id > 0);
		}

		[TestMethod]
		public void Salvar_ComDepartamentoExistente_DeveReutilizarDepartamento()
		{
			var produto = new Produto();

			produto.Nome = "Celular Teste";
			produto.Preco = 1499;
			produto.Quantidade = 123;
			produto.Ativo = true;

			var departamento = new Departamento();

			departamento.Id = 1;

			produto.Departamento = departamento;

			var produtoSalvo = _catalogoService.Salvar(produto);

			Assert.IsNotNull(produtoSalvo);
			Assert.IsTrue(produtoSalvo.Id > 0);

			Assert.IsNotNull(produtoSalvo.Departamento);
			Assert.AreEqual(1, produtoSalvo.Departamento.Id);
		}
	}
}