using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.DoThis();

            
        }
    }

    public abstract class Parent
    {
        public abstract void DoThis();
    }

    // concrete class
    class Child : Parent
    {
        public override void DoThis() { }
    }

    class Real : Child, IComparable
    {
        public int CompareTo(object real)
        {
            return 1;
        }
    }
}
