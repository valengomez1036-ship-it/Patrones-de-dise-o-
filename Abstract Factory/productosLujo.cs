using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoría_de_muebles
{
    public class LujoChair : IChair, IFurniture
    {
        public string GetName() => "Silla de Lujo";
        public int GetPrice() => 50000;
    }

    public class LujoSofa : ISofa, IFurniture
    {
        public string GetName() => "Sofá de Lujo";
        public int GetPrice() => 80000;
    }

    public class LujoTable : ITable, IFurniture
    {
        public string GetName() => "Mesa de Lujo";
        public int GetPrice() => 350000;
    }
}

