namespace Modulo14.Tests.Model
{
	using System.Collections.Generic;
	using System.Dynamic;

	public class NomeDynamic : DynamicObject
	{
		private Dictionary<string, object> _dic;

		public NomeDynamic()
		{
			_dic = new Dictionary<string, object>();
		}

		public override bool TrySetMember(SetMemberBinder binder, object value)
		{
			_dic[binder.Name] = value;

			return true;
		}

		public override bool TryGetMember(GetMemberBinder binder, out object result)
		{
			var binderSplit = binder.Name.Split('_');

			string text = string.Empty;

			foreach (var key in binderSplit)
			{
				if (_dic.ContainsKey(key))
				{
					text += _dic[key];
				}
			}

			result = text;

			return true;
		}
	}
}