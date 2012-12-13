namespace MOC10265.Web.Models
{
	using Model;

	public class EditarProdutoModel
	{
		public EditarProdutoModel()
		{
			Produto = new Produto();
		}

		public Produto Produto { get; set; }
	}
}