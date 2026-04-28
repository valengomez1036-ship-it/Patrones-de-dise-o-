using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Chocolate : Decorador
    {
        public Chocolate(Bebida b) : base(b) { }

        public override string getDescripcion()
        {
            return bebida.getDescripcion() + " + chocolate";
        }

        public override double costo()
        {
            return bebida.costo() + 3.0;
        }
    }
}
