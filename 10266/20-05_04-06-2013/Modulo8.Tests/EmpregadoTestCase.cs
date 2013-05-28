namespace Modulo8.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class EmpregadoTestCase
	{
		[TestMethod]
		public void Criar()
		{
			Empregado empregado = new Operario("Nonono");

			var gerente = new Gerente("Tiago", "Jr");

			gerente = empregado as Gerente;

			Assert.IsNull(gerente);

			/*gerente = empregado as Gerente;

			Assert.IsNotNull(gerente);*/
		}

		[TestMethod]
		public void ChamarMetodo()
		{
			Empregado empregado = new Operario("Tiago");

			empregado.RealizarAtividade();

			empregado = new Gerente("Nononono", "Top");

			empregado.RealizarAtividade();
		}
	}
}