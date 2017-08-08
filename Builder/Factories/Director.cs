using Builder.AbstractAndBaseFramework;

namespace Builder.Factories
{
    class Director
    {
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
