using System;
using FactoryMethod.AbstractAndBaseFramework;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
