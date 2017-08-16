using System;
using Observer.Concrete;

namespace Observer
{
    class Program
    {
        static void Main()
        {
            ConcreteSubject sub = new ConcreteSubject();
            
            sub.Attach(new ConcreteObserver(sub, "X"));
            sub.Attach(new ConcreteObserver(sub, "Y"));
            sub.Attach(new ConcreteObserver(sub, "Z"));

            //Change subject and notify observers
            sub.SubjectState = "ABC";
            sub.Notify();

            Console.ReadKey();
        }
    }
}
