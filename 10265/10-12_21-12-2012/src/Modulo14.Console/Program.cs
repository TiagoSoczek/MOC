namespace Modulo14.Console
{
	using System;
	using System.Configuration;
	using System.Data;
	using System.Data.SqlClient;

	internal class Program
	{
		private static void Main(string[] args)
		{
			ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["Default"];

			if (config == null)
			{
				throw new Exception("A connection string 'Default' não foi configurada");
			}

			using (var conn = new SqlConnection(config.ConnectionString))
			{
				conn.Open();

				RemoverTodosProdutos(conn);

				InserirProdutos(conn);

				ConsultarProdutos(conn);
				
				ConsultarProdutosDataSet(conn);
			}

			Console.Read();
		}

		private static void ConsultarProdutosDataSet(SqlConnection conn)
		{
			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = @"SELECT * FROM Produto
								GO
								SELECT Id FROM Produto
								GO";

			DataSet ds = new DataSet();

			using (var da = new SqlDataAdapter(cmd))
			{
				da.Fill(ds);
			}

			conn.Close();

			foreach (DataTable table in ds.Tables)
			{
				foreach (DataRow row in table.Rows)
				{
					foreach (DataColumn column in table.Columns)
					{
						Console.WriteLine("{0}: {1}", column.ColumnName, row[column]);
					}

					Console.WriteLine("-----------");
				}
			}
		}

		private static void ConsultarProdutos(SqlConnection conn)
		{
			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM Produto";

			using (SqlDataReader dr = cmd.ExecuteReader())
			{
				int qtde = 0;

				while (dr.Read())
				{
					Console.WriteLine(dr["Nome"]);
					Console.WriteLine(dr["Preco"]);
					Console.WriteLine(dr["Quantidade"]);
					Console.WriteLine(dr["Ativo"]);

					qtde++;
				}
			}
		}

		private static void InserirProdutos(SqlConnection conn)
		{
			/*var cmd = new SqlCommand(@"INSERT INTO Produto (Nome, Preco, Quantidade, Ativo) 
							VALUES ('Galaxy S3', 1499, 123, 1)");

			cmd.Connection = conn;*/

			for (int i = 0; i < 100; i++)
			{
				SqlCommand cmd = conn.CreateCommand();

				cmd.CommandText = @"INSERT INTO Produto (Nome, Preco, Quantidade, Ativo) 
										VALUES (@Nome, @Preco, @Quantidade, @Ativo)";

				cmd.Parameters.AddWithValue("Nome", "Iphone 5");
				cmd.Parameters.AddWithValue("Preco", 2349);
				cmd.Parameters.AddWithValue("Quantidade", 10);
				cmd.Parameters.AddWithValue("Ativo", true);

				/*var parameterNome = new SqlParameter("Nome", SqlDbType.VarChar);

			parameterNome.Value = "Iphone 5";

			cmd.Parameters.Add(parameterNome);*/

				int registrosAfetados = cmd.ExecuteNonQuery();
			}

			// System.Console.WriteLine("RegistrosAfetados: " + registrosAfetados);
		}

		private static void RemoverTodosProdutos(SqlConnection conn)
		{
			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "TRUNCATE TABLE Produto";

			int afetados = cmd.ExecuteNonQuery();

			Console.WriteLine("Registros removidos: {0}", afetados);
		}
	}
}