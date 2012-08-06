using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo13.Web.Supervisor
{
	using System.Web.Security;

	public partial class Defaultaspx : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSair_Click(object sender, EventArgs e)
		{
			Session.Abandon();
			FormsAuthentication.SignOut();

			Response.Redirect("~/");
		}
	}
}