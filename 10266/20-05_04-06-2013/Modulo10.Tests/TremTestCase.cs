namespace Modulo10.Tests
{
	using System;
	using System.Collections.ObjectModel;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class TremTestCase
	{
		[TestMethod]
		public void ManipularRota()
		{
			var trem = new Trem();

			trem.AddElemento("A");
			trem.AddElemento("B");
			trem.AddElemento("C");

			Assert.AreEqual(3, trem.Rota.Count);

			ReadOnlyCollection<string> rota = trem.Rota;

			// rota.Clear();

			foreach (string elemento in rota)
			{
				Console.WriteLine(elemento);
			}

			trem.RemoverElemento("C");

			Assert.AreEqual(2, trem.Rota.Count);

			foreach (string elemento in rota)
			{
				Console.WriteLine(elemento);
			}
		}
	}
}