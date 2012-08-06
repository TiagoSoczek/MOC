namespace Modulo7.Tests
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class Program
    {
/*
        public static void Main(string[] args)
        {
            RemoverUsuarios();
        }
*/

        public static void RemoverUsuarios()
        {
            using (var con = ObterConexao())
            {
                var cmd = con.CreateCommand();

                cmd.CommandText = "DELETE Usuario";

                var affectedRows = cmd.ExecuteNonQuery();

                Console.WriteLine("{0} usuários removidos", affectedRows);
            }

            Console.Read();
        }

        public static void LerUsuarios_Conectado()
        {
            using (var con = ObterConexao())
            {
                var cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Usuario";

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("Email: {0}", dr["Email"]);
                        Console.WriteLine("Senha: {0}", dr["Senha"]);
                        Console.WriteLine("-----------");
                    }
                }
            }

            Console.Read();
        }

        public static void LerUsuarios_Desconectado()
        {
            DataSet ds = new DataSet();

            using (var con = ObterConexao())
            {
                var cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Usuario";

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine("{0}: {1}", column.ColumnName, row[column.ColumnName]);
                    }
                }
            }

            Console.Read();
        }

        public static void CriarUsuario()
        {
            var con = ObterConexao();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = @"INSERT INTO Usuario (Email, Senha)
                                    VALUES (@email, @senha);";

            cmd.Parameters.AddWithValue("email", "tiagosoczek@gmail.com");
            cmd.Parameters.AddWithValue("senha", "trólóló");

            int affectedRows = cmd.ExecuteNonQuery();

            Console.WriteLine("Registros afetados {0}", affectedRows);
        }

        private static SqlConnection ObterConexao()
        {
            string connectionString =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=MOC10267;Integrated Security=True;Pooling=False";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            return con;
        }
    }
}
