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

		public DbSet<Produto> Produto
		{
			get
			{
				return Set<Produto>();
			}
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			
			modelBuilder.Configurations.Add(new ProdutoMap());

			base.OnModelCreating(modelBuilder);
		}
	}
}