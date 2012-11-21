using System.Web.Mvc;

namespace Modulo1.MVC.Controllers
{
	using Models;

	public class LoginController : Controller
    {
        //
        // GET: /Login/

		public ActionResult Inicial(string nome, bool? xml)
		{
			var modelo = new ApresentacaoModel();

			modelo.Nome = nome;

			if (string.IsNullOrEmpty(nome))
			{
				modelo.Resultado = "Digite um nome!";
			}
			else
			{
				modelo.Resultado = "Olá " + nome;
			}

			var view = "Index";

			if (xml.GetValueOrDefault())
			{
				view = "IndexXml";
			}

            return View(view, modelo);
        }
    }
}
