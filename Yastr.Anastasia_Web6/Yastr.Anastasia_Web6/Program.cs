using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Yastr.Anastasia_Web6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program.BuildWebHost(args).MigrateDatabase().Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}