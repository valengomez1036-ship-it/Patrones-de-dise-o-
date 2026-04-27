using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoría_de_muebles
{
    public interface IChair
    {
        string GetName();
        int GetPrice();
    }

    public interface ISofa
    {
        string GetName();
        int GetPrice();
    }

    public interface ITable
    {
        string GetName();
        int GetPrice();
    }
}
