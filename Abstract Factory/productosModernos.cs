using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoría_de_muebles
{
    public class ModernChair : IChair, IFurniture
    {
        public string GetName() => "Silla Moderna";
        public int GetPrice() => 250000;
    }

    public class ModernSofa : ISofa, IFurniture
    {
        public string GetName() => "Sofá Moderno";
        public int GetPrice() => 700000;
    }

    public class ModernTable : ITable, IFurniture
    {
        public string GetName() => "Mesa Moderna";
        public int GetPrice() => 450000;
    }
}
