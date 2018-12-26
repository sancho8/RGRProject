using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RGRProject
{
    public static class AppSettingsHelper
    {
        public static string ApplicationExeDirectory()
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var appRoot = Path.GetDirectoryName(location);

            return appRoot;
        }

        public static IConfigurationRoot GetAppSettings()
        {
            string directory = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
            .SetBasePath(directory)
            .AddJsonFile("appsettings.json");

            return builder.Build();
        }
    }
}
