namespace Modulo6.Web.Models
{
	using System.ComponentModel.DataAnnotations;

	public class LoginViewModel
	{
		[Required(ErrorMessage = "O usuário é obrigatório")]
		public string Usuario { get; set; }

		[Required(ErrorMessage = "A senha é obrigatória")]
		public string Senha { get; set; }
	}
}