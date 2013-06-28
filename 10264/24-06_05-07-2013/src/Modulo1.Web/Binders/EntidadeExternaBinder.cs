namespace Modulo1.Web.Binders
{
	using System.Web.Mvc;
	using Models;

	public class EntidadeExternaBinder : DefaultModelBinder
	{
		public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			ValueProviderResult value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

			foreach (string item in (string[]) value.RawValue)
			{
				var entidadeExterna = new EntidadeExterna(item);

				return entidadeExterna;
			}

			return null;
		}
	}
}