namespace MOC10265.Web.Models
{
	using System.Collections.Generic;
	using Model;

	public class ProdutoModel
	{
		public ProdutoModel()
		{
			Produtos = new List<Produto>();
		}

		public List<Produto> Produtos { get; set; } 
	}
}