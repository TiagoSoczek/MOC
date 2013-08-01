namespace Modulo4.Core
{
	using System.Collections.Generic;
	using System.Linq;

	public class ProdutoService
	{
		private static List<Produto> _produtos = new List<Produto>();
		
		public void Salvar(string nome, double preco)
		{
			Produto p = new Produto();

			p.Nome = nome;
			p.Preco = preco;

			_produtos.Add(p);
		}

		public List<Produto> ObterTodos()
		{
			return _produtos.ToList();
		}
	}
}