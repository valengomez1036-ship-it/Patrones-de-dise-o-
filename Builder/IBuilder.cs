using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBuilder  // interface el que me define el contrato
    {
        void SetParteA();  // contruye la primera parte del producto , que es el cpu
        void SetParteB(); // la segunda parte que seria la RAM 
        Computadora GetResultado();   //Esto devuelve el producto final 
    }
}
