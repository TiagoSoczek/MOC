namespace Modulo15.Web.Controllers
{
	using System.Web.Mvc;

	public class CacheController : Controller
	{
		[OutputCache(Duration = 10, VaryByParam = "empresa")]
		public ActionResult Index()
		{
			return View();
		}
	}
}