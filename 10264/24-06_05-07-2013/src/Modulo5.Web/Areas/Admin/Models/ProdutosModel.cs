namespace Modulo5.Web.Areas.Admin.Models
{
	using System.Collections.Generic;

	public class ProdutosModel
	{
		public ProdutosModel()
		{
			Produtos = new List<Produto>();
		}

		public List<Produto> Produtos { get; set; }
		public double? PrecoMinimo { get; set; }
	}
}