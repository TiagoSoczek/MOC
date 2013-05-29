namespace Modulo10.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class SalarioTestCase
	{
		[TestMethod]
		public void Somar()
		{
			var salario = new Salario
				{
					Valor = 123
				};

			Salario meuNovoSalario = -500 + salario;

			// Explicito
			var valorInt = (int) meuNovoSalario;

			// Implicito
			double valor = meuNovoSalario;

			Assert.AreEqual(623, valor);
		}
	}
}