namespace MOC10265.Model.Repositories
{
	using System.Collections.Generic;

	public interface IProdutoRepository
	{
		List<Produto> ObterTodos();
		Produto ObterPorId(int id);
		void Remover(int id);
		Produto Atualizar(Produto produto);
		Produto Inserir(Produto produto);
		List<Produto> PesquisarProdutos(string termo, int qtdeRegistros);
	}
}