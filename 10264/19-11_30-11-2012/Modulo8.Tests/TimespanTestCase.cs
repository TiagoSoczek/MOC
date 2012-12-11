namespace Modulo8.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class TimespanTestCase
	{
		[TestMethod]
		public void SubtracaoDeDatas()
		{
			var agora = DateTime.Now;
			var umAnoAtras = agora.AddYears(-1);

			TimeSpan diff = (umAnoAtras - agora).Duration();

			Assert.IsTrue(diff.TotalDays >= 365);
		}
	}
}