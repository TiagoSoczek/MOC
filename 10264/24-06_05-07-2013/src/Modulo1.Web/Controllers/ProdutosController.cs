namespace Modulo1.Web.Controllers
{
	using System.Web.Mvc;
	using Models;

	public class ProdutosController : Controller
	{
		public ActionResult Index(int? id, bool? json)
		{
			if (!id.HasValue)
			{
				string msg = "Você deve informar um Id";

				if (json.GetValueOrDefault())
				{
					return Json(new {mensagem = msg}, JsonRequestBehavior.AllowGet);
				}
				
				return Content(msg);
			}

			ProdutosViewModel model = new ProdutosViewModel();

			model.Id = id.Value;

			ViewResult retorno = View(model);

			return retorno;
		}

		public ActionResult Tratar(EntidadeExterna entidadeExterna)
		{
			return Content(entidadeExterna.ToString());
		}

		public ActionResult Salvar(Produto p)
		{
			return Content(p.Nome);
		}
	}
}