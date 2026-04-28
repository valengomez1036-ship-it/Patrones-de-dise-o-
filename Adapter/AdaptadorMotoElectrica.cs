using System;
using System.Collections.Generic;
using System.Text;
using TallerMotosAdapter;

    namespace TallerMecanico
    {
        public class AdaptadorMotoElectrica : IMantenimientoMoto
        {
            private MotoElectrica _motoElectrica;

            public AdaptadorMotoElectrica(MotoElectrica moto)
            {
                _motoElectrica = moto;
            }

            public void RealizarMantenimiento()
            {
                Console.WriteLine(">>> [Adaptador] Interceptando orden y traduciendo a comandos eléctricos...");
                _motoElectrica.DiagnosticarBateria();
                _motoElectrica.ActualizarFirmware();
                Console.WriteLine(">>> [Adaptador] Mantenimiento eléctrico finalizado.");
            }
        }
    }