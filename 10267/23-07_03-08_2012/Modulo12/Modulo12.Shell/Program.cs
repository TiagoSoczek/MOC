using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo12.Shell
{
    using System.ServiceModel;

    using Modulo12.Shell.ServiceReference1;

    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            try
            {
                string retorno = client.GetData(1232);
                
                Console.WriteLine(retorno);
            }
            catch (EndpointNotFoundException e)
            {
                Console.WriteLine("Servidor desligado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu algo errado");
            }
            finally
            {
                Console.WriteLine("Finalizou");
            }
            
            Console.Read();
        }
    }
}
