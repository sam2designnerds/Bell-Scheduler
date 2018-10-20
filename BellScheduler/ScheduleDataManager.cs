using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellScheduler
{
    public class ScheduleDataManager
    {

        public static string BellListFilePath;

        public static Action ActionMakeDirty = new Action(MakeDirty);
        private static bool _IsDirty;

        public static bool IsDirty
        {

            get
            {   if (!_IsDirty)
                {
                    foreach (var item in BellDataUI)
                    {
                       string TestForDirty = item.scheduleDM.BellName;
                    }
                }
                return _IsDirty;
            }
            set
            {
                _IsDirty = value;
            }
        }
        

        public static DateTime GetCorrectTime(string[] values, out bool IsDateRequired)
        {

          
            DateTime TempBellDate;
        TimeSpan TempTime;
        string datetime, date, time = string.Empty;
            IsDateRequired = true;
            date = values[4] + "-" + values[5] + "-" + values[6];
            if    (Convert.ToInt32(values[4]) == 0
                || Convert.ToInt32(values[5]) == 0
                || Convert.ToInt32(values[6]) == 0)
            {
               // date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                TempBellDate = DateTime.Now;
                IsDateRequired = false;
               // Date field should be disabled.

            }
            else
            {
              if(!DateTime.TryParse(date, out TempBellDate))
                {
                    TempBellDate = DateTime.Now;
                    IsDateRequired = false;
                }
            }

            time = Convert.ToInt32(values[1]).ToString("00")+":"+ Convert.ToInt32(values[2]).ToString("00") + ":" + Convert.ToInt32(values[3]).ToString("00");

            
            if (!TimeSpan.TryParse(time, out TempTime))
            {
                TempTime = DateTime.Now.TimeOfDay;
            }
            datetime = TempBellDate.ToString("yyyy-MM-dd") + " " + TempTime.ToString();

            DateTime.TryParse(datetime,out TempBellDate);

            return TempBellDate;
        
        }
        public static List<ScheduleData> BellDataUI = new List<ScheduleData>();

        public static void LoadData(string[] CSVData = null)
        {
            BellDataUI.Clear();

            if (CSVData == null)
            {
                //BellDataUI = File.ReadAllLines(BellListFilePath)
                //                              .Skip(1)
                //                              .Select(v => FromCsv(v))
                //                              .ToList();

                CSVData = File.ReadAllLines(BellListFilePath).Skip(1).ToArray() ;
            }

            int LineNumber = 1;
            foreach (var item in CSVData)
            {
                var BellData = FromCsv(item, LineNumber);
                if (BellData != null)
                BellDataUI.Add(BellData);
                LineNumber++;
            }

        }
        public static ScheduleData FromCsv(string csvLine, int LineNumber)
        {
            string[] values = csvLine.Split(',');
            
            ScheduleDataModel SDM = new ScheduleDataModel();
            ScheduleData SD = new ScheduleData();

            if (values.Count() != 13)
            {
                Logger.LogObj.Info("There is some error while parsing the data at line number " + LineNumber + "Of file " + BellListFilePath );
                return null;
            }

            //hours,minutes,seconds,year,month,day
            //DateTime.ParseExact("2014-01-01 23:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
            //name,hours,minutes,seconds,year,month,day,relays(bells),day of week,duration,pw type,use,once

            bool IsDateRequired = false;
            DateTime TempBellDateTime = GetCorrectTime(values,out IsDateRequired);


            SDM.SerialNumber = 0;
            SDM.BellName = values[0].ToString();
            SDM.BellTime = TempBellDateTime;
            SDM.BellNumbers = values[7].ToString();
            SDM.BellDays = values[8].ToString();
            SDM.IsDateRequired = IsDateRequired;
            SDM.BellDate = TempBellDateTime;
            SDM.BellDuration = Convert.ToInt32(values[9]);
            SDM.PulseWidth = values[10].ToString();
            SDM.IsBellUse = (values[11] != "0");
            SDM.IsBellOnce = (values[12] != "0");

            SD.scheduleDM = SDM;
            return SD;
        }

        public static void SaveDataToCSV(bool SaveAs = false)
        {
            if ((string.IsNullOrEmpty(BellListFilePath)) || SaveAs)
            {
                SaveFileDialog SFDialog = new SaveFileDialog();

                SFDialog.Filter = "CSV files (*." + BellConstants.BellCSVExtention + ")|*.txt|All files (*.*)|*.*";
                //SFDialog.Filter = "CSV files (*." + BellConstants.BellCSVExtention + ")|*.*";
                SFDialog.RestoreDirectory = true;
                SFDialog.DefaultExt = BellConstants.BellScheduleFileExtention;
                // Ask for a path and file name
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                  BellListFilePath = SFDialog.FileName;
                }
                else
                {
                    return;
                }

            }
            WriteToCSV();
            ResetDirtyFlag();
        }

        public static void WriteToCSV()
        {
            Type itemType = typeof(ScheduleDataModel);
          //  var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Skip(1);

            using (var writer = new StreamWriter(BellListFilePath))
            {
                // writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));
                writer.WriteLine("#Start");
                foreach (var item in BellDataUI)
                {
                    List<string> Props = new List<string>();
                    //name,hours,minutes,seconds,year,month,day,relays(bells),day of week,duration,pw type,use,once
                    string Year, Month, Day;

                    if (item.scheduleDM.IsDateRequired)
                    {
                      Year = item.scheduleDM.BellDate.Year.ToString();
                      Month = item.scheduleDM.BellDate.Month.ToString();
                      Day = item.scheduleDM.BellDate.Day.ToString();
                    }
                    else
                    {
                        Year = "0"; Month = "0"; Day = "0";
                    }


                    Props.Add(item.scheduleDM.BellName);
                    Props.Add(item.scheduleDM.BellTime.Hour.ToString());
                    Props.Add(item.scheduleDM.BellTime.Minute.ToString());
                    Props.Add(item.scheduleDM.BellTime.Second.ToString());
                    Props.Add(Year);
                    Props.Add(Month);
                    Props.Add(Day);
                    Props.Add(item.scheduleDM.BellNumbers);
                    Props.Add(item.scheduleDM.BellDays);
                    Props.Add(item.scheduleDM.BellDuration.ToString());
                    Props.Add(item.scheduleDM.PulseWidth);
                    Props.Add((item.scheduleDM.IsBellUse == true) ? "1" : "0");
                    Props.Add((item.scheduleDM.IsBellOnce == true) ? "1" : "0");
                    

                    writer.WriteLine(string.Join(",", Props));
                }
            }
        }

        public static ScheduleData AddEmptyScheduleData(EventHandler aEventHandler)
        {
            ScheduleData EmptyData = new ScheduleData();
            ScheduleDataModel SDM = new ScheduleDataModel();
            SDM.SerialNumber = BellDataUI.Count + 1;
            SDM.IsDateRequired = false;
            SDM.BellDate = DateTime.Now;
            SDM.BellTime = DateTime.Now;
            SDM.BellNumbers = string.Empty;
            SDM.BellDays = string.Empty;
            EmptyData.scheduleDM = SDM;           
            EmptyData.Location = new Point(0, (BellDataUI.Count * 38));
            EmptyData.Controls["btnDelete"].Click += aEventHandler;
            EmptyData.MakeDirty += ActionMakeDirty;
            BellDataUI.Add(EmptyData);
            MakeDirty();
            return EmptyData;
            
        }

        public static void DeleteScheduleData(int aSerialNumber)
        {
            BellDataUI.RemoveAt(aSerialNumber - 1);
            MakeDirty();
        }
        public static void MakeDirty()
        {
            IsDirty = true;
        }

        public static void ResetDirtyFlag()
        {
            IsDirty = false;
        }

        public static List<String> GetListOfBells()
        {
            List<String> Result = new List<string>();
            
            //name,hours,minutes,seconds,year,month,day,relays(bells),day of week,duration,pw type,use,once
            
            
            foreach (var item in BellDataUI)
            {
                string Bell = string.Empty;
                Bell = Bell + item.scheduleDM.BellName;
                Bell = Bell + ',' + item.scheduleDM.BellTime.Hour.ToString();
                Bell = Bell + ',' + item.scheduleDM.BellTime.Minute.ToString();
                Bell = Bell + ',' + item.scheduleDM.BellTime.Second.ToString();
                Bell = Bell + ',' + (item.scheduleDM.BellDate.Year-2000).ToString();
                Bell = Bell + ',' + item.scheduleDM.BellDate.Month.ToString();
                Bell = Bell + ',' + item.scheduleDM.BellDate.Day.ToString();
                Bell = Bell + ',' + item.scheduleDM.BellNumbers;
                Bell = Bell + ',' + item.scheduleDM.BellDays;
                Bell = Bell + ',' + item.scheduleDM.BellDuration.ToString();
                Bell = Bell + ',' + item.scheduleDM.PulseWidth;
                Bell = Bell + ',' + (item.scheduleDM.IsBellUse? "1" : "0");
                Bell = Bell + ',' + (item.scheduleDM.IsBellOnce ? "1" : "0");
                Result.Add(Bell);
            }

            return Result;

        }

       

    }
}
