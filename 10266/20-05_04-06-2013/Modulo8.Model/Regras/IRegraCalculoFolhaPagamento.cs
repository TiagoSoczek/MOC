namespace Modulo8.Model.Regras
{
	public interface IRegraCalculoFolhaPagamento
	{
		bool Aplicavel(Empregado empregado);
		int Calcular(Empregado empregado);
	}
}