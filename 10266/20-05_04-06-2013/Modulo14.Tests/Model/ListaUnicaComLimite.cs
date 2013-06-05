namespace Modulo14.Tests.Model
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class ListaUnicaComLimite<T> : IEnumerable<T> where T : struct
	{
		private const int Limite = 10;
		private readonly HashSet<T> _dados = new HashSet<T>();
		
		public void Add(T item)
		{
			if (_dados.Contains(item))
			{
				return;
			}

			if (_dados.Count >= Limite)
			{
				throw new Exception("Limite excedido");
			}

			_dados.Add(item);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return _dados.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}