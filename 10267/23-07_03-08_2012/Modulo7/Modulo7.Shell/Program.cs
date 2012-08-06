namespace Modulo7.Shell
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;

    using Modulo7.DAL;

    public class Program
    {
        public static void Main(string[] args)
        {
            WiseEntities dbContext = new WiseEntities();

            List<Cliente> clientes = dbContext.Cliente.Take(100).ToList();
                
            clientes = clientes.Where(c => c.Id >= 1500 && c.Id <= 2000).ToList();

            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.Id);
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.DataNascimento);

                dbContext.DeleteObject(cliente);
            }

            for (int i = 0; i < 1000; i++)
            {
                Cliente cliente = new Cliente();

                cliente.Nome = "Cliente-" + i;
                cliente.DataNascimento = DateTime.Now;

                dbContext.AddToCliente(cliente);
            }

            dbContext.SaveChanges();
        }

        public static void MainADO(string[] args)
        {
            ClienteDAL dal = new ClienteDAL();

            DataSet dsClientes = dal.ObterTodosClientes();

            return;

            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Wise;Integrated Security=True;Pooling=False"))
            {
                con.Open();

                SqlCommand cmdLimpeza = con.CreateCommand();

                cmdLimpeza.CommandText = "DELETE Cliente";

                int registrosExcluidos = cmdLimpeza.ExecuteNonQuery();

                ExecutarUsandoCommandBuilder(con);

                SqlCommand cmdInsercao = con.CreateCommand();

                cmdInsercao.CommandText = @"INSERT INTO CLIENTE 
                    (Nome, DataNascimento) VALUES 
                    (@Nome, @DataNascimento)";

                cmdInsercao.Parameters.AddWithValue("Nome", "Tiago");
                cmdInsercao.Parameters.AddWithValue("DataNascimento",
                            DateTime.Now);

                cmdInsercao.ExecuteNonQuery();

                SqlCommand cmdUpdate = con.CreateCommand();

                cmdInsercao.CommandText = @"INSERT INTO CLIENTE 
                    (Nome, DataNascimento) VALUES 
                    (@Nome, @DataNascimento)";

                cmdInsercao.Parameters.AddWithValue("Nome", "Tiago");
                cmdInsercao.Parameters.AddWithValue("DataNascimento",
                            DateTime.Now);

                cmdInsercao.ExecuteNonQuery();

                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = @"SELECT * FROM Cliente";

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("Id:" + row["Id"]);
                Console.WriteLine("Nome:" + row["Nome"]);
                Console.WriteLine("DataNascimento:" + row["DataNascimento"]);
                Console.WriteLine("DataNascimento:{0:D}", row["DataNascimento"]);
                Console.WriteLine("DataNascimento:{0:d}", row["DataNascimento"]);
                Console.WriteLine("{0}:{1:d}", "DataNascimento", row["DataNascimento"]);
            }

            /*foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.WriteLine("{0}:{1}", 
                            column.ColumnName, row[column]);
                    }
                }
            }*/

            /* using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Console.WriteLine(dr["Id"]);
                    Console.WriteLine(dr["Nome"]);
                    Console.WriteLine(dr["DataNascimento"]);
                    Console.WriteLine("---------");

                    Thread.Sleep(TimeSpan.FromSeconds(10));
                }
            }*/


            Console.ReadLine();
        }

        private static void ExecutarUsandoCommandBuilder(SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM CLIENTE", con);

            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);

            SqlCommand insertCommand = cmdBuilder.GetInsertCommand();

            insertCommand.Parameters["@p1"].Value = "Via Command Builder";
            insertCommand.Parameters["@p2"].Value = DateTime.Now;

            insertCommand.ExecuteNonQuery();
        }
    }
}
