using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director    //ESto da la ordenes de construccion
    {
        public void Construir(IBuilder builder)  //Este método va a construir algo, usando cualquier objeto que cumpla con IBuilder
        {                                        //Ibuilder ... recibe el objeto que implementa la interfaz 
            builder.SetParteA();  //El director define el orden de construccion
                                  //define en el orden de construccion
            builder.SetParteB();    //primeo la CPU y luego la RAM
        }
    }
}
