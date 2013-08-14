using System.Web.Mvc;

namespace Modulo15.Web.Areas.Manager
{
	public class ManagerAreaRegistration : AreaRegistration
	{
		public override string AreaName
		{
			get
			{
				return "Manager";
			}
		}

		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
				"Manager_default",
				"Manager/{controller}/{action}/{id}",
				new { controller = "ManagerHome", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
