using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SpfBlazorDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://blazor.vivet.dev:5000", "http://localhost:5000");
                });
    }
}
