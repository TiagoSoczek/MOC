namespace Modulo6.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class ConexaoTestCase
	{
		[TestMethod]
		public void Criar()
		{
			// Conexao conexao = new Conexao();

			Conexao conexao = Conexao.ObterAtual();

			Assert.AreSame(conexao, Conexao.ObterAtual());
		}
	}
}