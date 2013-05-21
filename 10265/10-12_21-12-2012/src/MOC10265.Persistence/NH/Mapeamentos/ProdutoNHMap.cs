namespace MOC10265.Persistence.NH.Mapeamentos
{
	using Model;
	using NHibernate.Mapping.ByCode;
	using NHibernate.Mapping.ByCode.Conformist;
	using NHibernate.Type;

	public class ProdutoNHMap : ClassMapping<Produto>
	{
		public ProdutoNHMap()
		{
			Id(p => p.Id, g => g.Generator(Generators.Identity));
			// Timestamp do SQLServer não suportado
			// Version(p => p.Versao, v => v.Generated(VersionGeneration.Always));

			Property(p => p.Nome, m =>
				                      {
					                      m.Length(100);
					                      m.NotNullable(true);
				                      });

			Property(p => p.Quantidade, m => m.NotNullable(true));
			Property(p => p.Preco, m => m.NotNullable(true));
			Property(p => p.Ativo, m => m.NotNullable(true));
			Property(p => p.DataPrimeiraCompra, m => m.NotNullable(false));

			List(p => p.Departamentos, c =>
				                           {
					                           c.Cascade(Cascade.All);
					                           c.Table("ProdutoDepartamento");
											   c.Key(k =>
												         {
													         k.Column("ProdutoId");
												         });
				                           }, r => r.ManyToMany(m => m.Column("DepartamentoId")));
		}
	}
}