namespace Modulo6.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;
	using Model.Extensions;

	[TestClass]
	public class ClienteTestCase
	{
		[TestMethod]
		public void Criar()
		{
			Cliente cliente = new Cliente("tiago@soczek.net");

			cliente.Rg = new RG { Numero = "123412332312", UF = "PR" };

			cliente.DataNascimento = DateTime.Now;
			
			Assert.AreEqual(CategoriaCliente.Desconhecida,
				cliente.Categoria);

			cliente.Categoria = CategoriaCliente.Premium;

			Assert.AreEqual(10, cliente.ObterPercentualDesconto());

			cliente.Categoria = CategoriaCliente.Standard;

			Assert.AreEqual(1, cliente.ObterPercentualDesconto());
		}

		[TestMethod]
		public void ValidarRG()
		{
			var numero = "11.11.11";

			RG rg = new RG
				{
					Numero = numero
				};

			var valido = rg.EhValido();

			Assert.IsTrue(valido);

			Assert.AreEqual(numero, rg.Numero);
		}

		[TestMethod]
		public void ObterAmanha()
		{
			var ontem = DateTime.Now.ObterOntem();
			
			Console.WriteLine(ontem);
		}
	}
}