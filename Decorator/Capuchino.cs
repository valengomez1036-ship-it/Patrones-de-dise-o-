using System;
using System.Collections.Generic;
using System.Text;

namespace Decorater
{
    class Capuchino : Bebida 
    {
        public override string getDescripcion()
        {
            return "Capuchino";
        }

        public override double costo()
        {
            return 6.0;
        }
    }



}