using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_Entity
{
    class Program
    {

        // pull in database here.  DBContext is our DB object.
        static NorthwindEntities DBContext = new NorthwindEntities();

        static void Main(string[] args)
        {
            foreach (Lab_16_Entity.Customer customer in DBContext.Customers)
            {
              //  Console.WriteLine("{0} lives in {1}",customer.ContactName,customer.City );
            }


            var customers =
                from c in DBContext.Customers
                select c;

            foreach (Customer c in customers)
            {
             //   Console.WriteLine("{0} lives in {1}", c.ContactName, c.City);
            }

            var customers2 =
                  from c in DBContext.Customers
                  where c.City=="Berlin"
                    select c;
            foreach (Customer c in customers2)
            {
                //Console.WriteLine("{0} lives in {1}", c.ContactName, c.City);
            }

            var singleCustomer = DBContext.Customers.First(c => c.Country == "Finland");
            Console.WriteLine(singleCustomer.ContactName);

            singleCustomer.ContactName += "Fred";

            DBContext.SaveChanges();
        }



    }

    partial class Customer
    {
        public bool likesCola;
    }
}
