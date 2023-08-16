using MAUISampleApp.MVVM.Services.Interfaces;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class HttpService : IHttpService
    {
        public Task<HttpResponseMessage> GetAsync(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync(string url, object data)
        {
            throw new NotImplementedException();
        }
    }
}
