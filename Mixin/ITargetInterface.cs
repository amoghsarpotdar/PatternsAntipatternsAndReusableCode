using System;

namespace Mixin
{
    public interface ITargetInterface
    {
        void DoSomeWork();
    }

    //An extension of duck typing is the concept of the mixin. A mixin is a class that contains
    //the implementations from multiple other classes, without using implementation inheritance.
    public static class MixinExtensions
    {
        public static void FirstExtensionMethod(this ITargetInterface target)
        {
            Console.WriteLine("The first extension method was called.");
        }

        public static void SecondExtensionMethod(this ITargetInterface target)
        {
            Console.WriteLine("The second extension method was called.");
        }
    }
}
