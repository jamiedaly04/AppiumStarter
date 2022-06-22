﻿using Microsoft.Extensions.Configuration;
using System.IO;

namespace AppiumFramework.Config
{
    public class ConfigReader
    {

        public static void InitializeSettings()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");

            IConfigurationRoot configurationRoot = builder.Build();

            Settings.PlatformName = configurationRoot.GetSection("testSettings").Get<TestSettings>().PlatformName;
            Settings.ChromeDriverPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().ChromeDriverPath;
            Settings.DeviceName = configurationRoot.GetSection("testSettings").Get<TestSettings>().DeviceName;
            Settings.MobileType = configurationRoot.GetSection("testSettings").Get<TestSettings>().MobileType;

        }
    }
}
