using Builder.AbstractAndBaseFramework;

namespace Builder.Factories
{
    class ConcreteBuilder2 : AbstractBuilder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product BuildProduct()
        {
            return _product;
        }
    }
}
