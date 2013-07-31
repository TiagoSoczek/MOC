using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo1.Web
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnOk_Click(object sender, EventArgs e)
		{
			string usuario = txtUsuario.Text;
			string senha = txtSenha.Text;

			if (usuario == "tiago" && senha == "abc123")
			{
				lblMensagem.Text = "Login efetuado com sucesso";
				lblMensagem.CssClass = "label-success";
			}
			else
			{
				lblMensagem.Text = "Usuário ou senha inválidos";
				lblMensagem.CssClass = "label-danger";
			}
		}
	}
}