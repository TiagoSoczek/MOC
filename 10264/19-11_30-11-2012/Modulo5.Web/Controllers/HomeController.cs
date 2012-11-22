using System.Web.Mvc;
using Modulo5.Web.Models;

namespace Modulo5.Web.Controllers
{
	public class HomeController : Controller
    {
        public ActionResult Index()
        {
			ProdutoModel model = new ProdutoModel();

	        PopularProdutos(model);

            return View(model);
        }

		private void PopularProdutos(ProdutoModel model)
		{
			for (int i = 0; i < 100; i++)
			{
				var produto = new Produto();
				produto.Nome = "Iphone " + i;
				produto.Preco = 1999.99;
				produto.Status = StatusProduto.Ativo;

				model.Produtos.Add(produto);
			}
		}
    }
}
