using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {         
        }
    }

    class Parent
    {
        private int x;
        protected int y;
    }


    class Child : Parent
    {
        public void DoThis()
        {
            // x is private so not available in child derived class
            // this.x;
            // y is protected so is available in child
            this.y = 10;
        }
    }
}
