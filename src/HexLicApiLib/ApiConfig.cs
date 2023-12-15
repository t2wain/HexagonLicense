using System;
using System.Collections.Generic;
using System.Text;

namespace HexLicApiLib
{
    public class ApiConfig
    {
        public string ApiUrl { get; set; }
        public string CompanyCode { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string IdentityServerUrl { get; set; }
        public string ApiScope { get; set; }
        public Uri ApiUri { get => new Uri(ApiUrl); }
        public string TokenFileName { get; set; }
    }
}
