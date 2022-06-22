using AppiumFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumFramework.Config
{
    class Settings
    {
        public static string ChromeDriverPath { get; set; }
        public static PlatformName PlatformName { get; set; }
        public static string DeviceName { get; set; }
        public static MobileType MobileType { get; set; }
    }
}
