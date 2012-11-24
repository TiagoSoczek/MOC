using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo7.Web
{
	using System.Threading;

	public partial class Loginaspx : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			if (!Page.IsValid)
			{
				return;
			}

			// ReaderWriterLockSlim

			string usuario = txtUsuario.Text;

			AdicionarUsuarioNaApp(usuario);

			Session["USUARIO"] = usuario;
		}

		private void AdicionarUsuarioNaApp(string usuario)
		{
			Application.Lock();

			try
			{
				string chave = "USUARIOS";

				var listaUsuarios = Application[chave] as List<string>;

				if (listaUsuarios == null)
				{
					listaUsuarios = new List<string>();

					Application[chave] = listaUsuarios;
				}

				listaUsuarios.Add(usuario);
			}
			finally
			{
				Application.UnLock();
			}
		}
	}
}