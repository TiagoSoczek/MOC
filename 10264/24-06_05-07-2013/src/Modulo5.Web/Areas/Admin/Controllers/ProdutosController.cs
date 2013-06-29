namespace Modulo5.Web.Areas.Admin.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web.Mvc;
	using Extensions;
	using Models;

	public class ProdutosController : SecureController
	{
		public ActionResult Index(ProdutosModel model)
		{
			model.Produtos = CarregarProdutos();

			if (model.PrecoMinimo.HasValue)
			{
				//List<Produto> produtos = model.Produtos.Filtrar();
				model.Produtos = model.Produtos.
					Where(p => p.Preco >= model.PrecoMinimo).
					ToList();
			}

			return View(model);
		}

		private List<Produto> CarregarProdutos()
		{
			List<Produto> produtos = new List<Produto>();
			var agora = DateTime.Now;
			Random rnd = new Random();

			for (int i = 0; i < rnd.Next(50, 100); i++)
			{
				Produto p = new Produto();

				p.Id = rnd.Next(i, 100);
				p.Nome = "Produto#" + rnd.Next(i, 1000);
				p.Preco = rnd.Next(1, 500);
				p.Quantidade = rnd.Next(i, 100);
				p.DataCadastro = agora.AddHours(-i);

				produtos.Add(p);
			}

			return produtos;
		}
	}
}