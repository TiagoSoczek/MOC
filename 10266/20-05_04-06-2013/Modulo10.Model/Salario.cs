namespace Modulo10.Model
{
	using System;

	public class Salario
	{
		public double Valor { get; set; }

		public static implicit operator double(Salario salario)
		{
			return salario.Valor;
		}

		public static explicit operator int(Salario salario)
		{
			return (int) salario.Valor;
		}

		public static Salario operator +(Salario salario, double adicional)
		{
			return new Salario
			{
				Valor = salario.Valor + Math.Abs(adicional)
			};
		}

		public static Salario operator +(double adicional, Salario salario)
		{
			return salario + adicional;
		}
	}
}