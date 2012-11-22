using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modulo5.Web.Models
{
	public class ProdutoModel
	{
		public ProdutoModel()
		{
			Produtos = new List<Produto>();
		}

		public List<Produto> Produtos { get; set; }
	}

	public enum StatusProduto
	{
		Desconhecido = 0,
		Ativo = 1,
		Descontinuado = 2
	}

	public class Produto
	{
		public string Nome { get; set; }
		public double Preco { get; set; }
		public StatusProduto Status { get; set; }
	}
}