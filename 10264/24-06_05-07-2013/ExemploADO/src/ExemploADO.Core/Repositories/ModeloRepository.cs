namespace ExemploADO.Core.Repositories
{
	using System.Collections.Generic;
	using Model;

	public class ModeloRepository : BaseRepository, IModeloRepository
	{
		public List<Modelo> ObterTodos()
		{
			string sql = "SELECT * FROM MODELO";

			using (var conn = ObterConexao())
			{
				var cmd = conn.CreateCommand();

				cmd.CommandText = sql;

				using (var dr = cmd.ExecuteReader())
				{
					List<Modelo> modelos = new List<Modelo>();

					while (dr.Read())
					{
						Modelo modelo = new Modelo();

						modelo.Id = int.Parse(dr["Id"].ToString());
						modelo.Marca = dr["Marca"].ToString();
						modelo.Nome = dr["Nome"].ToString();

						modelos.Add(modelo);
					}

					return modelos;
				}
			}
		}
	}
}