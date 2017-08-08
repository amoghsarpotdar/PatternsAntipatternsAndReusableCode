using System;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }
}
