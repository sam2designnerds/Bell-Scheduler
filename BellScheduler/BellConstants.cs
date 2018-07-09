using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellScheduler
{
    public static class BellConstants
    {
      public static string BellScheduleFileExtention = "bs";
        public static string HelpMessage = 
            @"ParameterName
            1. Task--> Upload/Download: This accept Upload or Download and perform accordingly
            2. FileName--> fullpath of the file with its name.
            Example:  BellScheduler.exe -T Upload -F C:\temp\test.txt";


        public static string Upload = "upload";
        public static string Download = "download";
        
        public static string Host = "Host";
        public static string Port = "Port";
        public static string Protocol = "Protocol";
        public static string UserName = "UserName";
        public static string Password = "Password";

        public static string BellSettingsRegKey = @"SOFTWARE\BellScheduleSettings";

        public static string BellSettingIssue = "Please check your set up information to connect the server properly";

        public static string InvalidArg = "Invalid Arguments";


        // This section need to be move to a help/Error class later

        public static bool IsSuccess = false;
        public static string ErrorMessage = string.Empty;
    }
}
