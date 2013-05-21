using System;

namespace Modulo1.Shell
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				throw new Exception("Um nome deve ser informado");
			}

			string texto = args[0];

			// Console.WriteLine("Digite seu nome:");

			// string texto = Console.ReadLine();

			Console.WriteLine("Olá {0}!", texto);

			Console.ReadLine();
		}
	}
}
