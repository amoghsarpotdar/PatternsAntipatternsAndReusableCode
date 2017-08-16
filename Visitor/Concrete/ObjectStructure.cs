using System.Collections.Generic;
using Visitor.AbstractAndBaseFramework;

namespace Visitor.Concrete
{
    class ObjectStructure
    {
        private List<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(AbstractAndBaseFramework.Visitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
