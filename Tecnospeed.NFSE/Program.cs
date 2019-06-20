using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace Tecnospeed.NFSE
{
  public class Program
  {
    public static void Main(string[] args) => BuildWebHost(args).Run();


    public static IWebHost BuildWebHost(string[] args)
    {
      var hostBuilder = WebHost.CreateDefaultBuilder(args);
      var configBuilder = new ConfigurationBuilder();
      if (args != null)
      {
        configBuilder.AddCommandLine(args);
      }
      var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

      hostBuilder.ConfigureAppConfiguration((hostingContext, config) => {
        config.Sources.Clear();
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
            .AddJsonFile($"appsettings.{environment}.json", optional: false, reloadOnChange: false);
        config.AddEnvironmentVariables();

      }).UseStartup<Startup>();

      return hostBuilder.Build();

    }
  }
}
