namespace Modulo1.Web.Filters
{
	using System.Diagnostics;
	using System.Web.Mvc;

	public class ExemploFilterAttribute : FilterAttribute, IActionFilter
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