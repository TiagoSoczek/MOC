namespace Modulo10.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class CepTestCase
	{
		[TestMethod]
		public void Converter()
		{
			Cep meuCep = "00000-000";

			string cep = meuCep;

			Console.WriteLine(cep);
		}
	}
}