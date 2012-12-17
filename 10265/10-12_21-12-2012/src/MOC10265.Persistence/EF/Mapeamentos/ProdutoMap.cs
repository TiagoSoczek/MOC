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
				HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).
				IsConcurrencyToken();

			Property(p => p.Nome);
			Property(p => p.Quantidade);
			Property(p => p.Preco);
			Property(p => p.Ativo);
			Property(p => p.DataPrimeiraCompra);
		}
	}
}