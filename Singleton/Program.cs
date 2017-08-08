using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            AbstractAndBaseFramework.Singleton s1 = AbstractAndBaseFramework.Singleton.Instance();
            AbstractAndBaseFramework.Singleton s2 = AbstractAndBaseFramework.Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Console.ReadKey();
        }
    }
}
