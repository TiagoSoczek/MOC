namespace ExemploNH.Web.Models
{
	using System.Collections.Generic;
	using Model;

	public class ProdutosModel
	{
		public ProdutosModel()
		{
			Produtos = new List<Produto>();
		}

		public IList<Produto> Produtos { get; set; }
	}
}