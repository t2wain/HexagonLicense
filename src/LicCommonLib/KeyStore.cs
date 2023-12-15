using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class KeyStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SiteName { get; set; }
        public string SiteCity { get; set; }
        public string SiteState { get; set; }
        public string SiteCountry { get; set; }
        public bool IsDeactivated { get; set; }
    }
}
