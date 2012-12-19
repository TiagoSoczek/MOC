namespace MOC10265.Persistence.EF
{
	using System.Collections.Generic;
	using System.Linq;
	using Model;
	using Model.Repositories;

	public class ProdutoEFRepository : IProdutoRepository
	{
		public List<Produto> ObterTodos()
		{
			using (var contexto = ObterContexto())
			{
				return contexto.Linq<Produto>().
					Include("Departamento").
					ToList();
			}
		}

		public Produto ObterPorId(int id)
		{
			using (var contexto = ObterContexto())
			{
				return contexto.Linq<Produto>().
					Include("Departamento").
					FirstOrDefault(p => p.Id == id);
			}
		}

		public void Remover(int id)
		{
			using (var contexto = ObterContexto())
			{
				// TODO: Verificar forma mais eficiente

				var produto = contexto.Linq<Produto>().
							FirstOrDefault(p => p.Id == id);

				contexto.Linq<Produto>().Remove(produto);

				contexto.SaveChanges();
			}
		}

		public Produto Atualizar(Produto produto)
		{
			using (var contexto = ObterContexto())
			{
				// Desabilitar o ChangeTracking
				// contexto.Configuration.AutoDetectChangesEnabled = false;

				if (produto.Departamento != null && produto.Departamento.Id > 0)
				{
					contexto.Linq<Departamento>().Attach(produto.Departamento);
				}
				
				contexto.Linq<Produto>().Add(produto);

				contexto.SaveChanges();

				return produto;
			}
		}

		public Produto Inserir(Produto produto)
		{
			return Atualizar(produto);
		}

		private CatalogoContextoDb ObterContexto()
		{
			return new CatalogoContextoDb();
		}
	}
}