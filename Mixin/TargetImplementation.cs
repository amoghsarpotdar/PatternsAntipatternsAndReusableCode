using System;

namespace Mixin
{
    class TargetImplementation:ITargetInterface
    {
        public void DoSomeWork()
        {
            Console.WriteLine("This is the default implementation provided by TargetImplementation class.");
        }
    }
}
