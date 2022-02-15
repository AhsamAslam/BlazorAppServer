using communitybuilderapi.Data;
using communitybuilderapi.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace communitybuilderapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build()
              .MigrateDatabase<ApplicationDbContext>((context, services) =>
              {

              }).Run();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostContext, services) => {
                    services.AddJsonFile($"appsettings.{hostContext.HostingEnvironment.EnvironmentName}.json");
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.ConfigureKestrel(serverOptions =>
                    //{
                      //  serverOptions.Listen(IPAddress.Any, Convert.ToInt32(Environment.GetEnvironmentVariable("PORT")));
                    //}).UseStartup<Startup>();
                });
    }
}
