namespace Modulo14.Web
{
    using System;
    using System.Configuration;

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string qtdeTentativas = ConfigurationManager.AppSettings["QtdeTentativas"];

            int qtdeTentativasNumero = int.Parse(qtdeTentativas);

            lblConfig.Text = qtdeTentativasNumero.ToString();
        }
    }
}