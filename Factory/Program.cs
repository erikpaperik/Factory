using System;
using Factory.lib;
using Factory.models;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditItemFactory factory = new CreditItemFactory();
            //Document ci = factory.createDocument();
            //ci.setReceiptNo(12);            
            //Console.WriteLine(ci.isValid().ToString());

            factory.processDocument();

            Console.ReadKey();

        }
    }
}
