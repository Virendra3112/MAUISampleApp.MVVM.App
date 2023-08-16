using MAUISampleApp.MVVM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
