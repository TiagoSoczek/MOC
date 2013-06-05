namespace ExemploNH.Core.Repositorios
{
	using System.Collections.Generic;
	using Model;
	using NHibernate;

	public class ProdutoRepository : RepositoryBase<Produto>
	{
		public ProdutoRepository(ISessionFactory sessionFactory) : base(sessionFactory)
		{
		}

		public IList<Produto> PesquisarProdutos(string termos)
		{
			return Query().Where(p => p.Nome.Contains(termos)).List();
		}
	}
}