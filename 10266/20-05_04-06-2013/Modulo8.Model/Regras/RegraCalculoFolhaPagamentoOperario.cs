namespace Modulo8.Model.Regras
{
	public class RegraCalculoFolhaPagamentoOperario : RegraCalculoFolhaPagamentoBase
	{
		public override bool Aplicavel(Empregado empregado)
		{
			return empregado.GetType() == typeof(Operario);
		}

		public override int Calcular(Empregado empregado)
		{
			const double bonus = 1.1;

			return (int)(ObterValorBase(empregado) * bonus);
		}
	}
}