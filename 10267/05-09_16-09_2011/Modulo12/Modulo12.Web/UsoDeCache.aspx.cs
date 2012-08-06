using System;

namespace Modulo12.Web
{
    public partial class UsoDeCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAgora.Text = DateTime.Now.ToString();
        }
    }
}