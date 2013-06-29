namespace Modulo5.Web.Extensions
{
	using System.Collections.Generic;
	using System.Linq;

	public static class EnumerableExtensions
	{
		public static List<T> Filtrar<T>(this IEnumerable<T> items)
		{
			// Realizar filtro
			return items.ToList();
		}
	}
}