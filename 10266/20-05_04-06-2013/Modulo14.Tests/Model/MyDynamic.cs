namespace Modulo14.Tests.Model
{
	using System;
	using System.Dynamic;

	public class MyDynamic : DynamicObject
	{
		private readonly Random _rnd = new Random();

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			var next = _rnd.Next(0, 100);

			Console.WriteLine("Get: {0} - {1}", binder.Name, next);

			result = binder.Name + "-" + next;

			return true;
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			Console.WriteLine("Set: {0} - {1}", binder.Name, value);

			return true;
		}
	}
}