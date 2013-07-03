using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Modulo7.Tests
{
	[TestClass]
	public class PedidoTestCase
	{
		[TestMethod]
		public void CalcularDesconto()
		{
			Pedido pedido = new Pedido();

			pedido.TotalProdutos = 1000.0;
			pedido.Desconto = 50;

			Assert.AreEqual(500, pedido.ObterValorTotal());
		}
	}

	public class Pedido
	{
		public double TotalProdutos { get; set; }
		public int Desconto { get; set; }

		public double ObterValorTotal()
		{
			throw new NotImplementedException();
		}
	}
}
