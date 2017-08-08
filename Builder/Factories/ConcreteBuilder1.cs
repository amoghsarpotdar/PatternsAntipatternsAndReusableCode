using Builder.AbstractAndBaseFramework;

namespace Builder.Factories
{
    class ConcreteBuilder1 : AbstractBuilder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        public override Product BuildProduct()
        {
            return _product;
        }
    }
}
