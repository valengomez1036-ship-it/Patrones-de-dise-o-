using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Licor : Decorador
    {
        public Licor(Bebida b) : base(b) { }

        public override string getDescripcion()
        {
            return bebida.getDescripcion() + " + licor";
        }

        public override double costo()
        {
            return bebida.costo() + 4.0;
        }
    }
}
