﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Modulo12.Web
{
    public partial class Contador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
            Session.Abandon();
        }
    }
}