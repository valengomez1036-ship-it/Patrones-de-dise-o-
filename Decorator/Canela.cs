using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Canela : Decorador
    {
        public Canela(Bebida b) : base(b) { }

        public override string getDescripcion()
        {
            return bebida.getDescripcion() + " + canela";
        }

        public override double costo()
        {
            return bebida.costo() + 1.5;
        }
    }
}
