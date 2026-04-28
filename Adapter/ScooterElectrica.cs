using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanico
{
    public class ScooterElectrica
    { 
        public string Placa { get; set; }
        public float NivelBateria { get; set; }

        public ScooterElectrica(string placa, float bateria)
        {
            Placa = placa;
            NivelBateria = bateria;
        }

        public void DiagnosticarBateria()
        {
            Console.WriteLine($"- [Scooter Eléctrica {Placa}]: Escaneando batería. Nivel al {NivelBateria}%.");
        }

        public void ActualizarFirmware()
        {
            Console.WriteLine($"- [Scooter Eléctrica {Placa}]: Instalando actualización de software.");
        }
    }
}

