namespace Modulo14.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class EventosTestCase
	{
		[TestMethod]
		public void TestEventos()
		{
			Produto.ProdutoForaEstoque += delegate(Produto p)
			{
				Console.WriteLine("Produto {0} Fora Estoque", p.Nome);
			};

			Produto.ProdutoForaEstoque += ProdutoForaEstoque;

			Produto.ProdutoVoltouNoEstoque += p =>
				Console.WriteLine("Produto {0} Voltou Estoque", p.Nome);

			Produto produtoTeste = new Produto
			{
				Nome = "Produto1"
			};

			Produto produtoTeste2 = new Produto
			{
				Nome = "Produto2"
			};

			produtoTeste2.AlterarQuantidade(10);
			produtoTeste2.AlterarQuantidade(0);

			produtoTeste.AlterarQuantidade(10);
			produtoTeste.AlterarQuantidade(1);
			produtoTeste.AlterarQuantidade(0);
			produtoTeste.AlterarQuantidade(100);

			Produto.ProdutoForaEstoque -= ProdutoForaEstoque;

			produtoTeste.AlterarQuantidade(0);
		}

		private void ProdutoForaEstoque(Produto produto)
		{
			Console.WriteLine("Segundo tratamento");
		}
	}
}