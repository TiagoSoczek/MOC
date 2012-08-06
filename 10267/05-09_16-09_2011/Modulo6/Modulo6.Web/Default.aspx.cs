using System;
using System.Diagnostics;

namespace Modulo6.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Page Load");
            
            Trace.Write("Page Load - Trace");
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!IsValid)
            {
                Trace.Warn("erros", "Tentativa de salvar usuário inválido");

                return;
            }

            Trace.Write("eventos", "Usuário salvo com sucesso");

            lblResultado.Text = txtEmail.Text + " salvo com sucesso";
        }

        protected void CustomValidator1_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            string senha = args.Value;

            if (senha.Length >= 5 && senha.Length <= 10)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}