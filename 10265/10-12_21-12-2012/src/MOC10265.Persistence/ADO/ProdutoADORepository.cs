namespace MOC10265.Persistence.ADO
{
	using System;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Data;
	using System.Data.SqlClient;
	using Model;
	using Model.Repositories;

	public class ProdutoADORepository : IProdutoRepository
	{
		public List<Produto> ObterTodos()
		{
			using (SqlConnection conn = ObterConexao())
			{
				SqlCommand cmd = conn.CreateCommand();

				cmd.CommandText = "SELECT * FROM Produto";

				var produtos = new List<Produto>();

				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						Produto produto = LerProduto(dr);

						produtos.Add(produto);
					}
				}

				return produtos;
			}
		}

		public Produto ObterPorId(int id)
		{
			using (SqlConnection conn = ObterConexao())
			{
				return ObterPorId(id, conn);
			}
		}

		public void Remover(int id)
		{
			using (SqlConnection conn = ObterConexao())
			{
				SqlCommand cmd = conn.CreateCommand();

				cmd.CommandText = "DELETE Produto WHERE Id = @Id";

				cmd.Parameters.AddWithValue("Id", id);

				cmd.ExecuteNonQuery();
			}
		}

		public Produto Atualizar(Produto produto)
		{
			using (SqlConnection conn = ObterConexao())
			{
				SqlCommand cmd = conn.CreateCommand();

				cmd.CommandText = @"UPDATE PRODUTO SET 
								Nome = @Nome, Preco = @Preco, 
								Quantidade = @Quantidade, Ativo = @Ativo, 
								DataPrimeiraCompra = @DataPrimeiraCompra
								WHERE Id = @Id AND Versao = @Versao";

				cmd.Parameters.AddWithValue("Id", produto.Id);
				cmd.Parameters.AddWithValue("Versao", produto.Versao);
				cmd.Parameters.AddWithValue("Nome", produto.Nome);
				cmd.Parameters.AddWithValue("Preco", produto.Preco);
				cmd.Parameters.AddWithValue("Quantidade", produto.Quantidade);
				cmd.Parameters.AddWithValue("Ativo", produto.Ativo);
				object dataPrimeiraCompra = produto.DataPrimeiraCompra;

				if (dataPrimeiraCompra == null)
				{
					dataPrimeiraCompra = DBNull.Value;
				}

				cmd.Parameters.AddWithValue("DataPrimeiraCompra", dataPrimeiraCompra);

				int registrosAfetados = cmd.ExecuteNonQuery();

				if (registrosAfetados == 0)
				{
					throw new Exception("Problema de concorrência, o Produto já foi atualizado");
				}

				return ObterPorId(produto.Id, conn);
			}
		}

		public Produto Inserir(Produto produto)
		{
			using (SqlConnection conn = ObterConexao())
			{
				SqlCommand cmd = conn.CreateCommand();

				cmd.CommandText = @"INSERT PRODUTO (Nome, Preco, Quantidade,
								Ativo, DataPrimeiraCompra) VALUES 
								(@Nome, @Preco, @Quantidade,
								@Ativo, @DataPrimeiraCompra);
								SELECT @Id = SCOPE_IDENTITY();";

				cmd.Parameters.AddWithValue("Nome", produto.Nome);
				cmd.Parameters.AddWithValue("Preco", produto.Preco);
				cmd.Parameters.AddWithValue("Quantidade", produto.Quantidade);
				cmd.Parameters.AddWithValue("Ativo", produto.Ativo);

				object dataPrimeiraCompra = produto.DataPrimeiraCompra;

				if (dataPrimeiraCompra == null)
				{
					dataPrimeiraCompra = DBNull.Value;
				}

				cmd.Parameters.AddWithValue("DataPrimeiraCompra", dataPrimeiraCompra);

				var parameterId = new SqlParameter();

				parameterId.ParameterName = "Id";
				parameterId.DbType = DbType.Int32;
				parameterId.Direction = ParameterDirection.Output;

				cmd.Parameters.Add(parameterId);

				cmd.ExecuteNonQuery();

				int id = int.Parse(parameterId.Value.ToString());

				return ObterPorId(id, conn);
			}
		}

		public List<Produto> PesquisarProdutos(string termo, int qtdeRegistros)
		{
			throw new NotImplementedException();
		}

		private SqlConnection ObterConexao()
		{
			ConnectionStringSettings config = ConfigurationManager.ConnectionStrings["Default"];

			if (config == null)
			{
				throw new Exception("A connection string 'Default' não foi configurada");
			}

			var conn = new SqlConnection(config.ConnectionString);

			conn.Open();

			return conn;
		}

		private Produto LerProduto(SqlDataReader dr)
		{
			int id = int.Parse(dr["Id"].ToString());
			string nome = dr["Nome"].ToString();
			decimal preco = decimal.Parse(dr["Preco"].ToString());
			int quantidade = int.Parse(dr["Quantidade"].ToString());
			bool ativo = bool.Parse(dr["Ativo"].ToString());
			var versao = (byte[]) dr["Versao"];

			DateTime? dataPrimeiraCompra = null;

			object dataPrimeiraCompraObj = dr["DataPrimeiraCompra"];

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
			return produto;
		}

		private Produto ObterPorId(int id, SqlConnection conn)
		{
			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM Produto WHERE Id = @Id";

			cmd.Parameters.AddWithValue("Id", id);

			using (SqlDataReader dr = cmd.ExecuteReader())
			{
				if (dr.Read())
				{
					Produto produto = LerProduto(dr);

					return produto;
				}

				return null;
			}
		}
	}
}