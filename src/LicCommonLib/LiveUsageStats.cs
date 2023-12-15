using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class LiveUsageStats
    {
        public string ProductTag { get; set; }
        public string KeyStoreName { get; set; }
        public DateTime UsageTime { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int MaxLicAvailQty { get; set; }
        public int? MinLicAvailQty { get; set; }
        public int InUseLicQty { get; set; }
        public int ExpiredLicQty { get; set; }
        public IEnumerable<LiveUsage> Records { get; set; }
    }
}
