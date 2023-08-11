using ExpressTimezone;

namespace TimeGobal.Api.Services
{
    public class TimeGlobalService : ITimeGlobalService
    {
        public string GetTime(string region, string city)
        {
            var utctime = DateTime.UtcNow;
            var gettime = utctime.UTCToRegionalTime($"{region}/{city}").ToString("hh:mm:ss");
            return gettime;
        }

    }
}
