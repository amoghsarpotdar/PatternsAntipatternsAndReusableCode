using System;
using System.Collections.Generic;
using Composite.AbstractAndBaseFramework;

namespace Composite.Concrete
{
    class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);

            foreach (Component c in children)
            {
                c.Display(depth + 2);
            }
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }
    }
}
