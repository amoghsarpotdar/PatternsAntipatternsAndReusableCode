using System;
using System.Collections.Generic;

namespace BasicConstructs
{
    class Program
    {
        static void Main()
        {
            TestType1 t1 = new TestType1();
            TestType2 t2 = new TestType2();

            Console.WriteLine("Attempting generic function on t1 and t2");
            OutputThing(t1);
            OutputThing(t2);
            Console.WriteLine("Attempting generic function on string 'S'");
            OutputThing("S");
            Console.WriteLine("Attempting with func<type>(param) syntax - this enforces type checking at compile time as well...");
            // ReSharper disable once RedundantTypeArgumentsOfMethod
            //Note that compiler performs type inference for this line, you cant pass in wrong parameter values.
            OutputThing<string>("S");
            //Console.WriteLine("...and this fails if uncommented...");
            //OutputThing<string>(1);

            Console.WriteLine("The real power of generics");
            Console.WriteLine("Here is how c# can use function pointers - using the delegates!");
            string[] names = {
                "Pune",
                "Mumbai",
                "Delhi",
                "Chennai",
                "London",
                "Swindon"
            };

            //The line below declares an action target (in c++ terms, its a function pointer).
            //This action target defines function address our 'Apply' function needs to call.
            //Notice how this code works without any side effects and without any dependency
            //on external state maintenance. The 'Apply' function works only based on supplied
            //parameters, without maintaining any class or module level state variables or
            //any external resource, etc. If 'Apply' method calls another function directly
            //this sort of builds a hard bound dependency on that function, instead this method
            //intentionally takes a delegate (or function pointer) as a parameter, which means
            //calling code can define target method to be invoked.
            Action<string> messageTarget = delegate(string s) { PrintOnConsole(s); };
            Apply(names,messageTarget);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        /// <summary>
        /// This is our 'Action' function.
        /// </summary>
        /// <param name="message"></param>
        public static void PrintOnConsole(string message)
        {
            Console.WriteLine("PrintOnConsole::" + message);
        }

        /// <summary>
        /// Generic functions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="thing"></param>
        static void OutputThing<T>(T thing)
        {
            Console.WriteLine("Thing: {0}", thing);
        }

        /// <summary>
        /// This method is an example of a functional implementation which neither cares about
        /// type being implemented on, nor about the action that gets executed for that type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence">List of items to be processed</param>
        /// <param name="action">Target action to be executed on individual item(s)</param>
        static void Apply<T>(IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence)
            {
                action(item);
            }
        }
    }
}
