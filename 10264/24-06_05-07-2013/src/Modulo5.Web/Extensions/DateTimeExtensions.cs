namespace Modulo5.Web.Extensions
{
	using System;

	public static class DateTimeExtensions
	{
		public static DateTime ObterOntem(this DateTime data)
		{
			return data.AddDays(-1);
		}
	}
}