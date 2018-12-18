using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12a_Polymorphism
{
    class Program
    {
        static void Main()
        {
            Parent p = new Parent();
            p.HaveAParty();
            Child Bobby = new Child();
            Bobby.HaveAParty();
            Teenager Rob = new Teenager();
            Rob.HaveAParty();


        }
    }


    class Parent {
        // parent IMPLEMENTATION
        // VIRTUAL MEANS 'can override'
        internal virtual void HaveAParty() {
            Console.WriteLine("having a dinner party!");
        }
    }
    class Child : Parent {
        internal override void HaveAParty()
        {
            Console.WriteLine("Child is having a party");
        }
    }
    class Teenager : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Teenager is having a party");
            base.HaveAParty();
        }
    }



}
