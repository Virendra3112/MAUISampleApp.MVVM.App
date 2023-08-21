namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> GetAsync(string url);

        Task<HttpResponseMessage> PostAsync(string url, HttpContent data);

    }
}
