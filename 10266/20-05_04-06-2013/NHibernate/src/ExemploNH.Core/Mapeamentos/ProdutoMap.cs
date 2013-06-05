namespace ExemploNH.Core.Mapeamentos
{
	using Model;
	using NHibernate.Mapping.ByCode;
	using NHibernate.Mapping.ByCode.Conformist;

	public class ProdutoMap : ClassMapping<Produto>
	{
		public ProdutoMap()
		{
			Lazy(false);

			Id(m => m.Id, m =>
			{
				m.Generator(Generators.Native);
				m.Column("ProdutoId");
			});

			Property(m => m.Nome);
			Property(m => m.Preco);
			Property(m => m.Quantidade);
			Property(m => m.DataCadastro);
		}
	}
}