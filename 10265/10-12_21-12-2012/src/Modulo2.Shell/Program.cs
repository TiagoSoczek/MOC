using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo2.Shell
{
	using System.Data.Entity.Infrastructure;
	using System.Data.Objects;

	class Program
	{
		static void Main(string[] args)
		{
			using (var contexto = new MOC10265Entities())
			{
				var novoProduto = new Produto();

				novoProduto.Nome = "Produto Teste do EF DB First";
				novoProduto.Preco = 123;
				novoProduto.Quantidade = 1;
				novoProduto.Ativo = true;

				contexto.Produto.Add(novoProduto);

				contexto.SaveChanges();

				novoProduto.Quantidade = 1000;

				contexto.SaveChanges();

				var totalProdutos = contexto.Produto.Count();

				Console.WriteLine("Total Tde Produtos: {0}", totalProdutos);

				var precoMedioProdutosAcima500 = contexto.Produto.
							Where(p => p.Quantidade > 500).
							Average(p => p.Preco);

				 List<Produto> todosProdutos = contexto.Produto.
							Where(p => p.Quantidade > 500).ToList();

				var produtosAcima500 = todosProdutos.Count();

				Console.WriteLine("Produtos acima de 500: {0}", produtosAcima500);

				foreach (var produto in todosProdutos)
				{
					Console.WriteLine(produto);
				}

				var apenasNomeQuantidade = contexto.Produto.
										Where(p => p.Quantidade > 700).
										Select(p => new { p.Nome, p.Quantidade });

				var sql = apenasNomeQuantidade.ToString();

				Console.WriteLine(sql);

				foreach (var nomeQuantidade in apenasNomeQuantidade)
				{
					Console.WriteLine(nomeQuantidade.Nome);
					Console.WriteLine(nomeQuantidade.Quantidade);
				}
			}

			Console.Read();
		}
	}
}
