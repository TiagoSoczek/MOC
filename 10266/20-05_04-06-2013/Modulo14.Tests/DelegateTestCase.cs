namespace Modulo14.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class DelegateTestCase
	{
		[TestMethod]
		public void Testar()
		{
			Action acao1 = MetodoQualquer;
			Action acao2 = () => Console.WriteLine("Lambda");
			Action acao3 = delegate
			{
				Console.WriteLine("Delegate");
			};

			var acoes = new List<Action>
			{
				acao1,
				acao2,
				acao3
			};

			foreach (Action acao in acoes)
			{
				acao.Invoke();
			}
		}

		[TestMethod]
		public void Filtro()
		{
			var produtos = new List<Produto>();

			var produtosFiltrados = produtos.Where(p => FiltroPorPreco(p)
				|| FiltroPorQuantidade(p)).ToList();

			Func<Produto, bool> filtro = FiltroPorPreco;

			if (DateTime.Now.Hour != 19)
			{
				filtro = FiltroPorQuantidade;
			}

			var produtosFiltradosDinamicamente = produtos.
											Where(filtro).ToList();
		}

		public bool FiltroPorPreco(Produto p)
		{
			return p.Preco > 10;
		}

		public bool FiltroPorQuantidade(Produto p)
		{
			return p.Quantidade > 50;
		}

		public void MetodoQualquer()
		{
			Console.WriteLine("MetodoQualquer");
		}
	}
}