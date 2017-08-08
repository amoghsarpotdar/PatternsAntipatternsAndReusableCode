using System;
using Builder.AbstractAndBaseFramework;
using Builder.Factories;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            Director director = new Director();
            AbstractBuilder b1 = new ConcreteBuilder1();
            AbstractBuilder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.BuildProduct();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.BuildProduct();
            p2.Show();

            Console.ReadKey();

        }
    }
}
