using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Leche : Decorador
    {
        public Leche(Bebida b) : base(b) { }

        public override string getDescripcion()
        {
            return bebida.getDescripcion() + " + leche";
        }

        public override double costo()
        {
            return bebida.costo() + 2.0;
        }
    }
}
