using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo13.Web
{
	using System.Web.Security;

	public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* bool? logado = (bool?)Session["LOGADO"];

            if (!logado.GetValueOrDefault())
            {
                Response.Redirect("~/");
            }*/
        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Abandon();
			FormsAuthentication.SignOut();

            Response.Redirect("~/");
        }
    }
}