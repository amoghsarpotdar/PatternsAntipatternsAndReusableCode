using System;

namespace RefactoringWithLinq
{
    class Program
    {
        static void Main()
        {
            Target targetInstance = new Target();
            targetInstance.ResetState();

            //This method implements raw way of looping through elements in array.
            targetInstance.LoopingWithoutLinq();
            //This method implements looping with the help of linq functions.
            targetInstance.LoopingWithLinq();
            //This method applies a condition when running through the loops.
            targetInstance.ConditionalLoopingWithLinq();
            //This method filters elements of an array based on condition into another array.
            targetInstance.ConditionalFilteringWithLinq();

            Console.ReadKey();
        }
    }
}
