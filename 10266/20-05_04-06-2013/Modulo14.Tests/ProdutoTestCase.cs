namespace Modulo14.Tests
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class ProdutoTestCase
	{
		[TestMethod]
		public void Linq()
		{
			List<Produto> produtos = ObterEstoque();

			var produtosForaEstoque = produtos.Where(ProdutoForaEstoque).ToList();

			Print(produtosForaEstoque);

			List<string> nomes = produtos.Select(p => p.Nome).ToList();

			Print(nomes);

			List<Produto> produtosPorPreco = produtos.OrderBy(p => p.Preco).
												ThenBy(p => p.Nome).ToList();

			Print(produtosPorPreco);

			int qtdeAtivos = produtos.Count(p => p.Ativo);

			Console.WriteLine(qtdeAtivos);

			var produtosCadastradosPorHoraAtivo = 
				produtos.GroupBy(p => new { Hora = p.DataCadastro.Hour, p.Ativo }).ToList();

			foreach (var grupo in produtosCadastradosPorHoraAtivo)
			{
				Console.WriteLine(grupo.Key.Hora);
				Console.WriteLine(grupo.Key.Ativo);

				foreach (Produto produto in grupo)
				{
					Console.WriteLine(produto.Nome);
				}
			}

			double precoMedio = produtos.Average(p => p.Preco);
			
			Console.WriteLine(precoMedio);

			var tempoMedioCadastroNumerico = produtos.Average(p => p.TempoDeCadastro.Ticks);
			var tempoMedioCadastro = TimeSpan.FromTicks((long)tempoMedioCadastroNumerico);
			
			Console.WriteLine(tempoMedioCadastro);
			Console.WriteLine(tempoMedioCadastro.Days);
			Console.WriteLine(tempoMedioCadastro.TotalDays);

			bool algumProdutoEmEstoque = produtos.Any(p => !ProdutoForaEstoque(p));

			Console.WriteLine(algumProdutoEmEstoque);
			
			bool todosProdutosForaEstoque = produtos.All(ProdutoForaEstoque);

			Console.WriteLine(todosProdutosForaEstoque);

			var primeiroMaiorQue50 = produtos.
				OrderBy(p => p.Quantidade).
				FirstOrDefault(p => p.Quantidade > 50);

			Console.WriteLine(primeiroMaiorQue50);

			var ultimoMenorQue50 = produtos.
				OrderBy(p => p.Quantidade).
				LastOrDefault(p => p.Quantidade < 50);

			Console.WriteLine(ultimoMenorQue50);

			// var unicoProduto = produtos.SingleOrDefault(p => p.Quantidade == 50);

			// Console.WriteLine(unicoProduto);

			/*var produtosTeste = produtos.Where(p => p.Preco < 50 
									 && p.Quantidade > 50).ToList();*/
			var produtosTeste = (from p in produtos
				where p.Preco < 50 && p.Quantidade > 50
				select p).ToList();

			Print(produtosTeste);
		}

		private bool ProdutoForaEstoque(Produto produto)
		{
			return produto.Quantidade == 0;
		}

		private void Print(IEnumerable items)
		{
			foreach (object item in items)
			{
				Console.WriteLine(item);
			}
		}

		private List<Produto> ObterEstoque()
		{
			var lista = new List<Produto>();
			var rnd = new Random();
			var agora = DateTime.Now;

			for (int i = 0; i < 100; i++)
			{
				Produto p = new Produto
				{
					DataCadastro = agora.AddHours(-i),
					Nome = "Produto#" + i,
					Preco = rnd.Next(1, 1000),
					Ativo = rnd.Next(1, 10) != 1
				};

				p.AlterarQuantidade(rnd.Next(0, 100));

				lista.Add(p);
			}

			return lista;
		}
	}
}