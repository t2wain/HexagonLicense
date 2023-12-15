using System;
using System.Collections.Generic;
using System.Text;

namespace LicCommonLib
{
    public class LiveUsage
    {
        public int? Id { get; set; }
        public DateTime DateTimeStamp { get; set; }

        #region CompanyUsage Schema

        public string LogRecordId { get; set; }
        public string KeyStoreName { get; set; }
        public string ProductTag { get; set; }
        public string ProductName { get; set; }
        public string ProductVersion { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string LicenseType { get; set; }
        public string PurchaseType { get; set; }
        public string ProjectName { get; set; }

        public DateTime? DateAcquired { get; set; }
        public int? MinutesAvailable { get; set; }
        public int? MinutesRemaining { get; set; }
        public int? Duration { get; set; }

        public DateTime? KeyExpiration { get; set; }
        public DateTime? CurrentExpiration { get; set; }
        public DateTime? CurrentReset { get; set; }

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
        public string DeviceName { get; set; }
        public string DeviceNameDecrypted { get; set; }

        public string IPAddress { get; set; }
        public string IPAddressInternal { get; set; }
        public string IPAddressExternal { get; set; }

        public string CloudLocation { get; set; }
        public string CloudLocationId { get; set; }

        #endregion
    }
}
