using System;
using Facade.Subsystems;

namespace Facade
{
    class Facade
    {
        private Subsystem1 _one;
        private Subsystem2 _two;
        private SubSystem3 _three;
        private SubSystem4 _four;

        public Facade()
        {
            _one= new Subsystem1();
            _two = new Subsystem2();
            _three = new SubSystem3();
            _four = new SubSystem4();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---");
            _two.MethodTwo();
            _three.MethodThree();
        }
    }
}
