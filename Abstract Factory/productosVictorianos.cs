using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoría_de_muebles
{
    public class VictorianChair : IChair, IFurniture
    {
        public string GetName() => "Silla Victoriana";
        public int GetPrice() => 350000;
    }

    public class VictorianSofa : ISofa, IFurniture
    {
        public string GetName() => "Sofá Victoriano";
        public int GetPrice() => 900000;
    }

    public class VictorianTable : ITable, IFurniture
    {
        public string GetName() => "Mesa Victoriana";
        public int GetPrice() => 600000;
    }
}
