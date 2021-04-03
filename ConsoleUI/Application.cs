using DemoLibrary;

namespace ConsoleUI
{
    class Application : IApplication
    {
        IBusinessLogic _bussinessLogic;

        public Application(IBusinessLogic bussinessLogic)
        {
            _bussinessLogic = bussinessLogic;
        }

        public void run()
        {
            _bussinessLogic.ProcessData();
        }
    }
}
