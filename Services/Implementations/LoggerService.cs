using MAUISampleApp.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {
        }

        public void LogDetails(string className, string methodName, string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void LogError(string className, string methodName, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
