namespace ExemploNH.Core.Servicos
{
	using System;
	using System.Collections.Generic;
	using Model;
	using Repositorios;

	public class CatalogoService
	{
		private readonly ProdutoRepository _produtoRepository;

		public CatalogoService(ProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		public Produto SalvarProduto(Produto produto)
		{
			if (produto.Id == 0)
			{
				produto.DataCadastro = DateTime.Now;
			}

			_produtoRepository.Salvar(produto);

			return produto;
		}

		public IList<Produto> PesquisarProdutos(string termos = null)
		{
			if (string.IsNullOrWhiteSpace(termos))
			{
				return _produtoRepository.ObterTodos();
			}

			return _produtoRepository.PesquisarProdutos(termos);
		}

		public Produto ObterProdutoPorId(int id)
		{
			var produto = _produtoRepository.ObterPorId(id);

			if (produto == null)
			{
				throw new Exception(string.Format("Não existe produto com Id {0}", id));
			}

			return produto;
		}

		public void ExcluirProduto(int id)
		{
			var produto = ObterProdutoPorId(id);

			_produtoRepository.Excluir(produto);
		}
	}
}