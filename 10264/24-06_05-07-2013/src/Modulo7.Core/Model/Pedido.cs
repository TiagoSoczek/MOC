namespace Modulo7.Core.Model
{
	using System;

	public class Pedido
	{
		public double Total { get; set; }
		public int Desconto { get; set; }

		public double ObterValorTotal(double frete)
		{
			GarantirTotal();

			return CalcularDesconto();
		}

		private double CalcularDesconto()
		{
			return Total*Desconto/100;
		}

		private void GarantirTotal()
		{
			if (Total == 0)
			{
				throw new ArgumentException("TotalProdutos não pode ser zero");
			}
		}
	}
}