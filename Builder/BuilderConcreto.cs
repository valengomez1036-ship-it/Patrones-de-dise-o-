using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderConcreto : IBuilder   //esta clase implementa la interfaz Ibuilder
    {
        private Computadora computadora; //El private se utiliza porque solo el builder la puede modificar
                                         //Aqui se guarda la computadora que se esta construyendo
        public BuilderConcreto()     //constructor de la clase 
        {
            computadora = new Computadora();  //se cra la nueva computadora vacia
        }

        public void SetParteA()   //implementa el metodo de la interfaz
        {                          //Y se construye una parte del producto que seria la cpu
            computadora.CPU = "Intel i7";  //asigna el valor de la CPU
        }

        public void SetParteB() //Aqui se construye la otra parte , la RAM
        {
            computadora.RAM = "16GB";  // Asigna valor a la RAM
        } 

        public Computadora GetResultado()
        {
            return computadora;    //Devuelve el producto
        }
    }
}
