namespace MOC10265.Testes.Persistence.ADO
{
	using System;
	using MOC10265.Persistence.ADO;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class ProdutoADORepositoryTestCase
	{
		private ProdutoADORepository _repository;

		[TestInitialize]
		public void Setup()
		{
			_repository = new ProdutoADORepository();
		}

		[TestMethod]
		public void ObterTodos()
		{
			InserirProdutoTeste();

			var todosProdutos = _repository.ObterTodos();

			Assert.IsTrue(todosProdutos.Count > 0);
		}

		[TestMethod]
		public void ObterPorId()
		{
			var produtoTeste = InserirProdutoTeste();
			
			var produto = _repository.ObterPorId(produtoTeste.Id);

			Assert.IsNotNull(produto);
		}

		[TestMethod]
		public void Inserir()
		{
			var produto = new Produto();

			produto.Nome = "Google Nexus";
			produto.Preco = 1239;
			produto.Quantidade = 90;
			produto.Ativo = true;

			var produtoInserido = _repository.Inserir(produto);

			Assert.IsNotNull(produtoInserido);
			Assert.IsTrue(produtoInserido.Id > 0);
		}

		[TestMethod]
		public void Atualizar()
		{
			var produtoInserido = InserirProdutoTeste();

			produtoInserido.Preco = 1999;

			var produtoAtualizado = _repository.Atualizar(produtoInserido);

			Assert.IsNotNull(produtoAtualizado);
			Assert.AreEqual(1999, produtoAtualizado.Preco);
		}

		[TestMethod, ExpectedException(typeof(Exception))]
		public void Atualizar_QuandoVersaoForAlterada()
		{
			var produtoInserido = InserirProdutoTeste();

			produtoInserido.Preco = 1999;

			var produtoAtualizadoConcorrente = _repository.Atualizar(produtoInserido);
			
			// Irá falhar
			_repository.Atualizar(produtoInserido);

			Assert.Fail("Isso não deveria ser executado!");
		}

		[TestMethod]
		public void Remover()
		{
			var produto = InserirProdutoTeste();

			_repository.Remover(produto.Id);

			var produtoDeveSerNulo = _repository.ObterPorId(produto.Id);

			Assert.IsNull(produtoDeveSerNulo);
		}

		private Produto InserirProdutoTeste()
		{
			var produto = new Produto();

			produto.Nome = "Produto Teste";
			produto.Preco = 123;
			produto.Quantidade = 90;
			produto.Ativo = true;

			var produtoInserido = _repository.Inserir(produto);

			Assert.IsNotNull(produtoInserido);
			Assert.IsTrue(produtoInserido.Id > 0);

			return produtoInserido;
		}
	}
}