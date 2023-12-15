using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public interface IFilter
    {
        string ProductTags { get; set; }
        DateTime FromDate { get; set; }
        DateTime? ToDate { get; set; }
        string KeyStoreNames { get; set; }
        string ReportType { get; set; }
        string GroupDateBy { get; set; }
        string IncludeUsers { get; set; }
    }
}
