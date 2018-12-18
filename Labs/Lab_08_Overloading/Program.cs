using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance01 = new MyClass();
            instance01.DoThis();
            instance01.DoThis(10);
            instance01.DoThis("hi");
            // don't set values - will pick up default
            instance01.DoThisAlso();
            // set values
            instance01.DoThisAlso(100,"some string");

            // call method and get 2 outputs
            int output = instance01.DoThisSometimes(out int output2, out string output3);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
        }
    }

    class MyClass
    {
        public void DoThis() { }
        public void DoThis(int x) { }
        public void DoThis(string y) { }

        // set default values
        public void DoThisAlso(int x = 5, string y = "hello"){
            Console.WriteLine("x is {0} and y is {1}",x,y);
        }

        public int DoThisSometimes(out int y, out string z)
        {
            y = 200;
            z = "some more data output here";
            return 100;
        }
    }

   
}
