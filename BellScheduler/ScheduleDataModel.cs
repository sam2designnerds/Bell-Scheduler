using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellScheduler
{
    public class ScheduleDataModel
    {
        public int SerialNumber { get; set; }
        public string BellName { get; set; }

        public DateTime BellTime { get; set; }
        public string BellNumbers { get; set; }
        public string BellDays { get; set; }

        public DateTime BellDate { get; set; }

        public int BellDuration { get; set; }
        public string PulseWidth { get; set; }

        public bool IsBellUse { get; set; }

        public bool IsBellOnce { get; set; }

        public string GetBinaryNumbersFromBooleans(List<bool> LstBools)
        {
            string Result = string.Empty;
            foreach (var item in LstBools)
            {
                Result = Result + (item? "1" : "0");
            }
            return Result;

        }

        public List<bool> GetBooleanListFromStrings(string BinaryStr)
        {
            List<bool> LstBooleans = new List<bool>();
            foreach (var item in BinaryStr)
            {
                LstBooleans.Add(item != '0');
            }
            return LstBooleans;
        }

    }

   
}
