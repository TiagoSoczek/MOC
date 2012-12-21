namespace MOC10265.Testes.Persistence.EF
{
	using System;
	using System.Collections;
	using System.Data.Entity.Infrastructure;
	using System.Data.Entity.Validation;
	using System.Diagnostics;
	using System.Linq;
	using MOC10265.Persistence.EF;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class CatalogoContextoDbTestCase
	{
		private CatalogoContextoDb _contexto;

		[TestInitialize]
		public void Setup()
		{
			_contexto = new CatalogoContextoDb();
		}

		[TestMethod]
		public void InserirProdutos()
		{
			var departamento = new Departamento
			{
				Id = 1
			};

			_contexto.Linq<Departamento>().Attach(departamento);

			for (int i = 0; i < 1000; i++)
			{
				var produto = new Produto();

				produto.Nome = "Teste #" + i;
				produto.Preco = i;
				produto.Quantidade = i;
				produto.Ativo = true;

				produto.Departamentos.Add(departamento);

				_contexto.Linq<Produto>().Add(produto);
			}

			try
			{
				_contexto.Configuration.ValidateOnSaveEnabled = false;
				_contexto.SaveChanges();
			}
			catch (DbEntityValidationException ex)
			{
				foreach (var error in ex.EntityValidationErrors)
				{
					Console.WriteLine(error);
				}

				Assert.Fail("Erros de validação");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);

				Assert.Fail(e.ToString());
			}
		}

		[TestMethod]
		public void ObterProdutos_Paginados()
		{
			var primeiros10 = _contexto.Linq<Produto>().Take(10);
			
			ExibirQuery(primeiros10);

			var proximos10 = _contexto.Linq<Produto>().
											OrderBy(p => p.Id).
											Skip(10).Take(10);

			ExibirQuery(proximos10);

			var proximos20 = _contexto.Linq<Produto>().
											Include("Departamentos").
											OrderByDescending(p => p.Nome).
											ThenBy(p => p.Preco).
											Skip(10).Take(10);

			ExibirQuery(proximos20);
		}

		[TestMethod]
		public void Agregacoes()
		{
			var precoMedioProduto = _contexto.Linq<Produto>().
											  Average(p => p.Preco);

			Console.WriteLine(precoMedioProduto);

			var precoMedioProdutoQtdeAcima10 = _contexto.Linq<Produto>().
												Where(p => p.Quantidade > 10).
												Average(p => p.Preco);

			Console.WriteLine(precoMedioProdutoQtdeAcima10);

			var consultaAgrupada = _contexto.Linq<Produto>().
										Include("Departamentos").
				GroupBy(g => g.Nome).
				Select(p => new
				{
					Nome = p.Key, 
					ValorTotal = p.Sum(g => g.Preco),
					Minimo = p.Min(g => g.Preco), 
					Medio = p.Average(g => g.Preco), 
					Maximo = p.Max(g => g.Preco),
					Total = p.Count()
				});

			ExibirQuery(consultaAgrupada);

			var consultaAgrupada2 = _contexto.Linq<Produto>().
				GroupBy(g => new { g.Nome, g.Ativo }).
				Select(p => new
				{
					Nome = p.Key.Nome,
					Ativo = p.Key.Ativo,
					ValorTotal = p.Sum(g => g.Preco),
					Minimo = p.Min(g => g.Preco),
					Medio = p.Average(g => g.Preco),
					Maximo = p.Max(g => g.Preco),
					Total = p.Count()
				});

			ExibirQuery(consultaAgrupada2);
		}

		[TestMethod]
		public void Like()
		{
			var pesquisaLikeInicial = _contexto.Linq<Produto>().
										 Where(p => p.Nome.StartsWith("P"));

			ExibirQuery(pesquisaLikeInicial);

			var pesquisaLikeFinal = _contexto.Linq<Produto>().
										 Where(p => p.Nome.EndsWith("P"));

			ExibirQuery(pesquisaLikeFinal);

			var pesquisaLikeCompleta = _contexto.Linq<Produto>().
										 Where(p => p.Nome.Contains("Teste"));

			ExibirQuery(pesquisaLikeCompleta);

			var pesquisaLikeCompletaUpper = _contexto.Linq<Produto>().
										 Where(p => p.Nome.ToUpper().Contains("TESTE"));

			ExibirQuery(pesquisaLikeCompletaUpper);

			var pesquisaSubStr = _contexto.Linq<Produto>().
										 Where(p => p.Nome.Substring(0, 1) == "C");

			ExibirQuery(pesquisaSubStr);
		}

		[TestMethod]
		public void Joins()
		{
			var joinDepto = from p in _contexto.Linq<Produto>()
			                from d in p.Departamentos
							where d.Nome.Contains("teste")
							select new {p, p.Departamentos};

			ExibirQuery(joinDepto);
		}

		[TestMethod]
		public void FirstAndLast()
		{
			var produtoExistente = _contexto.Linq<Produto>().
								FirstOrDefault(p => p.Id == 1);

			Assert.IsNotNull(produtoExistente);

			var produtoNaoExistente = _contexto.Linq<Produto>().
								FirstOrDefault(p => p.Id == 9999999);

			Assert.IsNull(produtoNaoExistente);

			var produtoMaisBarato = _contexto.Linq<Produto>().
											  OrderBy(p => p.Preco).
											  FirstOrDefault();

			Console.WriteLine(produtoMaisBarato);

			var produtoMaisCaro = _contexto.Linq<Produto>().
											  OrderByDescending(p => p.Preco).
											  FirstOrDefault();

			Console.WriteLine(produtoMaisCaro);
		}

		[TestMethod]
		public void AnyAll()
		{
			var todosProdutosAcima100 = _contexto.Linq<Produto>().
												All(p => p.Preco > 100);

			Console.WriteLine(todosProdutosAcima100);

			var algumProdutoAcima2000 = _contexto.Linq<Produto>().
												Any(p => p.Preco > 2000);

			Console.WriteLine(algumProdutoAcima2000);
		}

		private void ExibirQuery<T>(IQueryable<T> query)
		{
			var linha = new string('-', 100);

			Console.WriteLine("SQL");
			Console.WriteLine(linha);

			var sql = query.ToString();

			Console.WriteLine(sql);

			Console.WriteLine("Resultados");
			Console.WriteLine(linha);

			var sw = Stopwatch.StartNew();

			var resultado = query.ToList();

			sw.Stop();

			Console.WriteLine("Tempo: {0}ms", sw.ElapsedMilliseconds);

			Console.WriteLine(linha);

			foreach (var item in resultado)
			{
				Console.WriteLine(item);
				
				Console.WriteLine(linha);
			}
		}

		[TestCleanup]
		public void TearDown()
		{
			_contexto.Dispose();
		}
	}
}