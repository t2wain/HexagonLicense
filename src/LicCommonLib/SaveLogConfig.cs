using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class SaveLogConfig
    {
        public int LiveUsageInterval { get; set; }
        public int LogUsageInterval { get; set; }
        public string FailedNotifyAddress { get; set; }
        public string SuccessNotifyAddress { get; set; }
        public string SmtpUrl { get; set; }
    }
}
