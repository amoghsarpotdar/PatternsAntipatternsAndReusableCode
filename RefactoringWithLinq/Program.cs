using System;

namespace RefactoringWithLinq
{
    class Program
    {
        static void Main()
        {
            Target targetInstance = new Target();
            targetInstance.ResetState();

            targetInstance.LoopingWithoutLinq();
            targetInstance.LoopingWithLinq();
            targetInstance.ConditionalLoopingWithLinq();
            targetInstance.ConditionalFilteringWithLinq();

            Console.ReadKey();
        }
    }
}
