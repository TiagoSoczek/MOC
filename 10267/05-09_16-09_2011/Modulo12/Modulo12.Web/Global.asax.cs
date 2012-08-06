using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Modulo12.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Lock();

            try
            {
                Application["Visitantes"] = 0;
            }
            finally
            {
                Application.UnLock();
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();

            try
            {
                int totalVisitantes = (int)Application["Visitantes"];

                totalVisitantes++;

                Application["Visitantes"] = totalVisitantes;
            }
            finally
            {
                Application.UnLock();
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();

            try
            {
                int totalVisitantes = (int)Application["Visitantes"];

                totalVisitantes--;

                Application["Visitantes"] = totalVisitantes;
            }
            finally
            {
                Application.UnLock();
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}