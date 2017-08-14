﻿namespace Mediator.AbstractAndBaseImplementation
{
    abstract class Colleague
    {
        protected Mediator Mediator;

        public Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}
