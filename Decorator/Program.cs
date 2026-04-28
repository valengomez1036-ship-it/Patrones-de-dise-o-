using Decorater;

class Program
{
    static void Main()
    {
        Bebida bebida = null;

        Console.WriteLine("Seleccione una bebida:");
        Console.WriteLine("1. Cafe ($5)");
        Console.WriteLine("2. Te ($4)");
        Console.WriteLine("3. Capuchino ($6)");
        Console.Write("Opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
            bebida = new Cafe();
        else if (opcion == 2)
            bebida = new Te();
        else if (opcion == 3)
            bebida = new Capuchino();
        else
        {
            Console.WriteLine("Opcion invalida");
            return;
        }

        Console.WriteLine("\nSeleccione las adiciones que desee (separadas por coma):");
        Console.WriteLine("1. Leche (+$2)");
        Console.WriteLine("2. Chocolate (+$3)");
        Console.WriteLine("4. Chips de Chocolate (+$2.5)");
        Console.WriteLine("5. Licor (+$4)");
        Console.Write("Ejemplo: 1,2,3 -> ");

        string entrada = Console.ReadLine();
        string[] opciones = entrada.Split(',');

        foreach (string op in opciones)//se recorre la lista creada
        {
            int opAdicion;
            if (int.TryParse(op.Trim(), out opAdicion))// se lee lo ingresado, es un numero y se guarda
            {
                switch (opAdicion)
                {
                    case 1:
                        bebida = new Leche(bebida);
                        break;
                    case 2:
                        bebida = new Chocolate(bebida);
                        break;
                    case 3:
                        bebida = new Canela(bebida);
                        break;
                    case 4:
                        bebida = new ChipsChocolate(bebida);
                        break;
                    case 5:
                        bebida = new Licor(bebida);
                        break;

                }
            }
        }

        Console.WriteLine("\n RESULTADO FINAL ");
        Console.WriteLine("Pedido: " + bebida.getDescripcion());
        Console.WriteLine("Costo total: $" + bebida.costo());
    }
}

