using CsvHelper.Configuration;
using LicCommonLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexLicApiLib
{
    public class RawUsageMap : ClassMap<LogUsage>
    {
        public RawUsageMap()
        {
            // skip 0
            Map(m => m.SiteId).Name("endUseSiteId"); // .Index(1);
            Map(m => m.SiteName).Name("endUseSiteName"); // .Index(2);
            Map(m => m.SiteCity).Name("endUseSiteCity"); //.Index(3);
            Map(m => m.SiteState).Name("endUseSiteState"); //.Index(4);
            Map(m => m.SiteCountry).Name("endUseSiteCountry"); //.Index(5);
            Map(m => m.KeyStoreUuid).Name("keystoreUuid"); //.Index(6);
            Map(m => m.KeyStoreName).Name("keystoreName"); //.Index(7);
            Map(m => m.CloudLocation).Name("cloudLocation"); //.Index(8);
            Map(m => m.KeyUuid).Name("keyUuid"); //.Index(9);
            Map(m => m.KeyType).Name("keyType"); //.Index(10);

            //.Index(11).ConvertUsing(v => ConvertToUtc(v[11]));
            Map(m => m.KeyStartDate).Name("keyStartDate")
                .ConvertUsing(v => ConvertToUtc(v["keyStartDate"]));
            //.Index(12).ConvertUsing(v => ConvertToUtc(v[12]));
            Map(m => m.KeyEndDate).Name("keyEndDate")
                .ConvertUsing(v => ConvertToUtc(v["keyEndDate"])); 
            Map(m => m.KeyGeneratedBy).Name("keyGeneratedBy"); //.Index(13);
            //.Index(14).ConvertUsing(v => ConvertToUtc(v[14]));
            Map(m => m.KeyGeneratedTime).Name("keyGeneratedTime")
                .ConvertUsing(v => ConvertToUtc(v["keyGeneratedTime"])); 
            Map(m => m.UserName).Name("username"); //.Index(15);
            Map(m => m.UserNameDecrypted).Name("usernameDecrypted"); //.Index(16);
            Map(m => m.RemoteMachineNameDecrypted).Name("remoteUsernameDecrypted"); //.Index(17);
            Map(m => m.LoginName).Name("loginName"); //.Index(18);
            Map(m => m.LoginNameDecrypted).Name("loginNameDecrypted"); //.Index(19);
            Map(m => m.RemoteUserName).Name("remoteLoginName"); //.Index(20);

            Map(m => m.RemoteUserNameDecrypted).Name("remoteLoginNameDecrypted"); //.Index(21);
            Map(m => m.DeviceId).Name("deviceId"); //.Index(22);
            Map(m => m.DeviceName).Name("deviceName"); //.Index(23);
            Map(m => m.DeviceNameDecrypted).Name("deviceNameDecrypted"); //.Index(24);
            Map(m => m.MachineName).Name("machineName"); //.Index(25);
            Map(m => m.MachineNameDecrypted).Name("machineNameDecrypted"); //.Index(26);
            Map(m => m.RemoteMachineName).Name("remoteMachineName"); //.Index(27);
            Map(m => m.IPAddress).Name("ipAddresses"); //.Index(28);
            Map(m => m.LicenseSessionUuid).Name("licenseSessionUuid"); //.Index(29);

            // skip 30, 31, 32, 33
            //.Index(34).ConvertUsing(v => String.Compare(v[34],"TRUE",true) == 0 ? true : false);
            Map(m => m.Checkout).Name("checkout").ConvertUsing(v => 
                String.Compare(v["checkout"], "TRUE", true) == 0 ? true : false); 
            Map(m => m.ProductTag).Name("productTag"); //.Index(35);
            Map(m => m.ProductVersion).Name("productVersion"); //.Index(36);
            Map(m => m.LicenseType).Name("licenseType"); //.Index(37);
            Map(m => m.PurchaseType).Name("purchaseType"); //.Index(38);
            Map(m => m.ConfigurationName).Name("configurationName"); //.Index(39);
            Map(m => m.ProjectName).Name("projectName"); //.Index(40);

            // skip 41 = requestedProjectName

            //.Index(42).ConvertUsing(v => ConvertToUtc(v[42]));
            Map(m => m.RequestTime).Name("requestTime")
                .ConvertUsing(v => ConvertToUtc(v["requestTime"]));
            //.Index(43).ConvertUsing(v => ConvertToUtc(v[43]));
            Map(m => m.ReturnTime).Name("returnTime")
                .ConvertUsing(v => ConvertToUtc(v["returnTime"])); 
            Map(m => m.LicenseMechanismType).Name("licenseMechanismType"); //.Index(44);
            Map(m => m.ConfigurationUuid).Name("configurationUuid"); //.Index(45);
            Map(m => m.ProjectUuid).Name("projectUuid"); //.Index(46);
        }

        DateTime ConvertToUtc(string v)
        {
            var d = DateTime.Parse(v);
            return d.ToUniversalTime();
        }
    }
}
