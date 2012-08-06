using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wise.Web
{
    using System.Drawing;

    public partial class Imagens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            img1.Src = "px.png";
            img1.Border = 1;
            
            img2.ImageUrl = "px.png";

            img2.BorderColor = Color.Red;
            img2.BorderWidth = 1;
            img2.BorderStyle = BorderStyle.Solid;
        }
    }
}