using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class DateRange
    {
        public DateRange()
        {
            FromDate = new DateTime(1970, 1, 1);
            ToDate = DateTime.UtcNow.AddDays(1);
        }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FromDateString { get => FromDate.ToString("yyyy-MM-dd"); }
        public string ToDateString { get => ToDate.ToString("yyyy-MM-dd"); }
    }
}
