using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellScheduler
{
   public class DeviceDataModel
    {
        public int SerialNumber { get; set; }
        public Boolean DoClear { get; set; } = true;
        public String Host { get; set; } 
        public String Port { get; set; }
        public String UserName { get; set; } = "admin"; 
        public String Password { get; set; } = "admin";
        public int Delay { get; set; } = 1000;


    }
}
