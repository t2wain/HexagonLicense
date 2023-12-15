using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class UsageCount
    {
        public string ProductTag { get; set; }
        public DateTime DateGroup { get; set; }
        public int Count { get; set; }
        public List<string> Users { get; set; }
    }
}
