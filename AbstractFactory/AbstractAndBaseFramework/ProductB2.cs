﻿using System;

namespace AbstractFactory.AbstractAndBaseFramework
{
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}
