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
            Console.WriteLine("Looping with for loop");
            targetInstance.LoopingWithoutLinq();
            //This method implements looping with the help of linq functions.
            Console.WriteLine("Looping with linq");
            targetInstance.LoopingWithLinq();

            //This method applies a condition when running through the loops.
            Console.WriteLine("Conditional looping with for loop");
            targetInstance.ConditionalLoopingWithLinq();
            Console.WriteLine("Conditional looping with linq");
            //This method filters elements of an array based on condition into another array.
            targetInstance.ConditionalFilteringWithLinq();

            Console.WriteLine("Aggregate condition check using for loop");
            targetInstance.CheckAggregateConditionWithForLoop();
            Console.WriteLine("Aggregate condition check using linq");
            targetInstance.CheckAggregateConditionWithLinq();

            Console.WriteLine("Elements extraction using for loop");
            targetInstance.ExtractNElementsWithForLoop();
            Console.WriteLine("Elements extraction using linq");
            targetInstance.ExtractNElementsWithLinq();

            Console.WriteLine("Array intersection using for loop");
            targetInstance.GetArrayIntersectionWithForLoop();
            Console.WriteLine("Array intersection using linq");
            targetInstance.GetArrayIntersectionWithLinq();

            targetInstance.ContentConcatinationWithForLoop();
            targetInstance.ContentConcatinationWithLinq();
            Console.ReadKey();
        }
    }
}
