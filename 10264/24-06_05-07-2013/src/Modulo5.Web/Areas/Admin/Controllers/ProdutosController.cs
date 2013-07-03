namespace Modulo5.Web.Areas.Admin.Controllers
{
	using System.Web.Mvc;
	using Core.Model;
	using Models;

	public class ProdutosController : SecureController
	{
		private readonly CatalogoService _catalogoService;

		public ProdutosController()
		{
			_catalogoService = new CatalogoService();
		}

		public ActionResult Index(ProdutosModel model)
		{
			model.Produtos = _catalogoService.ObterPorPrecoMinimo(model.PrecoMinimo);

			return View(model);
		}
	}
}