using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Net;

namespace XamChatR.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
            .ConfigureKestrel((context, options) =>
            {
#if DEBUG
                options.Listen(IPAddress.Loopback, 5000);
#endif
            });
    }
}
