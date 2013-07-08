namespace ExemploADO.Core.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Data.SqlClient;
	using Model;

	public class CarroRepository : BaseRepository, ICarroRepository
	{
		public List<Carro> ObterPorMarca(string marca)
		{
			DataSet ds = new DataSet();

			using (var conn = ObterConexao())
			{
				var cmd = conn.CreateCommand();

				string sql = @"SELECT * FROM Carro C
	INNER JOIN Modelo M
		ON C.IdModelo = M.Id
WHERE
	M.Marca LIKE @marca";

				cmd.CommandText = sql;

				cmd.Parameters.AddWithValue("marca", marca);

				SqlDataAdapter da = new SqlDataAdapter(cmd);

				da.Fill(ds);
			}

			List<Carro> carros = new List<Carro>();

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				Carro carro = new Carro
				{
					Id = int.Parse(row["Id"].ToString()),
					AnoFabricacao = int.Parse(row["AnoFabricacao"].ToString()),
					AnoModelo = int.Parse(row["AnoModelo"].ToString()),
					CadastradoEm = (DateTime)row["CadastradoEm"],
					Cor = (CorCarro)row["Cor"],
					Modelo = new Modelo
					{
						Marca = row["Marca"].ToString(),
						Nome = row["Nome"].ToString()
					}
				};

				carros.Add(carro);
			}

			return carros;
		}
	}
}