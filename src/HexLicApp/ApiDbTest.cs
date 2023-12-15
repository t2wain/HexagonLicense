using HexLicApiLib;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HexLicApp
{
    public class ApiDbTest
    {
        private readonly IServiceProvider _provider;
        ApiDB _db = null!;

        public ApiDbTest(IServiceProvider provider)
        {
            _provider = provider;
            _db = provider.GetRequiredService<ApiDB>();
        }

        public void Run()
        {
            var lst = new List<Task>() {
                //GetLiveUsage(),
                //GetLogUsage(),
                //GetKeyStores(),
                GetUsagePeakQuantityUsedByDay(),
            };

            if (lst.Count > 0)
                Task.WaitAll(lst.ToArray());
        }

        protected Task GetLiveUsage() =>
            _db.GetCompanyLicenseUsage(out var uri).ContinueWith(t => { 
                var data = t.Result;
                Console.WriteLine(string.Format("Live usage uri: {0}", uri));
                Console.WriteLine("GetLiveUsage completed!");
            });


        protected Task GetLogUsage() =>
            _db.GetCurrentLogUsage().ContinueWith( t => { 
                var data = t.Result;
                var uri = _db.GetAvailableRawUsageFilesbyMonth(DateTime.UtcNow).Result;
                Console.WriteLine(string.Format("Log file url: {0}", uri));
                Console.WriteLine("GetLogUsage completed!");
            });

        protected Task GetKeyStores() =>
            _db.GetKeystores().ContinueWith(t =>
            {
                var data = t.Result;
                Console.WriteLine("GetKeyStores completed!");
            });

        protected Task GetUsagePeakQuantityUsedByDay() =>
            _db.GetUsagePeakQuantityUsedByDay(new() { FromDate = DateTime.Now.AddDays(-1), ToDate = DateTime.Now })
                .ContinueWith(t =>
                {
                    var data = t.Result;
                    Console.WriteLine("GetUsagePeakQuantityUsedByDay completed!");
                });
    }
}
