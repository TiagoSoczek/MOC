namespace MOC10265.Persistence.EF.Mapeamentos
{
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Model;

	public class DepartamentoMap : EntityTypeConfiguration<Departamento>
	{
		public DepartamentoMap()
		{
			ToTable("Departamento");

			HasKey(d => d.Id);
			Property(d => d.Id).
				HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			Property(d => d.Nome);
		}
	}
}