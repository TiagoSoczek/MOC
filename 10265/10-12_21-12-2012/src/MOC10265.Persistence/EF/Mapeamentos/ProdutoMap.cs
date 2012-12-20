namespace MOC10265.Persistence.EF.Mapeamentos
{
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Model;

	public class ProdutoMap : EntityTypeConfiguration<Produto>
	{
		public ProdutoMap()
		{
			ToTable("Produto");

			HasKey(p => p.Id);
			Property(p => p.Id).
				HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			
			Property(p => p.Versao).
				HasColumnType("timestamp").
				HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).
				IsConcurrencyToken();

			Property(p => p.Nome).HasMaxLength(100).IsRequired();
			Property(p => p.Quantidade).IsRequired();
			Property(p => p.Preco).IsRequired();
			Property(p => p.Ativo).IsRequired();
			Property(p => p.DataPrimeiraCompra).IsOptional();

			/*HasOptional(p => p.Departamento).
				WithMany().
				Map(k => k.MapKey("DepartamentoId"));*/

			HasMany(p => p.Departamentos).
				WithMany().
				Map(m =>
					    {
						    m.ToTable("ProdutoDepartamento");
						    m.MapLeftKey("ProdutoId");
						    m.MapRightKey("DepartamentoId");
					    });
		}
	}
}