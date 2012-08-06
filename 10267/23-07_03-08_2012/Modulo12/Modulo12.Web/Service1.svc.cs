using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Modulo12.Web
{
    using System.Diagnostics;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public int Somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public string GetData(int value)
        {
            Debug.WriteLine(value);

            if (value <= 1000)
            {
                throw new Exception("Valor deve ser maior a 1000");
            }

            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }

            Debug.WriteLine(composite.BoolValue);
            Debug.WriteLine(composite.StringValue);

            return composite;
        }
    }
}
