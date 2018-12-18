using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class HolidayPlans
    {
        // OK
        void DoThis() { // CODE HERE EG VISIT VENICE
        }

        // INCOMPLETE TRAVEL PLANS
        public abstract void Travel();

    }

    class HolidayPlansComplete : HolidayPlans
    {
        public override void Travel()
        {
           // code here travel plans - COMPLETE!!!
        }
    }
}
