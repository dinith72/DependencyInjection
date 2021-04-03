using Autofac;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessLogic businessLogic = new BusinessLogic();

            ///  businessLogic.ProcessData();
            ///  

            IContainer container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {

                IApplication application = scope.Resolve<IApplication>();
                application.run();
            }

            Console.ReadLine();
        }
    }
}
