using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Modulo15.Web
{
	using System.Configuration;
	using System.Diagnostics;
	using System.Threading;

	public static class Constantes
	{
		public const string AppUsuarios = "USUARIOS";
		public const string SessionDuracao = "DURACAO";
	}

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			// Use LocalDB for Entity Framework by default
			Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);

			LerConfig();

			AtualizarUsuarios(0);
		}

		private void LerConfig()
		{
			var facebookApiKey = ConfigurationManager.AppSettings["FACEBOOK_API_KEY"];
			var facebookSecretApiKey = ConfigurationManager.AppSettings["FACEBOOK_SECRET_KEY"];

			Trace.WriteLine("FACEBOOK_API_KEY:" + facebookApiKey);
			Trace.WriteLine("FACEBOOK_SECRET_KEY:" + facebookSecretApiKey);
		}

		protected void Application_End()
		{
		}

		protected void Session_Start()
		{
			AtualizarUsuarios(1);

			Session[Constantes.SessionDuracao] = DateTime.Now;
		}

		protected void Session_End()
		{
			AtualizarUsuarios(-1);
		}

		private void AtualizarUsuarios(int diff)
		{
			try
			{
				/*lock (_objetoLock)
				{
					
				}*/
				// ReaderWriterLockSlim

				Application.Lock();

				int usuarios;

				var appUsuarios = Application[Constantes.AppUsuarios];

				if (appUsuarios == null)
				{
					usuarios = 0;
				}
				else
				{
					usuarios = (int)appUsuarios;
				}

				usuarios += diff;

				Application[Constantes.AppUsuarios] = usuarios;
			}
			finally
			{
				Application.UnLock();
			}
		}
	}
}