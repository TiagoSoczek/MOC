namespace ExemploADO.Web.Controllers
{
	using System.Web.Mvc;
	using Core.Repositories;
	using Core.Services;
	using Models;

	public class CatalogoController : Controller
	{
		private CatalogoService _catalogoService;

		/*public CatalogoController(CatalogoService catalogoService)
		{
			_catalogoService = catalogoService;
		}*/

		public CatalogoController()
		{
			// TODO: Utilizar injeção de dependencias

			// ICarroRepository carroRepository = new CarroRepository();
			ICarroRepository carroRepository = new CarroDapperRepository();
			// IModeloRepository modeloRepository = new ModeloRepository();
			// IModeloRepository modeloRepository = new ModeloRepository();
			IModeloRepository modeloRepository = new ModeloDapperRepository();

			_catalogoService = new CatalogoService(carroRepository, modeloRepository);
		}

		public ActionResult Index()
		{
			CatalogoModel model = new CatalogoModel();

			model.Modelos = _catalogoService.ObterTodosModelos();

			return View(model);
		}

		public ActionResult PorMarca(CatalogoModel model)
		{
			model.Carros = _catalogoService.ObterCarrosPorMarca(model.Marca);

			model.Modelos = _catalogoService.ObterTodosModelos();

			return View("Index", model);
		}
	}
}