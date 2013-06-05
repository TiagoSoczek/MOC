namespace Modulo14.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Model;

	[TestClass]
	public class EnumerableTestCase
	{
		[TestMethod]
		public void Listas()
		{
			List<Produto> produtos = new List<Produto>();
			
			var produto = new Produto
			{
				Nome = "Xbox One"
			};

			produtos.Add(produto);
			produtos.Add(produto);

			Assert.AreEqual(2, produtos.Count);

			HashSet<Produto> produtosUnicos = new HashSet<Produto>();

			produtosUnicos.Add(produto);
			produtosUnicos.Add(produto);

			Assert.AreEqual(1, produtosUnicos.Count);

			Stack<Produto> pilha = new Stack<Produto>();

			var produto2 = new Produto
			{
				Nome = "PS4"
			};

			pilha.Push(produto);
			pilha.Push(produto2);

			var produtoPeek = pilha.Peek();
			var produtoPop = pilha.Pop();
			var produtoPop2 = pilha.Pop();

			if (pilha.Any())
			{
				produtoPeek = pilha.Peek();
			}

			Queue<Produto> fila = new Queue<Produto>();

			fila.Enqueue(produto);
			fila.Enqueue(produto2);

			var primeiroDaFila = fila.Peek();
			primeiroDaFila = fila.Dequeue();

			Console.WriteLine(primeiroDaFila);

			var dic = new Dictionary<int, Produto>();

			dic.Add(50, produto);
			dic.Add(90, produto2);

			Console.WriteLine(dic[50]);
			Console.WriteLine(dic[90]);

			if (dic.ContainsKey(5))
			{
				Console.WriteLine(dic[5]);
			}
			else
			{
				dic[5] = produto;
				
				Console.WriteLine(dic[5]);
			}
		}

		[TestMethod]
		public void ListarChars()
		{
			var lista = new ListaDeCaracteres();

			foreach (char character in lista)
			{
				Console.WriteLine(character);
			}

			foreach (char character in lista)
			{
				Console.WriteLine(character);
			}
		}

		[TestMethod]
		public void ListaUnica()
		{
			ListaUnicaComLimite<int> listaUnica = new 
				ListaUnicaComLimite<int>();

			for (int i = 0; i < 10; i++)
			{
				listaUnica.Add(i);
			}

			listaUnica.Add(1);
			
			try
			{
				listaUnica.Add(11);

				Assert.Fail("O limite foi excedido");
			}
			catch (Exception e)
			{
				
			}

			foreach (var item in listaUnica)
			{
				Console.WriteLine(item);
			}
		}
	}
}