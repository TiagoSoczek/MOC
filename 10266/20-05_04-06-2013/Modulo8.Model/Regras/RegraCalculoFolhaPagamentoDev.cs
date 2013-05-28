namespace Modulo8.Model.Regras
{
	public class RegraCalculoFolhaPagamentoDev : RegraCalculoFolhaPagamentoBase
	{
		public override bool Aplicavel(Empregado empregado)
		{
			return empregado is Desenvolvedor;
		}

		public override int Calcular(Empregado empregado)
		{
			return ObterValorBase(empregado);
		}
	}
}