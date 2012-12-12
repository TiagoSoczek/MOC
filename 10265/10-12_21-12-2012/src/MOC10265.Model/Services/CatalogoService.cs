namespace MOC10265.Model.Services
{
	using System.Collections.Generic;
	using Repositories;

	public class CatalogoService
	{
		private readonly IProdutoRepository _produtoRepository;

		public CatalogoService(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		public List<Produto> ObterTodosProdutos()
		{
			return _produtoRepository.ObterTodos();
		}
	}
}