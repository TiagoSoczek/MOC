using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo8.Model.Services
{
	public class ProductService : IDisposable
	{
		public List<Produto> PesquisarProdutos(string termo)
		{
			var objectContext = ObterContexto();

			if (string.IsNullOrWhiteSpace(termo))
			{
				return objectContext.Produto.ToList();
			}
			
			return objectContext.Produto.
				Where(p => p.Nome.Contains(termo)).ToList();
		}

		public Produto Salvar(Produto produto)
		{
			Modulo8Entities objectContext = ObterContexto();

			objectContext.Produto.Add(produto);
			objectContext.SaveChanges();

			return produto;
		}

		public void RemoverTodos()
		{
			// TODO: Encontrar forma de deletar sem consultar
			Modulo8Entities objectContext = ObterContexto();

			List<Produto> produtos = objectContext.Produto.ToList();

			foreach (var produto in produtos)
			{
				Remover(objectContext, produto);
			}

			objectContext.SaveChanges();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		private void Remover(Modulo8Entities objectContext, Produto produto)
		{
			objectContext.Produto.Remove(produto);
		}
		
		private Modulo8Entities ObterContexto()
		{
			Modulo8Entities objectContext = new Modulo8Entities();
			return objectContext;
		}
	}
}
