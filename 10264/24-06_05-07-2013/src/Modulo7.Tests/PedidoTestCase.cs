using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modulo7.Tests
{
	using Core.Model;

	[TestClass]
	public class PedidoTestCase
	{
		[TestMethod]
		public void ObterValorTotal()
		{
			Pedido pedido = new Pedido();

			pedido.Total = 1000.0;
			pedido.Desconto = 50;

			Assert.AreEqual(500, pedido.ObterValorTotal(0));
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void ObterValorTotal_QuandoTotalProdutosZerado_DispararException()
		{
			Pedido pedido = new Pedido();

			pedido.Total = 0;
			pedido.Desconto = 50;

			pedido.ObterValorTotal(0);
		}
	}
}
