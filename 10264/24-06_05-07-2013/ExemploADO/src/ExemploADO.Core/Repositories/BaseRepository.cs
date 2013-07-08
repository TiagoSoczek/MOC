namespace ExemploADO.Core.Repositories
{
	using System.Configuration;
	using System.Data.SqlClient;

	public abstract class BaseRepository
	{
		protected SqlConnection ObterConexao()
		{
			string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
			
			SqlConnection conn = new SqlConnection(connString);

			conn.Open();

			return conn;
		}
	}
}