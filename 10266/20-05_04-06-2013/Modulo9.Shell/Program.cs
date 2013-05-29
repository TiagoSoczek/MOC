namespace Modulo9.Shell
{
	using System;
	using System.Collections.Generic;

	internal class Program
	{
		private static void Main(string[] args)
		{
			Arquivo arquivo;
			// List<Arquivo> arquivos = new List<Arquivo>();

			for (int i = 0; i < 1000; i++)
			{
				using (arquivo = new Arquivo())
				{
					Console.WriteLine("Using");
				}
				// arquivos.Add(new Arquivo());
			}

			Console.WriteLine("Memoria Total: {0}", GC.GetTotalMemory(false));

			GC.Collect();
			GC.WaitForPendingFinalizers();

			Console.WriteLine("Memoria Total: {0}", GC.GetTotalMemory(true));

			Console.WriteLine("Fim!");
			Console.ReadLine();
		}
	}
}