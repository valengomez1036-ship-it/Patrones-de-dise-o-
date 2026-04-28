using System;
using System.Collections.Generic;
using System.Text;
using TallerMotosAdapter;

namespace TallerMecanico
{
    public class MotoGasolina : IMantenimientoMoto
    {
        public string Placa { get; set; }
        public string Marca { get; set; }

        public MotoGasolina(string placa, string marca)
        {
            Placa = placa;
            Marca = marca;
        }

        public void RealizarMantenimiento()
        {
            Console.WriteLine($"- [Moto {Marca} - {Placa}]: Cambiando aceite, revisando bujías y carburador.");
        }
    }
}