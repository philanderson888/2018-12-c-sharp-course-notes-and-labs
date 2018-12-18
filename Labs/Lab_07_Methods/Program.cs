using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTANTIATE new object p
            Parent p = new Parent();
            // static
            Parent.DoThis();
            // instance
            p.Grow();
            Console.WriteLine(p.age);
            p.Grow();
            Console.WriteLine(p.age);
            p.Grow();
            Console.WriteLine(p.age);
        }
    }
    class Parent
    {
        public int age { get; set; }
        public void Grow()
        {
            age++;
        }
        public static void DoThis() { }
    }
}
