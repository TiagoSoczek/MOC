using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo8.Model.Services
{
	public class ProdutoService : IDisposable
	{
		public List<Produto> PesquisarProdutos(string termo)
		{
			Modulo8Entities objectContext = new Modulo8Entities();

			if (string.IsNullOrWhiteSpace(termo))
			{
				return objectContext.Produto.ToList();
			}
			
			return objectContext.Produto.
				Where(p => p.Nome.Contains(termo)).ToList();
		}

		public Produto Salvar(Produto produto)
		{
			Modulo8Entities objectContext = new Modulo8Entities();

			objectContext.Produto.Add(produto);
			objectContext.SaveChanges();

			return produto;
		}

		public void RemoverTodos()
		{
			// TODO: Encontrar forma de deletar sem consultar
			Modulo8Entities objectContext = new Modulo8Entities();

			List<Produto> produtos = objectContext.Produto.ToList();

			foreach (var produto in produtos)
			{
				objectContext.Produto.Remove(produto);
			}

			objectContext.SaveChanges();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
