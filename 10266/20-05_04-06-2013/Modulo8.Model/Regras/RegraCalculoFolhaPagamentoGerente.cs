namespace Modulo8.Model.Regras
{
	public class RegraCalculoFolhaPagamentoGerente : RegraCalculoFolhaPagamentoBase
	{
		public override bool Aplicavel(Empregado empregado)
		{
			return empregado is Gerente;
		}

		public override int Calcular(Empregado empregado)
		{
			const double bonus = 1.5;

			return (int) (ObterValorBase(empregado)*bonus);
		}
	}
}