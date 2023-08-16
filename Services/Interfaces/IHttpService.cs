using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.Services.Interfaces
{
    public interface IHttpService
    {
        Task<HttpResponseMessage> GetAsync(string url);

        Task<HttpResponseMessage> PostAsync(string url, object data);

        `
    }
}
