using System;

namespace Mixin
{
    class Program
    {
        static void Main()
        {
            var someTargetImplementingObject = new TargetImplementation();
            var someMixinClient = new MixinClient(someTargetImplementingObject);
            someMixinClient.Run();
            Console.ReadKey();
        }
    }
}
