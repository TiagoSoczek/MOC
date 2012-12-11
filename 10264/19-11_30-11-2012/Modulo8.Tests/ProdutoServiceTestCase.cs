namespace Modulo8.Tests
{
	using System.Collections.Generic;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;
	using Model.Services;

	[TestClass]
	public class ProdutoServiceTestCase
	{
		[TestMethod]
		public void PesquisarProdutos_SemTermos_DeveRetornarTodos()
		{
			var service = new ProductService();

			List<Produto> produtos = service.PesquisarProdutos(string.Empty);

			Assert.IsTrue(produtos.Count > 0);
		}

		[TestMethod]
		public void Salvar()
		{
			var service = new ProductService();

			Produto produto = new Produto();

			produto.Nome = "Falta pouco pessoal...";
			produto.Preco = 199;
			produto.Ativo = true;

			service.Salvar(produto);

			Assert.IsTrue(produto.Id > 0);
		}
	}
}