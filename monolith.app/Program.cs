using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace monolith.app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            // CreateWebhostBuilder(args).Build().Run();
        }


        public static IWebHostBuilder CreateWebhostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging(logging => {
                logging.AddConsole();
                logging.AddDebug();
            })
            .UseStartup<Startup>();
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(build => {
                    build.AddEnvironmentVariables();
                    

                    
                    
                })
                
                .ConfigureLogging((logging) => {
                    logging.AddDebug();
                    logging.AddConsole();
                })                
                .ConfigureWebHostDefaults(webBuilder =>
                {

                    webBuilder.UseStartup<Startup>();
                });

    }
}
