using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target();
            target.Request();


            TargetAdapter targetAdapter = new TargetAdapter();
            targetAdapter.Request();
            Console.ReadKey();
        }
    }
}
