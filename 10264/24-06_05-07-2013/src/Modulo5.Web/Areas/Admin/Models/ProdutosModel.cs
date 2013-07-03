namespace Modulo5.Web.Areas.Admin.Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class ProdutosModel
	{
		public ProdutosModel()
		{
			Produtos = new List<Produto>();
		}

		public List<Produto> Produtos { get; set; }
		public double? PrecoMinimo { get; set; }

		public TimeSpan ObterDiff(Produto p)
		{
			return (p.DataCadastro - DateTime.Now).Duration();
		}
	}
}