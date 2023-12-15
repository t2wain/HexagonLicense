using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class RecentUsage
    {
        public string KeyStoreName { get; set; }
        public string SiteCity { get; set; }
        public string ProductTag { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public double UsageMinutes { get; set; }
        public bool Checkout { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public string IPAddress { get; set; }
        public string LicenseType { get; set; }
        public string KeyUuid { get; set; }
        public double RequestTimeDaysSince { get; set; }
        public double ReturnTimeDaysSince { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string Source { get; set; }
    }
}
