namespace MOC10265.Testes.Persistence.NH
{
	using System;
	using MOC10265.Persistence.EF.Mapeamentos;
	using MOC10265.Persistence.NH.Mapeamentos;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;
	using NHibernate;
	using NHibernate.Cfg;
	using NHibernate.Dialect;
	using NHibernate.Mapping.ByCode;

	[TestClass]
	public class NHibernateTestCase
	{
		[TestMethod]
		public void ExportSchema()
		{
			// Inicio do Setup do NH
			var config = new Configuration();

			config.DataBaseIntegration(
				db =>
				{
					db.Dialect<MsSql2008Dialect>();
					db.ConnectionStringName = "DefaultNH";
					db.SchemaAction = SchemaAutoAction.Recreate;
				});

			ModelMapper modelMapper = new ModelMapper();

			modelMapper.AddMapping<ProdutoNHMap>();
			modelMapper.AddMapping<DepartamentoNHMap>();

			config.AddDeserializedMapping(modelMapper.CompileMappingForAllExplicitlyAddedEntities(), "Domain");

			ISessionFactory sessionFactory = config.BuildSessionFactory();

			// Fim do Setup do NH - Isso deve ficar no start da app (Global.asax por exemplo)

			using (var session = sessionFactory.OpenSession())
			{
				// Criteria API
				// HQL
				// Linq

				var produtosAcima1000 = session.QueryOver<Produto>().List();

				foreach (var produto in produtosAcima1000)
				{
					Console.WriteLine(produto);
				}
			}

			using (var session = sessionFactory.OpenSession())
			{
				var produto = new Produto();

				produto.Nome = "Teste #1";
				produto.Preco = 90;
				produto.Quantidade = 123;
				produto.Ativo = true;

				session.Save(produto);
				session.Flush();
			}
		}
	}
}