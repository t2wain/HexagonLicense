using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class HexLicReport
    {
        public class Keystore
        {
            public string Name { get; set; }
            public List<string> Sites { get; set; } = new List<string>();
            public string Server { get; set; }
            public string Project { get; set; } = "";
            public string Region { get; set; } = "";
        }

        public class Site
        {
            public string Name { get; set; } = "";
            public List<string> Locations { get; set; } = new List<string>();
        }

        public string ADRoot { get; set; } = "";
        public List<Keystore> Keystores { get; set; } = new List<Keystore>();
        public List<string> Apps { get; set; } = new List<string>();
        public List<Site> Sites { get; set; } = new List<Site>();
    }
}
