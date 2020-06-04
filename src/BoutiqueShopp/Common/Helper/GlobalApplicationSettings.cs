using Database;
using SkyReg.Extensions;
using System;

namespace SkyReg
{
    public sealed class GlobalApplicationSettings
    {
        public static string DatabaseConfigFile { get; set; }
        public static string UserConfigFile { get; set; }
        public static string GlobalPathFile { get; set; }
        public static string AppVer { get; set; }
        public static string LocalMachineName { get; set; } = Environment.CurrentDirectory;
        public static bool IsDbExists { get; set; }
        public static LoggedUser User  { get; set; }
    }
}
