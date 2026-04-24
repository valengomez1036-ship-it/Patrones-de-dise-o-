using System;
using Builder;

class Program
{
    static void Main(string[] args)   //inicio del programa 
    { 
        BuilderConcreto builder = new BuilderConcreto();   //Crea el builder concreto que construira la computadora 
        Director director = new Director();   //crea el director

        director.Construir(builder);  //el director , usa este builder para construir la commputadora
                                      //Que se construye la parte a y la parte b 
        Computadora resultado = builder.GetResultado();   //obtiene le producto final construido

        resultado.Mostrar();   //lo que se ve en la consola 

        Console.ReadKey();   // hace que la consola no se cierre inmediatamente
    }
}