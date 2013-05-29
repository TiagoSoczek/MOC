namespace Modulo10.Model
{
	using System;
	using System.Collections.Generic;

	public class RepositorioDeClientes
	{
		private Dictionary<string, Cliente> _base;

		public RepositorioDeClientes()
		{
			_base = new Dictionary<string, Cliente>();
		}

		public Cliente this[string nomeDoCliente]
		{
			get
			{
				if (_base.ContainsKey(nomeDoCliente))
				{
					return _base[nomeDoCliente];
				}

				throw new Exception("Não existe cliente com o nome " + nomeDoCliente);
			}

			set
			{
				_base[nomeDoCliente] = value;
			}
		}
	}
}