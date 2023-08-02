using MAUISampleApp.MVVM.Models;

namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface ILoggerService
    {
        void LogError(string className, string methodName, Exception ex);
        void LogDetails(string className, string methodName, string message, Exception ex);

        Task<LogFile> DowloadLogsAsync();
    }

}
