using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo7.Web
{
	using System.Drawing;
	using System.Globalization;
	using System.Threading;

	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			lblDataAtual.Text = string.Format("{0:d} | {1}",
								   DateTime.Now, 123.45);

			/*lblDataAtual.Text = DateTime.Now.ToString();
			lblDataAtual.Text += " - ";
			lblDataAtual.Text += 123.45.ToString();*/
		}

		protected void btnCor_Click(object sender, EventArgs e)
		{
			btnCor.BackColor = Color.Red;
		}

		protected void btnEnviarDados_Click(object sender, EventArgs e)
		{

		}
	}
}