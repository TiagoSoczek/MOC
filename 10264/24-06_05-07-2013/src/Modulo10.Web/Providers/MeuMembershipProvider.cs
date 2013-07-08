namespace Modulo10.Web.Providers
{
	using System;
	using System.Web.Security;

	public class MeuMembershipProvider : MembershipProvider
	{
		public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer,
			bool isApproved, object providerUserKey, out MembershipCreateStatus status)
		{
			throw new System.NotImplementedException();
		}

		public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion,
			string newPasswordAnswer)
		{
			throw new System.NotImplementedException();
		}

		public override string GetPassword(string username, string answer)
		{
			throw new System.NotImplementedException();
		}

		public override bool ChangePassword(string username, string oldPassword, string newPassword)
		{
			throw new System.NotImplementedException();
		}

		public override string ResetPassword(string username, string answer)
		{
			throw new System.NotImplementedException();
		}

		public override void UpdateUser(MembershipUser user)
		{
			throw new System.NotImplementedException();
		}

		public override bool ValidateUser(string username, string password)
		{
			return username.Equals("tiago", StringComparison.InvariantCultureIgnoreCase) &&
			       password.Equals("123");
		}

		public override bool UnlockUser(string userName)
		{
			throw new System.NotImplementedException();
		}

		public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
		{
			throw new System.NotImplementedException();
		}

		public override MembershipUser GetUser(string username, bool userIsOnline)
		{
			throw new System.NotImplementedException();
		}

		public override string GetUserNameByEmail(string email)
		{
			throw new System.NotImplementedException();
		}

		public override bool DeleteUser(string username, bool deleteAllRelatedData)
		{
			throw new System.NotImplementedException();
		}

		public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
		{
			throw new System.NotImplementedException();
		}

		public override int GetNumberOfUsersOnline()
		{
			throw new System.NotImplementedException();
		}

		public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new System.NotImplementedException();
		}

		public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new System.NotImplementedException();
		}

		public override bool EnablePasswordRetrieval
		{
			get { throw new System.NotImplementedException(); }
		}

		public override bool EnablePasswordReset
		{
			get { return false; }
		}

		public override bool RequiresQuestionAndAnswer
		{
			get { return false; }
		}

		public override string ApplicationName { get; set; }

		public override int MaxInvalidPasswordAttempts
		{
			get { return 0; }
		}

		public override int PasswordAttemptWindow
		{
			get { return 0; }
		}

		public override bool RequiresUniqueEmail
		{
			get { return true; }
		}

		public override MembershipPasswordFormat PasswordFormat
		{
			get { throw new System.NotImplementedException(); }
		}

		public override int MinRequiredPasswordLength
		{
			get { throw new System.NotImplementedException(); }
		}

		public override int MinRequiredNonAlphanumericCharacters
		{
			get { throw new System.NotImplementedException(); }
		}

		public override string PasswordStrengthRegularExpression
		{
			get { throw new System.NotImplementedException(); }
		}
	}
}