namespace Modulo14.Console
{
	using System;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Data;
	using System.Data.SqlClient;
	using System.Threading;
	using MOC10265.Model;

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
				
				AtualizarPrecosViaAdapter(conn);

				List<Produto> produtos = ConsultarProdutos(conn);

				foreach (var produto in produtos)
				{
					Console.WriteLine(produto);
				}
				
				ConsultarProdutosDataSet(conn);
			}

			Console.Read();
		}

		private static void AtualizarPrecosViaAdapter(SqlConnection conn)
		{
			var cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM Produto";

			using (var da = new SqlDataAdapter(cmd))
			{
				var builder = new SqlCommandBuilder(da);

				builder.ConflictOption = ConflictOption.CompareRowVersion;

				da.UpdateCommand = builder.GetUpdateCommand();

				DataSet ds = new DataSet();

				da.Fill(ds);

				foreach (DataRow row in ds.Tables[0].Rows)
				{
					var preco = double.Parse(row["Preco"].ToString());

					preco += 10;

					row["Preco"] = preco;
				}

				da.Update(ds);
			}
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

		private static List<Produto> ConsultarProdutos(SqlConnection conn)
		{
			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM Produto";

			List<Produto> produtos = new List<Produto>();

			using (SqlDataReader dr = cmd.ExecuteReader())
			{
				while (dr.Read())
				{
					int id = int.Parse(dr["Id"].ToString());
					string nome = dr["Nome"].ToString();
					double preco = double.Parse(dr["Preco"].ToString());
					int quantidade = int.Parse(dr["Quantidade"].ToString());
					bool ativo = bool.Parse(dr["Ativo"].ToString());
					
					DateTime? dataPrimeiraCompra = null;

					var dataPrimeiraCompraObj = dr["DataPrimeiraCompra"];

					if (dataPrimeiraCompraObj != DBNull.Value)
					{
						dataPrimeiraCompra = DateTime.Parse(dataPrimeiraCompraObj.ToString());
					}

					var produto = new Produto();

					produto.Id = id;
					produto.Nome = nome;
					produto.Preco = preco;
					produto.Quantidade = quantidade;
					produto.Ativo = ativo;
					produto.DataPrimeiraCompra = dataPrimeiraCompra;

					produtos.Add(produto);
				}
			}

			return produtos;
		}

		private static void InserirProdutos(SqlConnection conn)
		{
			/*var cmd = new SqlCommand(@"INSERT INTO Produto (Nome, Preco, Quantidade, Ativo) 
							VALUES ('Galaxy S3', 1499, 123, 1)");

			cmd.Connection = conn;*/

			for (int i = 0; i < 1000; i++)
			{
				SqlCommand cmd = conn.CreateCommand();

				cmd.CommandText = @"INSERT INTO Produto (Nome, Preco, Quantidade, Ativo, DataPrimeiraCompra) 
										VALUES (@Nome, @Preco, @Quantidade, @Ativo, @DataPrimeiraCompra)";

				cmd.Parameters.AddWithValue("Nome", "Iphone 5");
				cmd.Parameters.AddWithValue("Preco", 2349);
				cmd.Parameters.AddWithValue("Quantidade", i);
				cmd.Parameters.AddWithValue("Ativo", true);

				object dataPrimeiraCompra;

				if (i%2 == 0)
				{
					dataPrimeiraCompra = DateTime.Now;
				}
				else
				{
					dataPrimeiraCompra = DBNull.Value;
				}

				cmd.Parameters.AddWithValue("DataPrimeiraCompra", dataPrimeiraCompra);

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