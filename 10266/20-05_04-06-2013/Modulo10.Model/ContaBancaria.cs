namespace Modulo10.Model
{
	using System;

	public class ContaBancaria
	{
		public double Saldo { get; private set; }

		public void Depositar(double montante)
		{
			Saldo += montante;
		}

		public void Sacar(double montante)
		{
			if (montante > Saldo)
			{
				throw new Exception(string.Format("Saldo insuficiente. Saldo Atual: {0}, montante: {1}", Saldo, montante));
			}

			Saldo -= montante;
		}
	}
}