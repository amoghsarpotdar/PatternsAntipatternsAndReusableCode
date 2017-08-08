using System;
using Proxy.AbstractAndBaseFramework;

namespace Proxy.Concrete
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
