namespace Modulo14.Tests.Model
{
	using System.Collections;
	using System.Collections.Generic;

	public class ListaDeCaracteres : IEnumerator<char>, IEnumerable<char>
	{
		public ListaDeCaracteres()
		{
			Current = (char) 0;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			if (Current >= 255) // char.MaxValue)
			{
				return false;
			}

			Current++;

			return true;
		}

		public void Reset()
		{
			Current = (char) 0;
		}

		public char Current { get; private set; }

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public IEnumerator<char> GetEnumerator()
		{
			Reset();

			while (MoveNext())
			{
				yield return Current;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}