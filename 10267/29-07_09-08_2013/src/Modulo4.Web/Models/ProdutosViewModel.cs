namespace Modulo4.Web.Models
{
	using System;
	using System.Collections.Generic;
	using Core;

	public class ProdutosViewModel
	{
		public DateTime Agora { get; set; }
		public double Preco { get; set; }
		public List<Produto> Produtos { get; set; }
	}
}