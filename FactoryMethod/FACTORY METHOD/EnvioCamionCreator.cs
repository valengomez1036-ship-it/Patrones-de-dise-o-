using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodN
{
    public class EnvioCamionCreator : EnvioCreator
    {
        protected override IEnvio CrearEnvio()
        {
            return new EnvioCamion();
        }
    }
}
