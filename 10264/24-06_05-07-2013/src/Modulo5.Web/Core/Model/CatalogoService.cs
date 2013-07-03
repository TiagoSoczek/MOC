namespace Modulo5.Web.Core.Model
{
	using System.Collections.Generic;
	using System.Linq;
	using Areas.Admin.Models;
	using Repositories;

	public class CatalogoService
	{
		private readonly ProdutoRepository _produtoRepository;

		public CatalogoService()
		{
			_produtoRepository = new ProdutoRepository();
		}

		public List<Produto> ObterPorPrecoMinimo(double? precoMinimo)
		{
			List<Produto> produtos = _produtoRepository.ObterTodos();

			if (precoMinimo.HasValue)
			{
				//List<Produto> produtos = model.Produtos.Filtrar();
				produtos = produtos.
					Where(p => p.Preco >= precoMinimo).
					ToList();
			}

			return produtos;
		}
	}
}