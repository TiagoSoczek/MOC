namespace Modulo5.Web.Helpers
{
	using System.Web;
	using System.Web.Mvc;

	public static class HtmlHelperExtensions
	{
		public static IHtmlString SubmitButton(this HtmlHelper helper, string texto)
		{
			return helper.Raw(string.Format("<input type='submit' value='{0}' />", texto));
		}
	}
}