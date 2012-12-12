namespace MOC10265.Persistence.ADO
{
	using System;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Data.SqlClient;
	using Model;
	using Model.Repositories;

	public class ProdutoADORepository : IProdutoRepository
	{
		public List<Produto> ObterTodos()
		{
			ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["Default"];

			if (config == null)
			{
				throw new Exception("A connection string 'Default' não foi configurada");
			}

			using (var conn = new SqlConnection(config.ConnectionString))
			{
				conn.Open();

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
						byte[] versao = (byte[])dr["Versao"];

						DateTime? dataPrimeiraCompra = null;

						var dataPrimeiraCompraObj = dr["DataPrimeiraCompra"];

						if (dataPrimeiraCompraObj != DBNull.Value)
						{
							dataPrimeiraCompra = DateTime.Parse(dataPrimeiraCompraObj.ToString());
						}

						var produto = new Produto();

						produto.Id = id;
						produto.Versao = versao;
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
		}
	}
}