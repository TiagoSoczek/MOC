namespace ExemploNH.Core.Repositorios
{
	using System.Collections.Generic;
	using NHibernate;
	using NHibernate.Transform;
	
	public abstract class RepositoryBase<T> where T : class
	{
		// TODO: Tratar ciclo de vida da ISession

		private readonly ISessionFactory _sessionFactory;

		protected RepositoryBase(ISessionFactory sessionFactory)
		{
			_sessionFactory = sessionFactory;
		}

		protected ISessionFactory SessionFactory
		{
			get { return _sessionFactory; }
		}

		public virtual IList<T> ObterTodos()
		{
			using (var session = _sessionFactory.OpenSession())
			{
				return session.CreateCriteria<T>().SetResultTransformer(Transformers.DistinctRootEntity).List<T>();
			}
		}

		public virtual T Salvar(T entidade)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				session.SaveOrUpdate(entidade);
				session.Flush();

				return entidade;
			}
		}

		public virtual void Excluir(T entidade)
		{
			if (entidade == null)
			{
				return;
			}
			using (var session = _sessionFactory.OpenSession())
			{
				session.Delete(entidade);
				session.Flush();
			}
		}

		public virtual void Excluir(int id)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				var entity = session.Load<T>(id);

				Excluir((T) entity);
			}
		}

		public virtual T ObterPorId(int id)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				var entity = session.Load<T>(id);

				return entity;
			}
		}

		protected IQueryOver<T, T> Query()
		{
			// TODO: Tratar ciclo de vida da ISession
			var session = _sessionFactory.OpenSession();
			
			return session.QueryOver<T>();
		}

		protected IQueryOver<R, R> Query<R>() where R : class
		{
			// TODO: Tratar ciclo de vida da ISession
			var session = _sessionFactory.OpenSession();

			return session.QueryOver<R>();
		}
	}
}