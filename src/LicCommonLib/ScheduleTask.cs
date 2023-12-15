using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class ScheduleTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string TaskType { get; set; }
        public DateTime LastRun { get; set; }
        public DateTime? LastSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public int MinuteInterval { get; set; }
        public bool IsDeactivated { get; set; }
    }
}
