namespace Modulo7.DAL
{
    using System;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    [DataObject]
    public class ClienteDAL
    {
        public DataSet ObterTodosClientes()
        {
            DataSet ds = new DataSet();

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["Default"];

            if (settings == null)
            {
                throw new Exception("Uma connectionstring com o nome Default deve ser configurada");
            }

            string connectionString = settings.ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Cliente";

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }

            return ds;
        }
    }
}
