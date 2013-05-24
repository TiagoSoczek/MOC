namespace Modulo2.Shell
{
	using System;
	using System.Globalization;
	using System.Text;
	using System.Threading;

	internal class Program
	{
		private static int _qtde;

		private static void Main(string[] args)
		{
			/*
			Exemplo Private Fields - Variáveis Escopo Classe
			_qtde = 1;
			Console.WriteLine(_qtde);
			*/

			unchecked
			{
				var max = int.MaxValue;

				max++;

				Console.WriteLine(max == int.MinValue);
			}

			ExemploArrays();

			ExemploLooops();
			ExemploSwitch();
			ExemploOperadorTernario();
			ExemploArrays();
			ExemploTextosLongos();
			ExemploAlterarValor();
			ExemploTestarEscopo();
			ExemploVariaveis();
			ExemploConversaoDados();
			ExemploLeituraDados();

			Console.ReadLine();
		}

		private static void ExemploLooops()
		{
			while (true)
			{
				DateTime agora = DateTime.Now;

				if (agora.Second == 59)
				{
					break;
				}

				Console.WriteLine(agora);
			}
		}

		private static void ExemploSwitch()
		{
			string texto;

			switch (DateTime.Now.DayOfWeek)
			{
				case DayOfWeek.Sunday:
					texto = "Descanso";
					break;
				case DayOfWeek.Monday:
				case DayOfWeek.Tuesday:
				case DayOfWeek.Wednesday:
				case DayOfWeek.Thursday:
					texto = "Trabalho";
					break;
				case DayOfWeek.Friday:
					texto = "Cerveja";
					break;
				case DayOfWeek.Saturday:
					texto = "Ressaca";
					break;
				default:
					throw new Exception("Um novo dia da semana??");
			}

			Console.WriteLine(texto);

			string primeiraLetra = "T";

			switch (primeiraLetra)
			{
				case "A":
					texto = "AAA";
					break;
				case "T":
					texto = "TTT";
					break;
			}
		}

		private static void ExemploOperadorTernario()
		{
			string texto = DateTime.Now.DayOfWeek == DayOfWeek.Friday ? "Festa" : "Trabalho";

			Console.WriteLine(texto);

			Exception exception1 = null;
			Exception exception2 = new Exception();

			Exception resultado = exception1 ?? exception2;

			if (exception1 != null && exception1.Equals(exception2))
			{
				Console.WriteLine("É o mesmo!");
			}
		}

		private static void ExemploArrays()
		{
			var valores = new int[5];

			valores[3] = 34242;

			for (int i = 0; i < valores.Length; i++)
			{
				valores[i] = i*i;
			}

			foreach (int valor in valores)
			{
				Console.WriteLine(valor);
			}

			var matriz = new int[4, 5];

			var rnd = new Random();

			var qtdeDimensoes = matriz.Rank; // 2

			var colsNum = matriz.GetUpperBound(0);
			var rowsNum = matriz.GetUpperBound(1);

			for (int i = 0; i <= colsNum; i++)
			{
				for (int j = 0; j <= rowsNum; j++)
				{
					matriz[i, j] = rnd.Next();
				}
			}

			Console.WriteLine(matriz);

			var arrayDeArrays = new int[10][];

			for (int i = 0; i < arrayDeArrays.Length; i++)
			{
				arrayDeArrays[i] = new int[rnd.Next(0, 100)];

				var arrayInterno = arrayDeArrays[i];

				for (int j = 0; j < arrayInterno.Length; j++)
				{
					arrayInterno[j] = rnd.Next();
				}

				Array.Sort(arrayDeArrays[i]);
			}

			Console.WriteLine(arrayDeArrays);
			Console.WriteLine(arrayDeArrays.Length);
		}

		private static void ExemploTextosLongos()
		{
			var stb = new StringBuilder();

			stb.AppendLine("texto longo");

			Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");

			for (int i = 0; i < 10000; i++)
			{
				stb.AppendFormat("#{0}-{1:c}\r\n", i, i*0.01);
			}

			string texto = stb.ToString();

			Console.WriteLine(texto);
		}

		private static void ExemploLeituraDados()
		{
			int idade;
			bool resultado;

			do
			{
				Console.WriteLine("Digite sua idade:");
				string linha = Console.ReadLine();

				resultado = int.TryParse(linha, out idade);

				if (!resultado)
				{
					Console.WriteLine("'{0}' não é um inteiro válido", linha);
				}
			} while (!resultado);

			Console.WriteLine(resultado);
			Console.WriteLine(idade);
		}

		private static void ExemploConversaoDados()
		{
			// Check overflow/underflow

			long idade = long.MaxValue;

			idade++;

			Console.WriteLine(idade);

			var idade2 = (int) idade;

			Console.WriteLine(idade);
			Console.WriteLine(idade2);
		}

		private static void ExemploTestarEscopo()
		{
			double preco;

			if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
			{
				double descontoDeQuarta = 0.5;

				preco = 10.99*descontoDeQuarta;
			}
			else
			{
				preco = ObterPrecoPadrao();
			}

			// Console.WriteLine(descontoDeQuarta);
			Console.WriteLine(preco);
		}

		private static double ObterPrecoPadrao()
		{
			return 15.99;
		}

		private static void ExemploAlterarValor()
		{
			int valorAntigo = ++_qtde;

			bool igual = valorAntigo == _qtde;

			Console.WriteLine(igual);

			Console.WriteLine(valorAntigo);
			Console.WriteLine(_qtde);
		}

		private static void ExemploVariaveis()
		{
			int? qtde = 99;

			Console.WriteLine(qtde.HasValue);

			if (qtde.HasValue)
			{
				Console.WriteLine(qtde.Value);
			}
			else
			{
				Console.WriteLine("SemValor");
			}

			Console.WriteLine(qtde.GetValueOrDefault());
			Console.WriteLine(qtde.GetValueOrDefault(10));

			DateTime agora, amanha;

			agora = DateTime.Now;
			amanha = DateTime.Now.AddDays(1);
			DateTime amanha1 = agora.AddDays(1);

			string diaSemana = agora.ToString("dddd");

			Console.WriteLine(diaSemana);

			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
			// UICulture - aplicável apenas a localização (tradução) da aplicação
			// Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

			Console.WriteLine(agora.ToLongDateString());
		}
	}
}