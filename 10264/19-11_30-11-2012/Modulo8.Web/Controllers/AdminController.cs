using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modulo8.Model.Services;

namespace Modulo8.Web.Controllers
{
	[Authorize(Roles = "ADMIN, SUPERVISOR")]
	public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

	    public ActionResult RemoverTodosProdutos()
	    {
		    var produtoService = new ProductService();

		    produtoService.RemoverTodos();

		    return RedirectToAction("Index", "Produtos");
	    }
    }
}
