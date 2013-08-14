using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo9.Shell
{
	using System.Data.SqlClient;

	class Program
	{
		static void Main(string[] args)
		{
			var connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Wise10267;Integrated Security=True;Pooling=False";

			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();

				// var cmd = new SqlCommand("SQL", conn);

				var cmd = conn.CreateCommand();

				cmd.CommandText = @"INSERT INTO Produto 
								(Nome, Preco, Ativo) VALUES
								(@nome, @preco, @ativo)";

				cmd.Parameters.AddWithValue("nome", "Atari Jaguar");
				cmd.Parameters.AddWithValue("preco", 900.50);
				cmd.Parameters.AddWithValue("ativo", true);

				int registrosAfetados = cmd.ExecuteNonQuery();

				Console.WriteLine(registrosAfetados);

				var cmdConsulta = conn.CreateCommand();

				cmdConsulta.CommandText = "SELECT * FROM Produto";

				using (SqlDataReader dr = cmdConsulta.ExecuteReader())
				{
					while (dr.Read())
					{
						Console.WriteLine("Nome: {0}", dr["Nome"]);
						Console.WriteLine("Preço: {0:c}", dr["Preco"]);
						Console.WriteLine("Ativo: {0}", dr["Ativo"]);
					}
				}
			}

			using (LeitorDeArquivos la = new LeitorDeArquivos())
			{
				Console.WriteLine("LeitorDeArquivos:Internal");
			}

			Console.ReadLine();
		}
	}

	public class LeitorDeArquivos : IDisposable
	{
		public LeitorDeArquivos()
		{
			Console.WriteLine("LeitorDeArquivos:Construtor");
		}

		public void Dispose()
		{
			Console.WriteLine("LeitorDeArquivos:Dispose");
		}
	}
}
