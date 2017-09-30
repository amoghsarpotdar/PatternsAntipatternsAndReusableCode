using Ninject;
using StairwayInterface;

namespace StairwaySolution
{
    class Program
    {
        /// <summary>
        /// This program uses stairway pattern.
        /// StairwayInterface solution contains interface definition.
        /// StairwayImplementation solution contains implementation for the interface.
        /// StairwaySolution uses the NInject binding configuration to load configured
        /// assembly. Notice that StairwaySolution does not have to know about the
        /// existence of StairwayImplementation (or any other implementation that
        /// follows StairwayInterface structure).
        /// 
        /// You may have to fiddle a bit with configuration file in order to get the
        /// mapping to work.
        /// </summary>
        static void Main()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(@"E:\\Projects\\PatternsAntipatternsAndReusableCode\\StairwaySolution\\BindingConfig.xml");
            bool ismodule = kernel.HasModule("ModA");//To Check The module 
            if(ismodule )
            {           
                IStairwayExample1 myServiceImplementation = kernel.Get<IStairwayExample1>();
                myServiceImplementation.ExampleMethod1();
            }
        }
    }
}
