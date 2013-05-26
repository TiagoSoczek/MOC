namespace Modulo6.Model
{
	using System;

	public struct RG
	{
		public string Numero { get; set; }
		public string UF { get; set; }
	}

	public enum CategoriaCliente
	{
		Desconhecida = 0,
		Standard = 1,
		Premium = 2,
		Platinum = 3
	}

	public class Cliente
	{
		static Cliente()
		{
			Console.WriteLine("Apenas uma vez!");
		}

		public Cliente(string email)
		{
			Email = email;
		}

		public string Email { get; set; }
		public RG Rg { get; set; }
		public DateTime DataNascimento { get; set; }
		public CategoriaCliente Categoria { get; set; }

		public double ObterPercentualDesconto()
		{
			switch (Categoria)
			{
				case CategoriaCliente.Standard:
					return 1;
				case CategoriaCliente.Premium:
				case CategoriaCliente.Platinum:
					return 10;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}