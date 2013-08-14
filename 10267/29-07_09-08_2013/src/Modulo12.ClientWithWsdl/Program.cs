using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo12.ClientWithWsdl
{
	using Catalogo;

	class Program
	{
		static void Main(string[] args)
		{
			using (var client = new CatalogoServiceClient())
			{
				var descricao = client.ObterDescricaoProduto(10);

				Console.WriteLine(descricao);

				ProdutoDto produto = new ProdutoDto
				{
					Nome = "PS4",
					Preco = 1234
				};

				var produtoSalvo = client.SalvarProduto(produto);

				Console.WriteLine(produtoSalvo.Id);
			}

		}
	}
}
