using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellScheduler
{
   public  class DeviceDataManager
    {
        public static string DeviceListFilePath;
        
       
        public static List<DeviceData> DeviceDataUI = new List<DeviceData>();

        public static Action ActionMakeDirty = new Action(MakeDirty);
        private static bool _IsDirty;

        public static bool IsDirty
        {

            get
            {
                if (!_IsDirty)
                {
                    foreach (var item in DeviceDataUI)
                    {
                        string TestForDirty = item.deviceDataModel.UserName;
                    }
                }
                return _IsDirty;
            }
            set
            {
                _IsDirty = value;
            }
        }

        public static void LoadData()
        {
            DeviceDataUI.Clear();
            DeviceDataUI = File.ReadAllLines(DeviceListFilePath)
                                          .Skip(1)
                                          .Select(v => FromCsv(v))
                                          .ToList();
        }
        public static DeviceData FromCsv(string csvLine)
        {

            string[] values = csvLine.Split(',');
            DeviceDataModel DDM = new DeviceDataModel();
            DeviceData DD = new DeviceData();
            DDM.SerialNumber = 0;
            DDM.DoClear = (values[0]!="0");
            DDM.Host = values[1].ToString();
            DDM.Port = values[2].ToString();
            DDM.UserName = values[3].ToString();
            DDM.Password = values[4].ToString();
            DDM.Delay = Convert.ToInt32(values[5]);
            DD.deviceDataModel = DDM;
            return DD;
        }

        public static void SaveDataToCSV(bool SaveAs = false)
        {
            if ((string.IsNullOrEmpty(DeviceListFilePath)) || SaveAs)
            {
                SaveFileDialog SFDialog = new SaveFileDialog();

                // SFDialog.Filter = "CSV files (*." + BellConstants.BellCSVExtention + ")|*.txt|All files (*.*)|*.*";
                SFDialog.Filter = "CSV files (*." + BellConstants.BellCSVExtention + ")|*.*";
                SFDialog.RestoreDirectory = true;
                SFDialog.DefaultExt = BellConstants.BellCSVExtention;
                // Ask for a path and file name
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                   DeviceListFilePath = SFDialog.FileName;
                   
                }
                else
                {
                    return;
                }

            }

            WriteCSV();
            ResetDirtyFlag();

        }


        public static void WriteCSV()
        {
            Type itemType = typeof(DeviceDataModel);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Skip(1);

            using (var writer = new StreamWriter(DeviceListFilePath))
            {
                // writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));
                writer.WriteLine("Clear,Host,Port,UserName,Password,Delay");
                foreach (var item in DeviceDataUI)
                {
                    List<string> Props = new List<string>();
                    //((item.deviceDataModel.Delay == true) ? "1" : "0")
                    Props.Add((item.deviceDataModel.DoClear == true) ? "1" : "0");
                    Props.Add(item.deviceDataModel.Host);
                    Props.Add(item.deviceDataModel.Port);
                    Props.Add(item.deviceDataModel.UserName);
                    Props.Add(item.deviceDataModel.Password);
                    Props.Add(item.deviceDataModel.Delay.ToString());
                
                    writer.WriteLine(string.Join(",", Props));
                }
            }
        }

        public static DeviceData AddEmptyDeviceData( EventHandler aDeleteEventHandler, EventHandler aSelectDownloadEventHandler)
        {
            DeviceData EmptyData = new DeviceData();
            DeviceDataModel DDM = new DeviceDataModel();
            DDM.SerialNumber = DeviceDataUI.Count + 1;
            EmptyData.deviceDataModel = DDM;
            EmptyData.Location = new Point(0, (DeviceDataUI.Count * 33));
            EmptyData.Controls["btnDelete"].Click += aDeleteEventHandler;
            EmptyData.Controls["chkDownload"].Click += aSelectDownloadEventHandler;
            EmptyData.MakeDirty += ActionMakeDirty;
            DeviceDataUI.Add(EmptyData);
            return EmptyData;
        }

        public static void DeleteDeviceData(int aSerialNumber)
        {
            DeviceDataUI.RemoveAt(aSerialNumber - 1);
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

        public static void SelectDownloadDevice(int aSerialNumber)
        {
            foreach (var item in DeviceDataUI)
            {
                item.UnCheckForDownload();
   
            }

            DeviceDataUI[aSerialNumber - 1].SelectForDownload();
            BellComunication.ObjCommunication.AssignCommunicationSetup(DeviceDataUI[aSerialNumber - 1].deviceDataModel);
        }
    }
}
