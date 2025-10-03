using Microsoft.Extensions.Configuration;
using System;

namespace PurgoMalum.Configuration
{
    public class ConfigManager
    {
        static IConfiguration _Configuration { get; set; }

        static ConfigManager()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddUserSecrets<ConfigManager>(true, reloadOnChange: true);
            _Configuration = builder.Build();

        }
    }
}