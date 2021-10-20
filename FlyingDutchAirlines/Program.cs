using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace FlyingDutchAirlines
{
    public class Program
    {
        static void Main(string[] args)
        {
            InitalizeHost();
        }

        private static void InitalizeHost() =>
            Host.CreateDefaultBuilder().ConfigureWebHostDefaults(builder =>
            {
                builder.UseStartup<Startup>();
                builder.UseUrls("http://localhost:5009");
            }).Build().Run();
    }
}
