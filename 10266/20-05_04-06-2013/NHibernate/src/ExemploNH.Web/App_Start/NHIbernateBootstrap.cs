namespace ExemploNH.Web
{
	using Core.Mapeamentos;
	using NHibernate;
	using NHibernate.Cfg;
	using NHibernate.Dialect;
	using NHibernate.Mapping.ByCode;

	public class NHIbernateBootstrap
	{
		// TODO: Pesquisar por UnitOfWork (UoW) - Open Session in View
		// TODO: Pesquisar por frameworks de injeção de dependências: Castle.Windsor, Funq, StructureMap

		public static ISessionFactory Factory { get; private set; }

		public static void Init()
		{
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

			modelMapper.AddMappings(typeof(ProdutoMap).Assembly.GetExportedTypes());

			config.AddDeserializedMapping(modelMapper.CompileMappingForAllExplicitlyAddedEntities(), "Domain");

			Factory = config.BuildSessionFactory();
		}
	}
}