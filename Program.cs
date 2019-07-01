using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace crudmysql
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        public static string GetIP()
        {
            NetworkInterface networkInterface = NetworkInterface.GetAllNetworkInterfaces().Where(x => x.Name == "eth0").FirstOrDefault();

            if (networkInterface == null)
                return IPAddress.Parse("127.0.0.1").ToString();

            return (networkInterface.GetIPProperties().UnicastAddresses.FirstOrDefault().Address).ToString();
        }
    }
}
