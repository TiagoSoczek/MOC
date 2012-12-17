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
				return contexto.Produto.ToList();
			}
		}

		public Produto ObterPorId(int id)
		{
			using (var contexto = ObterContexto())
			{
				return contexto.Produto.
					FirstOrDefault(p => p.Id == id);
			}
		}

		public void Remover(int id)
		{
			using (var contexto = ObterContexto())
			{
				// TODO: Verificar forma mais eficiente

				var produto = contexto.Produto.
							FirstOrDefault(p => p.Id == id);

				contexto.Produto.Remove(produto);

				contexto.SaveChanges();
			}
		}

		public Produto Atualizar(Produto produto)
		{
			using (var contexto = ObterContexto())
			{
				contexto.Produto.Add(produto);

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