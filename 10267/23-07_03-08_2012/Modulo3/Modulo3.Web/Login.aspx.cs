namespace Modulo3.Web
{
    using System;
    using Modulo3.Core;

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               string login = Request.QueryString["login"];

               txtLogin.Text = login;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string login;
            string senha;

            login = txtLogin.Text;
            senha = txtSenha.Text;

            Autenticacao auth = new Autenticacao();

            bool resultado = auth.Autenticar(login, senha);

            if (resultado == true)
            {
                Response.Redirect("~/default.aspx");
            }
            else
            {
                lblResultado.Text = "Nome ou senha incorretos";
            }
        }
    }
}