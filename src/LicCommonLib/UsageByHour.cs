using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class UsageByHour
    {
        [Serializable]
        public class Detail
        {
            public IEnumerable<string> UseLicenses { get; set; } = new List<string>();
            public IEnumerable<string> ExpiredLicenses { get; set; } = new List<string>();
            public IEnumerable<string> AvailLicenses { get; set; } = new List<string>();
            public IEnumerable<string> Users { get; set; } = new List<string>();
            public IEnumerable<string> Machines { get; set; } = new List<string>();
            public IEnumerable<string> Sites { get; set; } = new List<string>();
            public IEnumerable<UsageDetail> LogUsageData { get; set; } = new List<UsageDetail>();
        }

        public int Id { get; set; }
        public string ProductTag { get; set; }
        public string Keystore { get; set; }
        public int TotalLicenseCount { get; set; }  // from live usage
        public int AvailLicenseCount { get; set; }  // from live usage
        public int InUseLicenseCount { get; set; }  // from live usage
        public int ExpiredLicenseCount { get; set; }  // from live usage
        public int PeakLicenseUsageCount { get; set; } // from log usage
        public DateTime? PeakLicenseUsageTime { get; set; }
        public IEnumerable<int> PeakLicensesUsageLogIds { get; set; } = new List<int>();
        public double UsageMinutes { get; set; } // from log usage
        public double UsagePct { get; set; } // from log usage
        public DateTime UsageDateLocal { get; set; } // from log usage
        public DateTime UsageDateUtc { get; set; } // from log usage
        public string DetailXml { get; set; }

        public IEnumerable<LiveUsage> LiveUsageData { get; set; } = new List<LiveUsage>();
        public Detail LogDetail { get; set; } = new Detail();
        public void SerialDetail()
        {

        }
        public void DeserializeDetail()
        {

        }

        public int FailUserCount { get; set; } = 0;
        public IEnumerable<string> FailUserIds { get; set; } = new List<string>();
    }
}
