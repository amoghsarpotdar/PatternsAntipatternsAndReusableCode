namespace Visitor.AbstractAndBaseFramework
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
