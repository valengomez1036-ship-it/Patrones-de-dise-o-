using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodN
{
    public abstract class EnvioCreator
    {
        // Factory Method
        protected abstract IEnvio CrearEnvio();

        public void ProcesarEnvio()
        {
            IEnvio envio = CrearEnvio(); // llama al factory method
            envio.EnviarPaquete();
        }
    }
}
