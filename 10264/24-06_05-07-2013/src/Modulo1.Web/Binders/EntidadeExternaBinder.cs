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
				string[] valores = item.Split('@');

				var entidadeExterna = new EntidadeExterna();

				entidadeExterna.Id = int.Parse(valores[0]);
				entidadeExterna.Sistema = valores[1];

				return entidadeExterna;
			}

			return null;
		}
	}
}