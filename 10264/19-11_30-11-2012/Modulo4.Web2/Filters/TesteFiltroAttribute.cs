namespace Modulo4.Web2.Filters
{
	using System.Diagnostics;
	using System.Web.Mvc;

	public class TesteFiltroAttribute : FilterAttribute, System.Web.Mvc.IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			Trace.WriteLine("Antes...");
		}

		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			Trace.WriteLine("...Depois");
		}
	}
}