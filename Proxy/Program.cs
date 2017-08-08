using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            Concrete.Proxy proxy = new Concrete.Proxy();
            proxy.Request();

            Console.ReadKey();
        }
    }
}
