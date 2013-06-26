namespace Modulo1.Web
{
	using System.Web.Mvc;
	using Binders;
	using Models;

	public class BinderConfig
	{
		public static void RegisterBinders(ModelBinderDictionary binders)
		{
			binders.Add(typeof(EntidadeExterna), new EntidadeExternaBinder());
		}
	}
}