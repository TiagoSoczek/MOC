namespace Modulo16.Web.Controllers
{
    using System.Web.Mvc;

    public class ProdutoController : Controller
    {
         public ActionResult Index(int id)
         {
             ViewData["id"] = id;

             return View();
         }
    }
}