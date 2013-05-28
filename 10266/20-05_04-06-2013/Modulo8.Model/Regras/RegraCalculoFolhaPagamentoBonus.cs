namespace Modulo8.Model.Regras
{
	using System;

	public class RegraCalculoFolhaPagamentoBonus : RegraCalculoFolhaPagamentoBase
	{
		private readonly Type _tipo;
		private readonly double _bonus;

		public RegraCalculoFolhaPagamentoBonus(Type tipo, double bonus)
		{
			_tipo = tipo;
			_bonus = bonus;
		}

		public override bool Aplicavel(Empregado empregado)
		{
			return empregado.GetType() == _tipo;
		}

		public override int Calcular(Empregado empregado)
		{
			return (int) (ObterValorBase(empregado)*_bonus);
		}
	}
}