using System;
using Factory.models;

namespace Factory.lib
{
    class CreditItemFactory : Factory
    {
        public override Document createDocument()
        {
            return new CreditItem();
        }

        public override void processDocument()
        {
            base.processDocument();
            Console.WriteLine("Processing CreditItem");
        }
    }
}
