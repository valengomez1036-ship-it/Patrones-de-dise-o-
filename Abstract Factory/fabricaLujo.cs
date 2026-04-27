using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factoría_de_muebles;

namespace Factoría_de_muebles
{
    public  class LujoFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new LujoChair();
        public ISofa CreateSofa() => new LujoSofa();
        public ITable CreateTable() => new LujoTable();
    }
}



