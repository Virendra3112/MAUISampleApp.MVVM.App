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

                if (response == null && response.IsSuccessStatusCode)
                {

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return response;
                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        //check request body
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;//ToDo
            }
        }

        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent data)
        {
            try
            {
                var response = await _httpClient.PostAsync(url, data);

                if (response == null && response.IsSuccessStatusCode)
                {

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return response;
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        //get token and make a request again
                    }
                    else if (response.StatusCode == HttpStatusCode.BadGateway)
                    {
                        //check request body
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;//ToDo
            }
        }
    }
}
