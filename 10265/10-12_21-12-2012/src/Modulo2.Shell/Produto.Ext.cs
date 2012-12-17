using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo2.Shell
{
	public partial class Produto
	{
		public override string ToString()
		{
			return string.Format("Nome: {0}, Quantidade: {1}", Nome, Quantidade);
		}
	}
}
