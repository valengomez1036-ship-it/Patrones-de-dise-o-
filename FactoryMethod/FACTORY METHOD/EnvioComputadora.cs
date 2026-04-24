using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodN
{
    public class EnvioComputador : IEnvio
    {
        public void EnviarPaquete()
        {
            Console.WriteLine("Enviando paquete mediante envio digital...");
        }
    }
}
