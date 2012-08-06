using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo11.Web
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));

            lblAgora.Text = DateTime.Now.ToString();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            lblAgora.Text = "TIMER: " + DateTime.Now.ToString();
        }
    }
}