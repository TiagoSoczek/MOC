namespace Modulo3.Shell
{
	using System;
	using System.Security;

	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				Produto produto = new Produto();

				produto.Nome = "Galaxy S IV";
				produto.Preco = 1899.99;

				produto.AddCategoria(1, 10, 100, 1000);

				try
				{
					produto.AddCategoria();
				}
				catch (Exception e)
				{
					// Logar erro
					Console.WriteLine(e.Message);

					// Correto
					// throw;
					
					// Errado
					// throw e;

					throw new Exception("Não foi possível adicionar as categorias", e);
				}

				Console.WriteLine(produto.Preco);

				try
				{
					double precoAntigo = produto.AplicarDesconto();

					produto.AplicarDesconto(1600);

					Console.WriteLine(precoAntigo);
					Console.WriteLine(produto.Preco);
				}
					/*catch (InvalidOperationException e)
			{
				Console.WriteLine("Problema de segurança");
				Console.WriteLine(e);
			}*/
				catch (Exception e)
				{
					Console.WriteLine("Erro Genérico");
					Console.WriteLine(e);
				}
				finally
				{
					Console.ReadLine();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}