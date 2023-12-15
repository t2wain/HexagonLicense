using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public static class DateUtil
    {
        public static DateTime Truncate(DateTime dt, string datePart)
        {
            var r = DateTime.Now;
            switch(datePart)
            {
                case "yyyy":
                    r = new DateTime(dt.Year, 1, 1);
                    break;
                case "MM":
                    r = new DateTime(dt.Year, dt.Month, 1);
                    break;
                case "dd":
                    r = new DateTime(dt.Year, dt.Month, dt.Day);
                    break;
                case "HH":
                    r = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);
                    break;
                case "mm":
                    r = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
                    break;
                case "ss":
                    r = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
                    break;
            }
            return r;
        }



    }
}
