using Factory.models;
using System;

namespace Factory.lib
{
    abstract class Factory
    {
        public abstract Document createDocument();
        public virtual void processDocument()
        {
            Document document = createDocument();
            if (!document.isValid())
                throw new ArgumentException("Document is not valid!");
            // Do something (book, calc, print, ...)
            Console.WriteLine("Document processed");
        }
    }
}
