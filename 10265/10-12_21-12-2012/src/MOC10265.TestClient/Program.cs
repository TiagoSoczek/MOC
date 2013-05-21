using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOC10265.TestClient
{
	class Program
	{
		static void Main(string[] args)
		{
			var service = new CatalogoService.CatalogoWebServiceClient();

			service.Open();

			var produtosTeste = service.PesquisarProdutos("teste", 10);

			foreach (var produto in produtosTeste)
			{
				Console.WriteLine(produto);
			}

			Console.Read();
		}
	}
}
