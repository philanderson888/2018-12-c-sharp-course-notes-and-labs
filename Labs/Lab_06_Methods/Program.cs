using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // invoking
            DoThis();
            DoThis();
            DoThis();
            DoThisAlso();
 

            // declaring
            void DoThis()
            {
                Console.WriteLine("Doing nothing");
            }
            Mercedes.EngineSize();
            double d = Mercedes.MaxEngineSpeed;
        }

        // static method : invoke with CLASS.METHOD()
        static void DoThisAlso()
        {

        }

    }

    class Mercedes
    {
        public static double MaxEngineSpeed = 2000;
        public static void EngineSize() { }
    }
}
