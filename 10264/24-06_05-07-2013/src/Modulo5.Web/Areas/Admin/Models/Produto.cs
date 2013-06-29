namespace Modulo5.Web.Areas.Admin.Models
{
	using System;

	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public double Preco { get; set; }
		public int Quantidade { get; set; }
		public DateTime DataCadastro { get; set; }
	}
}