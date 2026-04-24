using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Computadora   //Builder representa el Producto que se esta contruyendo
    {
        public string CPU { get; set; }
        public string RAM { get; set; }

        public void Mostrar() //Sirve para mostrar la infromacipon en consola 
        {
            Console.WriteLine("Computadora construida");
            Console.WriteLine("CPU: " + CPU);
            Console.WriteLine("RAM: " + RAM);
        }
    }
}
