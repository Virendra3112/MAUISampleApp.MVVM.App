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
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response == null)
                {

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return response;
                    }
                    else
                    {
                        return null;// HttpStatusCode.BadGateway;
                    }
                }
                return null;
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
