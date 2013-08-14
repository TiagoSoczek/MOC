namespace Modulo9.Core.Services
{
	using System.Collections.Generic;
	using Repositories;

	public class CatalogoService
	{
		private ProdutoRepository _produtoRepository;

		public CatalogoService()
		{
			_produtoRepository = new ProdutoRepository();
		}

		public List<Produto> ObterProdutos(string termos)
		{
			if (string.IsNullOrWhiteSpace(termos))
			{
				return _produtoRepository.ObterTodos();
			}

			return _produtoRepository.Pesquisar(termos);
		}

		public void SalvarProduto(Produto produto)
		{
			// TODO: Validar

			_produtoRepository.Salvar(produto);
		}

		public Produto ObterProdutoPorId(int id)
		{
			return _produtoRepository.ObterPorId(id);
		}
	}
}