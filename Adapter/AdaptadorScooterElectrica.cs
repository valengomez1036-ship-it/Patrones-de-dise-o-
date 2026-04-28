using System;
using System.Collections.Generic;
using System.Text;
using TallerMecanico;
using TallerMotosAdapter;

namespace TallerMecanico
{
    public class AdaptadorScooterElectrica : IMantenimientoMoto
    {
        private ScooterElectrica _scooterElectrica;

        public AdaptadorScooterElectrica(ScooterElectrica scooter)
        {
            _scooterElectrica = scooter;
        }

        public void RealizarMantenimiento()
        {
            Console.WriteLine(">>> [Adaptador] Interceptando orden y traduciendo a comandos de scooter eléctrica...");
            _scooterElectrica.DiagnosticarBateria();
            _scooterElectrica.ActualizarFirmware();
            Console.WriteLine(">>> [Adaptador] Mantenimiento de scooter finalizado.");
        }
    }
}


