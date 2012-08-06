using System;
using Wise.Negocio;

namespace Wise.Web
{

    public partial class Default : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                lblNome.Text = "Primeira Chamada";
            }
            else
            {
                lblNome.Text = "Chamada Postback";
            }

		    btnOK.Click += btnOK_Click;
            btnExibirEsconder.Click += btnExibirEsconder_Click;
		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
		    int qtdeProdutos =  int.Parse(txtNome.Text);

            CalculoPedido calculo = new CalculoPedido(qtdeProdutos);

    	    int total = calculo.CalcularTotal();

		    lblNome.Text = "Total: " + total + "(" + calculo +  ")";
		}

        protected void btnExibirEsconder_Click(object sender, EventArgs e)
        {
            lblNome.Visible = !lblNome.Visible;

            string labelBotao = lblNome.Visible ? "Esconder" : "Exibir";

            btnExibirEsconder.Text = labelBotao;
       }
	}
}