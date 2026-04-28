using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Te : Bebida
    {
        public override string getDescripcion()
        {
            return "Te";
        }

        public override double costo()
        {
            return 4.0;
        }
    }
}

