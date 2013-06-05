namespace Modulo14.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Dynamic;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class DynamicTestCase
	{
		[TestMethod]
		public void Dynamic()
		{
			dynamic qualquer = new ExpandoObject();

			var excel = qualquer as IDictionary<string, object>;

			excel["ValorTotal"] = 123.99;
			excel["B"] = DateTime.Now;

			Console.WriteLine(qualquer.ValorTotal);
			Console.WriteLine(qualquer.B);

			dynamic my = new MyDynamic();

			my.Nome = "Nonono";
			my.Data = DateTime.Now.Year;

			Console.WriteLine(my.Data);
		}

		[TestMethod]
		public void TestNome()
		{
			dynamic nome = new NomeDynamic();

			nome.PrimeiroNome = "Tiago";
			nome.SobreNome = "Soczek";

			Console.WriteLine(nome.PrimeiroNome_SobreNome);
		}
	}
}