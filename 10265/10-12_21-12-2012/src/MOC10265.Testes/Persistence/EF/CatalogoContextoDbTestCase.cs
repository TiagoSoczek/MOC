namespace MOC10265.Testes.Persistence.EF
{
	using System;
	using System.Collections;
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

			Console.WriteLine(linha);
		}

		[TestCleanup]
		public void TearDown()
		{
			_contexto.Dispose();
		}
	}
}