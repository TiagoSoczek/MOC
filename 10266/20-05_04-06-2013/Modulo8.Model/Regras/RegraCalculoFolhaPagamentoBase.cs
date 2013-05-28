namespace Modulo8.Model.Regras
{
	public abstract class RegraCalculoFolhaPagamentoBase : IRegraCalculoFolhaPagamento
	{
		public abstract bool Aplicavel(Empregado empregado);
		public abstract int Calcular(Empregado empregado);

		protected int ObterValorBase(Empregado empregado)
		{
			return empregado.CalcularFerias() * 100;
		}
	}
}