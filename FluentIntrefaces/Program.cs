using System;

namespace FluentIntrefaces
{
    class Program
    {
        static void Main()
        {
            FluentImplementation sampleObject = new FluentImplementation();
            sampleObject.DoSomething()
                .DoSomethingElse()
                .ThisMethodIsNotFluent();
            Console.ReadKey();
        }
    }
}
