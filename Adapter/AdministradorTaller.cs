using System;
using System.Collections.Generic;
using System.Text;


namespace TallerMotosAdapter
{
    public class AdministradorTaller
    {
        public string Nombre { get; set; }

        public AdministradorTaller(string nombre)
        {
            Nombre = nombre;
        }

        public void OrdenarReparacion(IMantenimientoMoto moto)
        {
            Console.WriteLine($"\n[{Nombre}] ordena: Iniciar mantenimiento...");
            moto.RealizarMantenimiento();
        }
    }
}