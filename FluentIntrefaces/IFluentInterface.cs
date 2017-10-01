namespace FluentIntrefaces
{
    /// <summary>
    /// This interface follows 'fluent' pattern, i.e. it facilitates chaining of function calls
    /// on objects returned by its method by returning itself.
    /// </summary>
    interface IFluentInterface
    {
        IFluentInterface DoSomething();

        IFluentInterface DoSomethingElse();

        void ThisMethodIsNotFluent();
    }
}
