namespace MOC10265.Testes.Persistence.RavenDb
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;
	using Raven.Client;
	using Raven.Client.Document;

	[TestClass]
	public class RavenDbTestCase
	{
		[TestMethod]
		public void SalvarProdutos()
		{
			IDocumentStore store = new DocumentStore { ConnectionStringName = "RavenDB" };

			store.Initialize();

			using (var session = store.OpenSession())
			{
				var produto = new Produto();

				produto.Nome = "Teste Raven";
				produto.Preco = 123;
				produto.Quantidade = 10;

				produto.Departamentos.Add(new Departamento
					                          {
						                          Nome = "Depto Teste"
					                          });

				session.Store(produto);

				session.SaveChanges();
			}
		}
	}
}