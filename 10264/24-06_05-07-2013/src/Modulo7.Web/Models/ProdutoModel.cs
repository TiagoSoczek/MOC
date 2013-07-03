namespace Modulo7.Web.Models
{
	using System;
	using System.ComponentModel.DataAnnotations;

	public class ProdutoModel
	{
		// [Required(ErrorMessage = "O nome é obrigatório")]
		[Required(ErrorMessageResourceName = "ErroNomeObrigatorio", ErrorMessageResourceType = typeof(Mensagens))]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O preço é obrigatório. Campo: {0}")]
		[Range(0, 1000, ErrorMessage = "O preço deve ser entre 0 e 100. {0}, {1}, {2}")]
		public double Preco { get; set; }

		[Required(ErrorMessage = "A data de cadastro é obrigatória")]
		public DateTime DataCadastro { get; set; }
	}
}