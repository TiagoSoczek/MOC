namespace Modulo8.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class CalculoFolhaPagamentoTestCase
	{
		[TestMethod]
		public void Calcular()
		{
			var operario = new Operario("Tiago");
			var dev = new Desenvolvedor("Nonono");
			var gerente = new Gerente("Nonono", "Top");

			using (var calculoFolha = new CalculoFolhaPagamento())
			{
				Assert.AreEqual(1650, calculoFolha.Calcular(operario));
				Assert.AreEqual(1500, calculoFolha.Calcular(dev));
				Assert.AreEqual(6750, calculoFolha.Calcular(gerente));
			}
		}
	}
}