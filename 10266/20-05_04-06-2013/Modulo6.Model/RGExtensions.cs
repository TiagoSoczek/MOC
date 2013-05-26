using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo6.Model.Extensions
{
	public static class DateTimeExtensions
	{
		public static DateTime ObterOntem(this DateTime database)
		{
			return database.AddDays(-1);
		}
	}

	public static class RGExtensions
	{
		public static bool EhValido(this RG rg)
		{
			rg.Numero = "123456";

			return !rg.Numero.Equals("11.11.111.111.11");
		}
	}
}
