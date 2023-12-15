using HexLicApiLib;
using Intergraph.PPM.Licensing.Portal.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HexLicApp
{
    public static class ServiceConfigExtensions
    {
        public static void ConfigureMyApp(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton(typeof(ApiConfig), (provider) =>
            {
                var apicfg = new ApiConfig();
                config.GetSection("HexLicApi").Bind(apicfg);
                return apicfg;
            });

            services.AddSingleton<TokenService>();

            services.AddScoped(typeof(PortalApiContext), provider =>
            {
                var cfg = provider.GetRequiredService<ApiConfig>();
                var ts = provider.GetRequiredService<TokenService>();
                var ctx = new PortalApiContext(cfg.ApiUri);
                ctx.BuildingRequest += (sender, eventArgs) =>
                {
                    eventArgs.Headers.Add("Authorization", string.Format("Bearer {0}", ts.GetToken().access_token));
                };
                return ctx;
            });

            services.AddScoped<ApiDB>();
        }

    }
}
