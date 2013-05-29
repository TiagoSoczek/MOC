namespace Modulo10.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class RepositorioDeClientesTestCase
	{
		[TestMethod]
		public void Index()
		{
			var repositorio = new RepositorioDeClientes();

			var cliente1 = new Cliente
				{
					Nome = "nonono"
				};

			repositorio["nonono"] = cliente1;

			var cliente2 = repositorio["nonono"];

			Assert.AreSame(cliente1, cliente2);

			try
			{
				var clienteTiago = repositorio["Nonono"];

				Assert.Fail("Não deve encontrar o cliente");
			}
			catch (Exception e)
			{
			}
		}
	}
}