using Autofac;
using DemoLibrary;
using DemoLibrary.Utilities;

namespace ConsoleUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();

            // registering the classes 
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterType<DataAccess>().As<IDataAccess>();
            builder.RegisterType<Logger>().As<ILogger>();




            return builder.Build();
        }
    }
}
