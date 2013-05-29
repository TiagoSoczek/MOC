namespace Modulo10.Model
{
	using System.Collections.Generic;
	using System.Collections.ObjectModel;

	public class Trem
	{
		private readonly List<string> _rota;

		public Trem()
		{
			_rota = new List<string>();
		}

		public void AddElemento(string elemento)
		{
			_rota.Add(elemento);
		}

		public void RemoverElemento(string elemento)
		{
			_rota.Remove(elemento);
		}

		/*public List<string> Rota
		{
			get { return _rota.ToList(); }
		}*/

		public ReadOnlyCollection<string> Rota
		{
			get { return new ReadOnlyCollection<string>(_rota); }
		}
	}
}