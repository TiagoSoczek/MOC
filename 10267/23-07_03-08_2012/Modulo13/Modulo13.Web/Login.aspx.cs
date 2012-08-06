using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo13.Web
{
	using System.Web.Security;

	public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int online = (int)Application["ONLINE"];

            lblUsuariosOnline.Text = online + " usuários online";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
			string usuario = txtUsuario.Text;
			string senha = txtSenha.Text;

			bool usuarioValido = Membership.ValidateUser(usuario, senha);

			if (usuarioValido)
			{
				FormsAuthentication.SetAuthCookie(usuario, false);
				FormsAuthentication.RedirectFromLoginPage(usuario, false);
			}
			else
			{
				cvSenha.IsValid = false;
			}
        }
    }
}