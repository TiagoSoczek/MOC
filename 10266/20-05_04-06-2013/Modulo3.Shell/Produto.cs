namespace Modulo3.Shell
{
	using System;
	using System.Collections.Generic;

	public class Produto
	{
		public Produto()
		{
			Categorias = new List<int>();
		}

		public string Nome { get; set; }
		
		public double Preco { get; set; }
		
		public List<int> Categorias { get; set; }

		/*public static void AplicarDesconto(Produto produto)
		{
			produto.Preco = produto.Preco * 0.9;
		}*/

		public void AddCategoria(params int[] novasCategorias)
		{
			if (novasCategorias.Length == 0)
			{
				throw new ArgumentException("Nenhuma categoria foi informada");
			}

			Categorias.AddRange(novasCategorias);

			/*foreach (var categoria in novasCategorias)
			{
				Categorias.Add(categoria);
			}*/
		}

		public void AplicarDesconto(double valorMinimo)
		{
			Preco = Math.Min(Preco, valorMinimo);
		}

		public double AplicarDesconto()
		{
			if (Preco >= 2000)
			{
				var msg = string.Format("O preço deve ser menor que {0:c}", 2000);

				throw new InvalidOperationException(msg);
			}

			var precoAntigo = Preco;

			Preco = Preco*0.9;

			return precoAntigo;
		}
	}
}
