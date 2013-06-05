namespace ExemploNH.Tests
{
	using System;
	using Core.Mapeamentos;
	using Model;
	using NHibernate;
	using NHibernate.Cfg;
	using NHibernate.Dialect;
	using NHibernate.Mapping.ByCode;
	using NHibernate.Tool.hbm2ddl;
	using NUnit.Framework;

	[TestFixture]
	public class SchemaTestCase
	{
		[Test]
		public void CriarSchema()
		{
			// Apenas no Init da Aplicação

			var config = new Configuration();

			config.DataBaseIntegration(c =>
			{
				c.Dialect<MsSql2012Dialect>();
				c.ConnectionStringName = "ExemploNH";
				c.LogFormattedSql = true;
				c.LogSqlInConsole = true;
				c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
			});

			var modelMapper = new ModelMapper();

			modelMapper.AddMappings(typeof (ProdutoMap).Assembly.GetExportedTypes());

			config.AddDeserializedMapping(modelMapper.CompileMappingForAllExplicitlyAddedEntities(), "Domain");

			ISessionFactory sessionFactory = config.BuildSessionFactory();

			// NOTE: Estudar framework FluentMigration
			var schemaExport = new SchemaExport(config);

			schemaExport.Create(true, true);
		}
	}
}