namespace Modulo10.Web.Providers
{
	using System;
	using System.Web.Security;

	public class WiseRoleProvider : RoleProvider
	{
		public override bool IsUserInRole(string username, string roleName)
		{
			throw new System.NotImplementedException();
		}

		public override string[] GetRolesForUser(string username)
		{
			if (username.Equals("tiago", StringComparison.InvariantCultureIgnoreCase))
			{
				return new[] { "ADMIN", "SUPERVISOR" };
			}

			if (username.Equals("supervisor", StringComparison.InvariantCultureIgnoreCase))
			{
				return new[] { "SUPERVISOR" };
			}

			return new string[0];
		}

		public override void CreateRole(string roleName)
		{
			throw new System.NotImplementedException();
		}

		public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
		{
			throw new System.NotImplementedException();
		}

		public override bool RoleExists(string roleName)
		{
			throw new System.NotImplementedException();
		}

		public override void AddUsersToRoles(string[] usernames, string[] roleNames)
		{
			throw new System.NotImplementedException();
		}

		public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
		{
			throw new System.NotImplementedException();
		}

		public override string[] GetUsersInRole(string roleName)
		{
			throw new System.NotImplementedException();
		}

		public override string[] GetAllRoles()
		{
			throw new System.NotImplementedException();
		}

		public override string[] FindUsersInRole(string roleName, string usernameToMatch)
		{
			throw new System.NotImplementedException();
		}

		public override string ApplicationName { get; set; }
	}
}