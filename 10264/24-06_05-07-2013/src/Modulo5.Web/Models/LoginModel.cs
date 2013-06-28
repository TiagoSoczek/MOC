namespace Modulo5.Web.Models
{
	public class LoginModel
	{
		public string Usuario { get; set; }
		public string Senha { get; set; }
		public bool Erro { get; set; }
		public string Mensagem { get; set; }
		public string ReturnUrl { get; set; }
	}
}