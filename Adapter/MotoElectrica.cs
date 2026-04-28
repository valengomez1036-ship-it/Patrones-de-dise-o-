using System;
using System.Collections.Generic;
using System.Text;

namespace TallerMecanico
{
    public class MotoElectrica
    {
        public string Placa { get; set; }
        public float NivelBateria { get; set; }

        public MotoElectrica(string placa, float bateria)
        {
            Placa = placa;
            NivelBateria = bateria;
        }

        public void DiagnosticarBateria()
        {
            Console.WriteLine($"- [Moto Eléctrica {Placa}]: Escaneando batería. Nivel al {NivelBateria}%.");
        }

        public void ActualizarFirmware()
        {
            Console.WriteLine($"- [Moto Eléctrica {Placa}]: Instalando actualización de software del motor.");
        }
    }
}