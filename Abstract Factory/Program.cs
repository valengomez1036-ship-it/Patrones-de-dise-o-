using Factoría_de_muebles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

List<IFurniture> cart = new List<IFurniture>();

while (true)
{
    Console.WriteLine("\n===== MENÚ PRINCIPAL =====");
    Console.WriteLine("1. Elegir muebles (Victoriano, Moderno o de Lujo)");
    Console.WriteLine("2. Ver total de compras");
    Console.WriteLine("3. Salir");
    Console.Write("\nOpción: ");
    string option = Console.ReadLine();

    if (option == "3") break;

    if (option == "2")
    {
        int total = 0;
        Console.Write("\n\n");
        Console.Write("CARRITO DE COMPRAS:\n\n");

        foreach (var item in cart)
        {
            Console.WriteLine($"{item.GetName()} - ${item.GetPrice()} COP");
            total += item.GetPrice();
        }

        Console.WriteLine($"\n\nTOTAL: ${total} COP");

        continue;
    }

    IFurnitureFactory factory = null;

    Console.WriteLine("\nElige estilo:");
    Console.WriteLine("1. Victoriano");
    Console.WriteLine("2. Moderno");
    Console.WriteLine("3. Lujo");
    Console.Write("\nOpción: ");
    string style = Console.ReadLine();

    if (style == "1")
    {
        factory = new VictorianFurnitureFactory();
    }
    else if (style == "2")
    {
        factory = new ModernFurnitureFactory();
    }
    else if (style == "3")
    {
        factory = new LujoFurnitureFactory();
    }

    Console.WriteLine("\n¿Qué deseas comprar?");
    Console.WriteLine("1. Silla");
    Console.WriteLine("2. Sofá");
    Console.WriteLine("3. Mesa");
    Console.Write("\nOpción: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            var chair = factory.CreateChair();
            cart.Add((IFurniture)chair);
            Console.WriteLine($"\n\nAgregado: {chair.GetName()} - ${chair.GetPrice()} COP\n");
            break;

        case "2":
            var sofa = factory.CreateSofa();
            cart.Add((IFurniture)sofa);
            Console.WriteLine($"\n\nAgregado: {sofa.GetName()} - ${sofa.GetPrice()} COP\n");
            break;

        case "3":
            var table = factory.CreateTable();
            cart.Add((IFurniture)table);
            Console.WriteLine($"\n\nAgregado: {table.GetName()} - ${table.GetPrice()} COP\n");
            break;
    }
}

Console.WriteLine("\n Saliendo del programa...");