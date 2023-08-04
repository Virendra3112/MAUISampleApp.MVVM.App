using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.CustomControls
{
    public interface ITimeZoneResourceProvider
    {
        IReadOnlyList<TimeZoneResource> GetTimeZoneResources();
        IReadOnlyList<string> GetTimeZoneIds();
        string GetGenericName(string timeZoneId);
        string? GetLocation(string timeZoneId);
    }
}
