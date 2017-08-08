using System;
using Composite.Concrete;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            Concrete.Composite root = new Concrete.Composite("Root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Concrete.Composite comp = new Concrete.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            //Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
            Console.ReadKey();
        }
    }
}
