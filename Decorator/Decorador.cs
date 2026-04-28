using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    abstract class Decorador : Bebida
    {
        protected Bebida bebida;

        public Decorador(Bebida b)
        {
            bebida = b;
        }
    }
}
