using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class RecentUsageSPF
    {
        public string KeyStoreName { get; set; }
        public string ProductTag { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public int Consumed { get; set; }

    }
}
