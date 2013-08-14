namespace Modulo9.Web.Controllers
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Web.Mvc;
	using Core;
	using Core.Services;

	public class ProdutoController : Controller
	{
		private CatalogoService _catalogoService;

		public ProdutoController()
		{
			_catalogoService = new CatalogoService();
		}

		public ActionResult Index(ProdutosViewModel vm)
		{
			vm.Produtos = _catalogoService.ObterProdutos(vm.Termos);

			return View(vm);
		}

		public ActionResult Novo()
		{
			var vm = new GestaoProdutoViewModel();

			return View("Form", vm);
		}

		public ActionResult Salvar(GestaoProdutoViewModel vm)
		{
			if (!ModelState.IsValid)
			{
				return View("Form", vm);
			}

			var produto = vm.ObterProduto();

			_catalogoService.SalvarProduto(produto);

			return RedirectToAction("Index");
		}

		public ActionResult Editar(int id)
		{
			var produto = _catalogoService.ObterProdutoPorId(id);

			var vm = new GestaoProdutoViewModel();

			vm.Atualizar(produto);

			return View("Form", vm);
		}
	}

	public class GestaoProdutoViewModel
	{
		public int Id { get; set; }
		
		[Required]
		public string Nome { get; set; }
		
		[Required]
		public decimal Preco { get; set; }
		
		[Required]
		public bool Ativo { get; set; }

		public Produto ObterProduto()
		{
			var produto = new Produto
			{
				Id = Id,
				Nome = Nome,
				Preco = Preco,
				Ativo = Ativo
			};

			return produto;
		}

		public void Atualizar(Produto produto)
		{
			Id = produto.Id;
			Nome = produto.Nome;
			Preco = produto.Preco;
			Ativo = produto.Ativo;
		}
	}

	public class ProdutosViewModel
	{
		public string Termos { get; set; }
		public List<Produto> Produtos { get; set; }
	}
}