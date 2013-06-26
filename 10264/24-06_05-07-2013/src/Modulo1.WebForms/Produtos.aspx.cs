namespace Modulo1.WebForms
{
	using System;
	using System.Drawing;
	using System.Web.UI;

	public partial class Produtos : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnSalvar_Click(object sender, EventArgs e)
		{
			lblResultado.Text = "Sucesso";
			lblResultado.ForeColor = Color.Green;
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			lblResultado.ForeColor = Color.Red;
		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			string path = Server.MapPath("Arquivo.bin");

			FileUpload1.SaveAs(path);
		}
	}
}