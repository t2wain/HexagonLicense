using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class UsageDetail
    {
        public int Id { get; set; }
        public int UsageByHourId { get; set; }
        public int LogUsageId { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public double UsageMinutes { get; set; }
        public string KeyUuid { get; set; }
        public string KeyStoreUuid { get; set; }
        public string Site { get; set; }
        public string Project { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime ReturnTime { get; set; }
    }
}
