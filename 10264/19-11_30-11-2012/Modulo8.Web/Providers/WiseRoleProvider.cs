using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modulo8.Web.Providers
{
	public class WiseRoleProvider : System.Web.Security.RoleProvider
	{
		public override void AddUsersToRoles(string[] usernames, string[] roleNames)
		{
			throw new NotImplementedException();
		}

		public override string ApplicationName { get; set; }

		public override void CreateRole(string roleName)
		{
			throw new NotImplementedException();
		}

		public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
		{
			throw new NotImplementedException();
		}

		public override string[] FindUsersInRole(string roleName, string usernameToMatch)
		{
			throw new NotImplementedException();
		}

		public override string[] GetAllRoles()
		{
			throw new NotImplementedException();
		}

		public override string[] GetRolesForUser(string username)
		{
			// TODO: Realizar a busca das roles no banco de dados

			if (username.Equals("tiago"))
			{
				return new[] { "ADMIN" };
			}

			if (username.Equals("supervisor"))
			{
				return new[] { "SUPERVISOR" };
			}

			return new string[0];
		}

		public override string[] GetUsersInRole(string roleName)
		{
			throw new NotImplementedException();
		}

		public override bool IsUserInRole(string username, string roleName)
		{
			throw new NotImplementedException();
		}

		public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
		{
			throw new NotImplementedException();
		}

		public override bool RoleExists(string roleName)
		{
			throw new NotImplementedException();
		}
	}
}