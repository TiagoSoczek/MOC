namespace Modulo9.Core.Repositories
{
	using System.Collections.Generic;
	using System.Data;
	using System.Diagnostics;
	using System.Linq;

	public class ProdutoRepository
	{
		public List<Produto> ObterTodos()
		{
			using (var db = ObterContexto())
			{
				return db.Produto.ToList();
			}
		}

		private Wise10267Entities ObterContexto()
		{
			return new Wise10267Entities();
		}

		public List<Produto> Pesquisar(string termos)
		{
			using (var db = ObterContexto())
			{
				var query = db.Produto.
					Where(p => p.Nome.Contains(termos)).
					OrderBy(p => p.Nome).
					ThenByDescending(p => p.Id).
					Take(5);

				// EF 4
				/*var sql = ((ObjectQuery) query).ToTraceString();

				Trace.WriteLine(sql);*/

				Trace.WriteLine(query.ToString());

				return query.ToList();
			}
		}

		public void Salvar(Produto produto)
		{
			using (var db = ObterContexto())
			{
				if (produto.Id == 0)
				{
					db.Produto.Add(produto);
				}
				else
				{
					db.Produto.Attach(produto);

					// EF 4.4
					db.Entry(produto).State = EntityState.Modified;

					// EF 4
					// db.ObjectStateManager.ChangeObjectState(produto, EntityState.Modified);
				}

				db.SaveChanges();
			}
		}

		public Produto ObterPorId(int id)
		{
			using (var db = ObterContexto())
			{
				// return db.Produto.Find(id);
				return db.Produto.FirstOrDefault(p => p.Id == id);
			}
		}
	}
}