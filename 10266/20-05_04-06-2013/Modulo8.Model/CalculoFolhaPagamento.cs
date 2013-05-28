namespace Modulo8.Model
{
	using System;
	using System.Collections.Generic;
	using Regras;

	public class CalculoFolhaPagamento : IDisposable
	{
		private readonly List<IRegraCalculoFolhaPagamento> _regras;

		public CalculoFolhaPagamento()
		{
			Console.WriteLine("Começo do Calculo de Folha");

			/*_regras = new List<IRegraCalculoFolhaPagamento>
				{
					new RegraCalculoFolhaPagamentoOperario(),
					new RegraCalculoFolhaPagamentoDev(),
					new RegraCalculoFolhaPagamentoGerente()
				};*/

			// Pode ser carregado dinamicamente

			_regras = new List<IRegraCalculoFolhaPagamento>
				{
					new RegraCalculoFolhaPagamentoBonus(typeof(Operario), 1.1),
					new RegraCalculoFolhaPagamentoBonus(typeof(Desenvolvedor), 1),
					new RegraCalculoFolhaPagamentoBonus(typeof(Gerente), 1.5)
				};
		}

		public int Calcular(Empregado empregado)
		{
			foreach (var regra in _regras)
			{
				if (regra.Aplicavel(empregado))
				{
					return regra.Calcular(empregado);
				}
			}

			throw new Exception(string.Format("Nenhuma regra foi encontrada para o empregado {0}, {1}", empregado, empregado.GetType()));
		}

		public void Dispose()
		{
			Console.WriteLine("Fim Calculo de Folha");
		}
	}
}