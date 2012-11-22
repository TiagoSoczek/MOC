namespace Modulo4.Web2.Filters
{
	using System.Diagnostics;
	using System.Web.Mvc;

	public class ExemploAttribute : FilterAttribute, System.Web.Mvc.IActionFilter
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

	public class Exemplo2Attribute : FilterAttribute, System.Web.Mvc.IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			Trace.WriteLine("Antes2...");
		}

		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			Trace.WriteLine("...2Depois");
		}
	}

	public class ExemploMalandroAttribute : FilterAttribute, System.Web.Mvc.IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			Trace.WriteLine("AntesMalandro...");
		}

		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			Trace.WriteLine("...MalandroDepois");
		}
	}
}