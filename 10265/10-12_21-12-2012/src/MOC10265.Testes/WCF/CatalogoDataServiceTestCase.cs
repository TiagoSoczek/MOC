namespace MOC10265.Testes.WCF
{
	using System;
	using System.Data.Services.Client;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class CatalogoDataServiceTestCase
	{
		[TestMethod]
		public void ObterTodosProdutos()
		{
			string url = "http://localhost.fiddler:19523/Services/CatalogoDataService.svc";

			var context = new DataServiceContext(new Uri(url));

			var todosProdutos = context.CreateQuery<Produto>("Produtoes").ToList();

			foreach (var produto in todosProdutos)
			{
				Console.WriteLine(produto);
			}

			var produtosAcima100 = context.CreateQuery<Produto>("Produtoes").
										Where(p => p.Preco > 100).ToList();

			foreach (var produto in produtosAcima100)
			{
				Console.WriteLine(produto);
			}
		}
	}
}