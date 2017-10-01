using System;

namespace DuckTyping
{
    class Program
    {
        static void Main()
        {
            var swan = new Swan();
            var swanAsDuck = swan as IDuck;

            //Condition below is never satisfied with default features of CLR. This is so because although
            //swan matches signature of IDuck interface, CLR requires swan to inherit it from IDuck interface
            //ecplicitly.
            Console.WriteLine("Attempting to use swan as a duck...");
            if (swan is IDuck || swanAsDuck != null)
            {
                swanAsDuck.Walk();
                swanAsDuck.Swim();
                swanAsDuck.Quak();

            }
            else
            {
                Console.WriteLine("Attempt failed......");
            }
            Console.ReadKey();
            Console.WriteLine("Attempting using dynamic language runtime....");
            //This however can be changed by using a few features like-
            //DLR
            DoDuckLikeThings(swan);
            Console.ReadKey();

        }

        static void DoDuckLikeThings(dynamic duckish)
        {
            if (duckish != null)
            {
                duckish.Walk();
                duckish.Swim();
                duckish.Quack();
            }
        }
    }
}
