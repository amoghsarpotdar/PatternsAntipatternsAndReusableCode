using System;
using Template.AbstractAndBaseFramework;
using Template.Concrete;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass ab1 = new ConcreteClassA();
            ab1.TemplateMethod();

            AbstractClass ab2 = new ConcreteClassB();
            ab2.TemplateMethod();

            Console.ReadKey();
        }
    }
}
