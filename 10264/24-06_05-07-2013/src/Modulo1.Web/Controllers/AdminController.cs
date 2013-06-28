namespace Modulo1.Web.Controllers
{
	using System.Diagnostics;
	using System.Web.Mvc;
	using Filters;

	public class AdminController : SecureController
	{
		[ExemploFilter]
		[AllowAnonymous]
		public ActionResult Index()
		{
			Trace.WriteLine("Durante!");
			return Content("Area Restrita");
		}

		public ActionResult RecriarBase()
		{
			return Content("Base Recriada");
		}
	}
}