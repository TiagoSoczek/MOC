using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo13.Web
{
	using System.Globalization;
	using System.Threading;

	public partial class DataAtual : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			//var cultura = new CultureInfo(Request.QueryString["LANG"]);

			//Thread.CurrentThread.CurrentCulture = cultura;
			//Thread.CurrentThread.CurrentUICulture = cultura;

            lblDataAtual.Text = DateTime.Now.ToString();
        }
    }
}