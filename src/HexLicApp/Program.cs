// See https://aka.ms/new-console-template for more information
using HexLicApiLib;
using HexLicApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Test started!");

var provider = GetProvider();
var t = new ApiDbTest(provider);
t.Run();

Console.WriteLine("Test completed!");

ServiceProvider GetProvider()
{
    var services = new ServiceCollection();
    var root = GetConfiguration();
    var cfg = new ApiConfig();
    root.GetSection("HexLicApi").Bind(cfg);
    services.ConfigureMyApp(root);
    var provider = services.BuildServiceProvider();
    return provider;
}

IConfigurationRoot GetConfiguration()
{
    var builder = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appSettings.json");

    if (File.Exists("appSettings.Development.json"))
        builder.AddJsonFile("appSettings.Development.json");

    return builder.Build();
}