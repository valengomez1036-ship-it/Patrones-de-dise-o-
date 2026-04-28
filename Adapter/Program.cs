using System;
using TallerMecanico;

namespace TallerMotosAdapter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== TALLER DE MOTOS 'DESBIELADO' ===\n");

            AdministradorTaller jefeTaller = new AdministradorTaller("Ernesto");

            //MOTO NORMAL
            Console.WriteLine(">>> INGRESANDO MOTO A GASOLINA:");
            MotoGasolina motoNormal = new MotoGasolina("XYZ-123", "Yamaha");
            jefeTaller.OrdenarReparacion(motoNormal);

            Console.WriteLine("\n------------------------------------------------");

            //MOTO ELÉCTRICA
            Console.WriteLine(">>> INGRESANDO MOTO ELÉCTRICA:");
            MotoElectrica motoElectrica = new MotoElectrica("ELEC-99", 85.5f);

            AdaptadorMotoElectrica adaptador = new AdaptadorMotoElectrica(motoElectrica);
            jefeTaller.OrdenarReparacion(adaptador);

            Console.WriteLine("\n------------------------------------------------");

            // SCOOTER ELÉCTRICA
            Console.WriteLine(">>> INGRESANDO SCOOTER ELÉCTRICA:");
            ScooterElectrica scooterElectrica = new ScooterElectrica("SCOOT-77", 92.3f);

            AdaptadorScooterElectrica adaptadorScooter = new AdaptadorScooterElectrica(scooterElectrica);
            jefeTaller.OrdenarReparacion(adaptadorScooter);

            Console.ReadLine();
        }
    }
}