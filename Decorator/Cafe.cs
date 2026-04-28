using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Cafe : Bebida
    {
        public override string getDescripcion()
        {
            return "Cafe";
        }

        public override double costo()
        {
            return 5.0;
        }
    }
}
