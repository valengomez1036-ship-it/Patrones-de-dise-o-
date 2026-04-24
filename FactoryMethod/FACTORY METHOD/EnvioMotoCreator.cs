using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodN
{
    public class EnvioMotoCreator : EnvioCreator
    {
        protected override IEnvio CrearEnvio()
        {
            return new EnvioMoto();
        }
    }
}
