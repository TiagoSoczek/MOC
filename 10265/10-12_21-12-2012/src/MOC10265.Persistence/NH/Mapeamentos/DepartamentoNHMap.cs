namespace MOC10265.Persistence.NH.Mapeamentos
{
	using Model;
	using NHibernate.Mapping.ByCode;
	using NHibernate.Mapping.ByCode.Conformist;

	public class DepartamentoNHMap : ClassMapping<Departamento>
	{
		public DepartamentoNHMap()
		{
			Id(d => d.Id, g => g.Generator(Generators.Identity));
			
			Property(d => d.Nome, m =>
				                      {
					                      m.Length(100);
										  m.NotNullable(true);
				                      });
		}
	}
}