using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_14_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            
        }
    }

    // interface to FORCE A CERTAIN BEHAVIOUR
    interface ITools
    {
        int x { get; set; }
        void MustUseThisTool1();
        void MustUseThisTool2();
    }

    class Parent { }

    // child has only one parent
    class Child : Parent, ITools
    {
        public int x { get; set; }
        public void MustUseThisTool1()
        {
            Console.WriteLine("Using tool 1");
        }

        public void MustUseThisTool2()
        {
            Console.WriteLine("using tool 2");
        }
    }
}
