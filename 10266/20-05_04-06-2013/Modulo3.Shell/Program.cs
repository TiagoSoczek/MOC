namespace Modulo3.Shell
{
	using System;
	using System.Security;

	internal class Program
	{
		private static void Main(string[] args)
		{
			Produto produto = new Produto();

			produto.Nome = "Galaxy S IV";
			produto.Preco = 2499.99;

			Console.WriteLine(produto.Preco);

			try
			{
				produto.AplicarDesconto();

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
	}
}