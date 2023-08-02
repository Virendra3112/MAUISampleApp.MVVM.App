using MAUISampleApp.MVVM.Models;
using MAUISampleApp.MVVM.Services.Interfaces;
using MetroLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class LoggerService : ILoggerService
    {
        private static readonly ILogger Logitem = LoggerFactory.GetLogger(nameof(LoggerService));

        public LoggerService()
        {
        }

        public Task<LogFile> DowloadLogsAsync()
        {
            try
            {
                Logitem.Info("DowloadLogsAsync");

                //todo: download file

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Logitem.Error("Oops something bad happened", ex);
                throw ex;
            }
        }

        //public async Task<LogFile> DowloadLogsAsync()
        //{
        //    Log.Info("DowloadAsync()");

        //    try
        //    {
        //        //await _client.GetAsync();

        //        return null;//ToDo
        //    }
        //    catch (Exception exception)
        //    {
        //        Log.Error("Oops something bad happened", exception);
        //    }
        //}

        public void LogDetails(string className, string methodName, string message, Exception ex)
        {
            try
            {
                Logitem.Trace(message, className, methodName, message, ex);
            }
            catch (Exception exce)
            {
                Logitem.Error("LogDetails Exception", exce);
            }
        }

        public void LogError(string className, string methodName, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
