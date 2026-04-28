using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class ChipsChocolate : Decorador
    {
        public ChipsChocolate(Bebida b) : base(b) { }

        public override string getDescripcion()
        {
            return bebida.getDescripcion() + " + chips de chocolate";
        }

        public override double costo()
        {
            return bebida.costo() + 2.5;
        }
    }
}

