namespace MOC10265.Persistence.EF
{
	using System.Data.Entity;
	using System.Data.Entity.ModelConfiguration.Conventions;
	using Mapeamentos;
	using Model;

	public class CatalogoContextoDb : DbContext
	{
		static CatalogoContextoDb()
		{
			Database.SetInitializer<CatalogoContextoDb>(null);
		}

		public CatalogoContextoDb()
			: base("Default")
		{
		}

		public DbSet<T> Linq<T>() where T : class
		{
			return Set<T>();
		}
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			
			modelBuilder.Configurations.Add(new ProdutoMap());
			modelBuilder.Configurations.Add(new DepartamentoMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}