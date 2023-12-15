using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LicCommonLib
{
    public interface IRepository
    {
        System.Threading.Tasks.Task AddLogDataAsync(IEnumerable<LiveUsage> liveRecords, 
            IEnumerable<LogUsage> logRecords, DateTime timestampUtc);
        System.Threading.Tasks.Task CleanLiveUsage(DateTime timeStamp,
            IEnumerable<LiveUsage> liveRecords, bool commit = false);
        LogUsage GetLogUsageByLatestRequestTime();
        LogUsage GetLogUsageByLatestReturnTime();
        List<LogUsage> GetLogUsageByLastMinute();
        Task<List<LiveUsage>> GetRecentLiveUsage(DateTime? day = null);
        Task<List<LogUsage>> GetSiteInfoFromLog();
        Task<List<RecentUsage>> GetRecentLogUsage(int daysSince);
        Task<List<RecentUsage>> GetRecentLogUsage(DateTime fromDateUTC, DateTime toDateUTC, string productTag = null);
        Task<IEnumerable<LogUsage>> GetRecentLiveUsageAsLogUsage(
            string productTag = null, DateTime? fromDateUtc = null, 
            DateTime? toDateUtc = null);
        Task<List<RecentUsage>> GetLiveUsageSinceLogUsage();
        Task<IEnumerable<LiveUsage>> GetLiveUsageSinceLogUsage2();
        Task<IEnumerable<LogUsage>> GetDailyLogUsage(string productTag, 
            DateTime fromDateUtc, DateTime toDateUtc);
        Task<IEnumerable<LiveUsage>> GetDailyLiveUsage(string productTag,
            DateTime fromDateUtc, DateTime toDateUtc);
        DateTime GetLastLiveUsageTimeStamp();
        DateTime GetLastLogUsageTimeStamp();
    }
}
