namespace Modulo10.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class ContaBancariaTestCase
	{
		[TestMethod]
		public void Operacoes()
		{
			var conta = new ContaBancaria();

			conta.Depositar(1000);

			Assert.AreEqual(1000, conta.Saldo);

			// conta.Saldo = double.MaxValue;

			conta.Sacar(1000);

			Assert.AreEqual(0, conta.Saldo);
		}
	}
}