using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
           (NewLogger) _logger.
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            // Logger logger = new Logger();
            // DataAccess dataAccess = new DataAccess();

            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
