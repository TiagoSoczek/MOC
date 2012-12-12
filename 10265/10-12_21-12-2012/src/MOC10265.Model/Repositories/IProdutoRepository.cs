namespace MOC10265.Model.Repositories
{
	using System.Collections.Generic;

	public interface IProdutoRepository
	{
		List<Produto> ObterTodos();
	}
}