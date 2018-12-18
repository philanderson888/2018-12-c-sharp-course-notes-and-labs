using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Mercedes { }

    class SClass : Mercedes { }

    class SLS : SClass { }

    // DON'T CHANGE ANY FURTHER
    sealed class SLSSport : SLS { }

    class enthusiasticEngineer : SLS { }
}
