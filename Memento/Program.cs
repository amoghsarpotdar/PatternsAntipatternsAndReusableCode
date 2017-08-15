using System;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemeneto();

            o.State = "Off";
            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}
