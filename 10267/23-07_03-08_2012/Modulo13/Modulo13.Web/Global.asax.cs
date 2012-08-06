using System;

namespace Modulo13.Web
{
	using System.Security.Principal;
	using System.Threading;
	using System.Web;
	using System.Web.Security;

	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			Application["ONLINE"] = 0;
		}

		protected void Session_Start(object sender, EventArgs e)
		{
			Application.Lock();

			int online = (int)Application["ONLINE"];

			online++;

			Application["ONLINE"] = online;

			Application.UnLock();
		}

		protected void Session_End(object sender, EventArgs e)
		{
			Application.Lock();

			int online = (int)Application["ONLINE"];

			online--;

			Application["ONLINE"] = online;

			Application.UnLock();
		}
	}
}