using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleApp.MVVM.CustomControls
{
    public partial class TimeZoneResourceProvider : ITimeZoneResourceProvider, IDisposable
    {
        public IReadOnlyList<TimeZoneResource> GetTimeZoneResources() =>
            GetTimeZoneIds()
                .Select(id => new TimeZoneResource
                {
                    Id = id,
                    TimeZone = TimeZoneInfo.FindSystemTimeZoneById(id),
                    Name = GetGenericName(id),
                    Location = GetLocation(id)
                })
                .OrderBy(r => r.TimeZone.GetUtcOffset(DateTime.UtcNow))
                .ThenBy(r => r.Name)
                .ThenBy(r => r.Location)
                .ToList();

        public void Dispose()
        {
            //DisposeResources();
            GC.SuppressFinalize(this);
        }

        public IReadOnlyList<string> GetTimeZoneIds()
        {
            throw new NotImplementedException();
        }

        public string GetGenericName(string timeZoneId)
        {
            throw new NotImplementedException();
        }

        public string GetLocation(string timeZoneId)
        {
            throw new NotImplementedException();
        }

        ~TimeZoneResourceProvider()
        {
            //DisposeResources();
        }
    }
}
