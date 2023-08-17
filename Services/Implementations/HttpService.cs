using MAUISampleApp.MVVM.Services.Interfaces;
using System.Net;

namespace MAUISampleApp.MVVM.Services.Implementations
{
    public class HttpService : IHttpService
    {
        HttpClient _httpClient;
        HttpService()
        {
            _httpClient = new HttpClient();
        }
        public Task<HttpResponseMessage> GetAsync(string url)
        {
            try
            {
                var response = _httpClient.GetAsync(url);

                if (response == null)
                {
                    return null;
                    //HttpStatusCode.BadRequest;
                }
                return response;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Task<HttpResponseMessage> PostAsync(string url, object data)
        {
            throw new NotImplementedException();
        }
    }
}
