using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modulo8.Model;

namespace Modulo8.Web.Models
{

	public class PesquisaProdutosModel
	{
		public PesquisaProdutosModel()
		{
			Produtos = new List<Produto>();
		}

		public string Termo { get; set; }
		public List<Produto> Produtos { get; set; }
	}
}