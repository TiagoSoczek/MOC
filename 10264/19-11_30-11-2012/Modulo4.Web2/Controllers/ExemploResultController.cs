using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modulo4.Web2.Controllers
{
    public class ExemploResultController : Controller
    {
        //
        // GET: /ExemploResult/

		public ActionResult Index()
		{
			return Content(@"<conteudo>Exemplo 
							de Conteúdo</conteudo>",
				"text/xml");
		}

		public ActionResult Arquivo()
		{
			var caminho = Server.MapPath("~/bin/TREM_DOMINGO.png");

			return File(caminho, "image/png");
		}

    }
}
