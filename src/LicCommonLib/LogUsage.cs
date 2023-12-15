using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class LogUsage
    {
        public int? Id { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public int RecordCount { get; set; }

        #region Schema

        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteCity { get; set; }
        public string SiteState { get; set; }
        public string SiteCountry { get; set; }

        public string KeyStoreUuid { get; set; }
        public string KeyStoreName { get; set; }
        public string CloudLocation { get; set; }
        public string KeyUuid { get; set; }
        public string KeyType { get; set; }
        public DateTime KeyStartDate { get; set; }
        public DateTime KeyEndDate { get; set; }
        public string KeyGeneratedBy { get; set; }
        public DateTime KeyGeneratedTime { get; set; }

        public string UserName { get; set; }
        public string UserNameDecrypted { get; set; }
        public string LoginName { get; set; }
        public string LoginNameDecrypted { get; set; }
        public string RemoteUserName { get; set; }
        public string RemoteUserNameDecrypted { get; set; }

        public string MachineName { get; set; }
        public string MachineNameDecrypted { get; set; }
        public string RemoteMachineName { get; set; }
        public string RemoteMachineNameDecrypted { get; set; }
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceNameDecrypted { get; set; }
        public string IPAddress { get; set; }

        public string LicenseSessionUuid { get; set; }
        public bool Checkout { get; set; }
        public DateTime RequestTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public string LicenseMechanismType { get; set; }

        public string ProductTag { get; set; }
        public string ProductVersion { get; set; }
        public string LicenseType { get; set; }
        public string PurchaseType { get; set; }
        public string ConfigurationUuid { get; set; }
        public string ConfigurationName { get; set; }
        public string ProjectUuid { get; set; }
        public string ProjectName { get; set; }

        #endregion
    }
}
