using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Concrete;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("A");
            ConcretePrototype2 p2 = new ConcretePrototype2("B");

            ConcretePrototype1 pc1 = (ConcretePrototype1) p1.Clone();
            ConcretePrototype2 pc2 = (ConcretePrototype2) p2.Clone();

            Console.WriteLine("Cloned : " + pc1.Id);
            Console.WriteLine("Cloned : " + pc2.Id);

            Console.ReadKey();
        }
    }
}
