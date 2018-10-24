using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellScheduler
{
    public partial class BellForm : Form
    {

        List<DeviceData> Data = new List<DeviceData>();
        List<ScheduleData> SData = new List<ScheduleData>();

        public void CheckOpenContentNeedsToSave()
        {
            if ((rtbContent.Text != string.Empty) && BellContent.ObjContent.IsSaveRequired(rtbContent.Lines))
            {
                if (MessageBox.Show("Do you want to save the content?", "Want to Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Save();
                }
            }
        }
        public void Download()
        {
            BellComunication BellComObj = BellComunication.ObjCommunication;
            string content = BellComObj.DownloadString();
            if (!BellConstants.IsSuccess)
            {
                if (string.IsNullOrEmpty(BellConstants.ErrorMessage))
                {
                    MessageBox.Show("Information is not downloaded due some unknown reason, please try again.");
                }
                else
                {
                    MessageBox.Show(BellConstants.ErrorMessage);
                }
                return;
            }



            string[] splitSeparator = { Environment.NewLine };
            BellContent.ObjContent.Content = content.Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries);
            rtbContent.Lines = BellContent.ObjContent.Content;
            BellContent.ObjContent.IsChanged = false;
            BellComObj.SaveSettings();
            rtbContent.Visible = true;
        }
        public void Save(Boolean SaveAs = false)
        {
            SaveFileDialog SFDialog = new SaveFileDialog();

            SFDialog.Filter = "txt files (*."+ BellConstants.BellScheduleFileExtention + ")|*.txt|All files (*.*)|*.*";
            SFDialog.FilterIndex = 1;
            SFDialog.RestoreDirectory = true;
            SFDialog.DefaultExt = BellConstants.BellScheduleFileExtention;


            if ((string.IsNullOrEmpty(BellContent.ObjContent.FilePath) || SaveAs))
            {
                // Ask for a path and file name
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    BellContent.ObjContent.FilePath = SFDialog.FileName;
                }
                
            }


            BellContent.ObjContent.SaveContent();


        }

        public void CloseBell()
        {
            //if (!BellContent.ObjContent.IsSaved)
            //{
            //    MessageBox.Show("This needs to save first");
            //}
            var IsSaveRequired = BellContent.ObjContent.IsSaveRequired(rtbContent.Lines);

            if (IsSaveRequired)
               {
                MessageBox.Show("This needs to save first");
            }

        }
        public BellForm()
        {
            InitializeComponent();
            rtbContent.Visible = false;
            panel1.Visible = false;
        }

        public void OpenFile()
        {
            OpenFileDialog OFDialog = new OpenFileDialog();
            int size = -1;
            DialogResult result = OFDialog.ShowDialog(); // Show the dialog.
            OFDialog.DefaultExt = BellConstants.BellScheduleFileExtention;
            if (result == DialogResult.OK) // Test result.
            {
                string file = OFDialog.FileName;
                BellContent.ObjContent.FilePath = OFDialog.FileName;
                try
                {
                    BellContent.ObjContent.Content = File.ReadAllLines(file);
                }
                catch (IOException)
                {
                }
            }
        }

        public void UpdateDeviceListUI()
        {
            pnlDeviceList.Controls.Clear();
            for (int i = 0; i < DeviceDataManager.DeviceDataUI.Count; i++)
            {
                DeviceData TempDataUi = DeviceDataManager.DeviceDataUI[i];
                DeviceDataModel DDM = new DeviceDataModel();
                DDM = TempDataUi.deviceDataModel;
                DDM.SerialNumber = i + 1;
                TempDataUi.deviceDataModel = DDM;
                TempDataUi.Location = new Point(0,  (i * 33));
                pnlDeviceList.Controls.Add(TempDataUi);
            }
        }

        public void UpdateBellListUI()
        {
            pnlScheduleContainer.Controls.Clear();
            for (int i = 0; i < ScheduleDataManager.BellDataUI.Count; i++)
            {
                ScheduleData TempDataUi = ScheduleDataManager.BellDataUI[i];
                ScheduleDataModel SDM = new ScheduleDataModel();
                SDM = TempDataUi.scheduleDM;
                SDM.SerialNumber = i + 1;
                TempDataUi.scheduleDM = SDM;
                TempDataUi.Location = new Point(0,  (i * 38));
                pnlScheduleContainer.Controls.Add(TempDataUi);
            }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {

            //Download();

            // Create The Form, pass the richtext, and window title, and call it

            //PrintDialog pf = new PrintDialog();
            //PrintDocument doc = new PrintDocument();
            //doc.DocumentName = "Print Document";
            //pf.Document = doc;
           

            //if (pf.ShowDialog() == DialogResult.OK)
            //{
            //    doc.Print();
            //}
            //pf.Document = yourRichTextBox.rtf;
            //pf.windowtitle = "My Application";
            //pf.ShowDialog(this); // center form in parent app
            //if (pf.error)
            //{
            //    MyExceptionHandler(pf.printexception); / handle the exception
            // };
            //pf.Dispose(); / required if you use ShowDialog() rather than Show();

            //// The richtext can be also passed in the constructor, if desired, via an override

            //Printform pf = pf(YourRichTextBox.rtf);
            //pf.ShowDialog(this);
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            BellContent.ObjContent.IsChanged = true;
          
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOpenContentNeedsToSave();
            BellContent.ObjContent.CleanContent();
            rtbContent.Clear();
            rtbContent.Focus();

        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Download();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BellContent.ObjContent.Content = rtbContent.Lines;
            Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            Boolean SaveAs = true;
            BellContent.ObjContent.Content = rtbContent.Lines;
            Save(SaveAs);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            CheckOpenContentNeedsToSave();
            BellContent.ObjContent.CleanContent();
            rtbContent.Clear();
            OpenFile();
            rtbContent.Lines = BellContent.ObjContent.Content;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOpenContentNeedsToSave();
            BellContent.ObjContent.CleanContent();
            rtbContent.Clear();
            OpenFile();
            rtbContent.Lines = BellContent.ObjContent.Content;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CheckOpenContentNeedsToSave();
            BellContent.ObjContent.CleanContent();
            rtbContent.Clear();
            rtbContent.Focus();


        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFDialog = new OpenFileDialog();
            int size = -1;
            DialogResult result = OFDialog.ShowDialog(); // Show the dialog.
            OFDialog.DefaultExt = BellConstants.BellScheduleFileExtention;
            if (result == DialogResult.OK) // Test result.
            {
                string file = OFDialog.FileName;
                BellManager bellManager = new BellManager();
                bellManager.UploadFile(file);
                if (BellConstants.IsSuccess)
                {
                    MessageBox.Show("Upload file successfully.");
                }
                else if (!BellConstants.IsSuccess)
                {
                    if (string.IsNullOrEmpty(BellConstants.ErrorMessage))
                    {
                        MessageBox.Show("file is not uploaded due to some unknown reason, please try again.");
                    }
                    else
                    {
                        MessageBox.Show(BellConstants.ErrorMessage);
                    }
                }

            }
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupForm formSetup = new SetupForm();
            formSetup.ShowDialog(this);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // BellComunication.ObjCommunication.UploadFile();

            //testing is going on

            //DeviceData t1 = new DeviceData();
            //Data.Add(t1);

            // for Schedule data

            ScheduleData sd1 = new ScheduleData();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BellContent.ObjContent.Content = rtbContent.Lines;
            Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                //10+(i* Data[i].Height -5)
                Data[i].Location = new Point(0,  (i * 33));

                DeviceDataModel deviceDM = new DeviceDataModel();
                deviceDM.SerialNumber = i + 1;
                Data[i].deviceDataModel = deviceDM;
             //   Data[i].deviceDataModel.SerialNumber = i + 1;
                pnlDeviceList.Controls.Add(Data[i]);
            }

            //FrmScheduleData test = new FrmScheduleData();
            //test.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tbDevices_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenDeviceList_Click(object sender, EventArgs e)
        {
            if (DeviceDataManager.IsDirty)
            {
                var dlgResult = MessageBox.Show("Do you want to save the content?", "Want to Save", MessageBoxButtons.YesNoCancel);

                if (dlgResult == DialogResult.Yes)
                {
                    DeviceDataManager.SaveDataToCSV();
                    OpenDeviceListFile();
                }
                else if (dlgResult == DialogResult.No)
                {
                    OpenDeviceListFile();
                }
                else if (dlgResult == DialogResult.Cancel)
                {
                    // Do nothing, Cancelling out the Open file
                }
            }
            else if (!DeviceDataManager.IsDirty)
            {
                //var dlgResult = MessageBox.Show("Do you want to proceed? It will clear the current list.", "Want to Proceed", buttons: MessageBoxButtons.YesNo);
                //if (dlgResult == DialogResult.Yes)
                //{
                //    ClearDeviceList();
                //}
                //else if (dlgResult == DialogResult.No)
                //{
                //    // Dont do anything, Cancelling Out...........
                //}   // Not required As of now......

                OpenDeviceListFile();
            }

           // OpenDeviceListFile();
        }

        private void OpenDeviceListFile()
        {
            string filePath = String.Empty;
            // List<DeviceDataModel> deviceDataList = new List<DeviceDataModel>();
            List<DeviceData> dataUI = new List<DeviceData>();
            OpenFileDialog OFDialog = new OpenFileDialog();

            DialogResult result = OFDialog.ShowDialog(); // Show the dialog.
            OFDialog.DefaultExt = BellConstants.BellCSVExtention;
            if (result == DialogResult.OK) // Test result.
            {
                filePath = OFDialog.FileName;
                DeviceDataManager.DeviceListFilePath = filePath;
                DeviceDataManager.LoadData();
            }
            dataUI = DeviceDataManager.DeviceDataUI;
            pnlDeviceList.Controls.Clear();
            for (int i = 0; i < dataUI.Count; i++)
            {
                DeviceData TempDataUi = dataUI[i];
                DeviceDataModel DDM = new DeviceDataModel();
                DDM = TempDataUi.deviceDataModel;
                DDM.SerialNumber = i + 1;
                TempDataUi.deviceDataModel = DDM;
                TempDataUi.Location = new Point(0, (i * 33));
                TempDataUi.Controls["btnDelete"].Click += DeleteDeviceFromList;
                TempDataUi.Controls["chkDownload"].Click += SelectDownloadFromList;
                TempDataUi.MakeDirty += DeviceDataManager.ActionMakeDirty;

                pnlDeviceList.Controls.Add(TempDataUi);
            }
        }

        private void btnSaveDeviceList_Click(object sender, EventArgs e)
        {
           
            DeviceDataManager.SaveDataToCSV();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            pnlDeviceList.Controls.Add(DeviceDataManager.AddEmptyDeviceData(DeleteDeviceFromList, SelectDownloadFromList));
        }

        public void DeleteDeviceFromList(object sender, EventArgs e)
        {
            int SerialNumber = ((DeviceData)((Control)sender).Parent).deviceDataModel.SerialNumber;
            DeviceDataManager.DeleteDeviceData(SerialNumber);
            UpdateDeviceListUI();
        }

        public void SelectDownloadFromList(object sender, EventArgs e)
        {
            int SerialNumber = ((DeviceData)((Control)sender).Parent).deviceDataModel.SerialNumber;
           if (((CheckBox)((Control)sender)).Checked)
            {
                DeviceDataManager.SelectDownloadDevice(SerialNumber);
            }
               
        }

        private void btnCloseDeviceList_Click(object sender, EventArgs e)
        {
            bool IsDirtyOrEmptyPath = (DeviceDataManager.IsDirty || string.IsNullOrEmpty(DeviceDataManager.DeviceListFilePath));
            if (IsDirtyOrEmptyPath)
               
            {
                var dlgResult = MessageBox.Show("Do you want to save the content?", "Want to Save", buttons: MessageBoxButtons.YesNoCancel);
                if (dlgResult == DialogResult.Yes)
                {
                    DeviceDataManager.SaveDataToCSV();
                    ClearDeviceList();
                }
                else if (dlgResult == DialogResult.No)
                {
                    ClearDeviceList();
                }
                else if (dlgResult == DialogResult.Cancel)
                {
                    // Dont do anything, Cancelling Out...........
                }
            }
            else if (!IsDirtyOrEmptyPath)
            {
                var dlgResult = MessageBox.Show("Do you want to proceed? It will clear the current list.", "Want to Proceed", buttons: MessageBoxButtons.YesNo);
                if (dlgResult == DialogResult.Yes)
                {
                    ClearDeviceList();
                }
                else if (dlgResult == DialogResult.No)
                {
                    // Dont do anything, Cancelling Out...........
                }
            }

        }

        private void ClearDeviceList()
        {
            pnlDeviceList.Controls.Clear();
            DeviceDataManager.DeviceDataUI.Clear();
            DeviceDataManager.ResetDirtyFlag();
            this.Invalidate();
        }

        public void DeleteScheduleFromList(object sender, EventArgs e)
        {
            int SerialNumber = ((ScheduleData)((Control)sender).Parent).scheduleDM.SerialNumber;
            ScheduleDataManager.DeleteScheduleData(SerialNumber);
            UpdateBellListUI();
            
        }

        private void btnOpenBellList_Click(object sender, EventArgs e)
        {
            if (ScheduleDataManager.IsDirty)
            {
                var dlgResult = MessageBox.Show("Do you want to save the content?", "Want to Save", MessageBoxButtons.YesNoCancel);
                if (dlgResult == DialogResult.Yes)
                {
                    ScheduleDataManager.SaveDataToCSV();
                    OpenBellList();
                }
                else if (dlgResult == DialogResult.No)
                {
                    OpenBellList();
                }
                else if (dlgResult == DialogResult.Cancel)
                {
                  // Cancelling out the Open Bell List....
                }
            }
            else if (!ScheduleDataManager.IsDirty)
            {
                OpenBellList();
            }

        }

        private void OpenBellList()
        {
            string filePath = String.Empty;
            List<ScheduleData> dataUI = new List<ScheduleData>();
            OpenFileDialog OFDialog = new OpenFileDialog();

            DialogResult result = OFDialog.ShowDialog(); // Show the dialog.
            OFDialog.DefaultExt = BellConstants.BellCSVExtention;
            if (result == DialogResult.OK && !string.IsNullOrEmpty(OFDialog.FileName))
            {
                filePath = OFDialog.FileName;

                ScheduleDataManager.BellListFilePath = filePath;
                ScheduleDataManager.LoadData();

                dataUI = ScheduleDataManager.BellDataUI;
                pnlScheduleContainer.Controls.Clear();
                for (int i = 0; i < dataUI.Count; i++)
                {
                    ScheduleData TempDataUi = dataUI[i];
                    ScheduleDataModel SDM = new ScheduleDataModel();
                    SDM = TempDataUi.scheduleDM;
                    SDM.SerialNumber = i + 1;
                    TempDataUi.scheduleDM = SDM;
                    TempDataUi.Location = new Point(0, (i * 38));
                    TempDataUi.Controls["btnDelete"].Click += DeleteScheduleFromList;
                    TempDataUi.MakeDirty += ScheduleDataManager.ActionMakeDirty;
                    pnlScheduleContainer.Controls.Add(TempDataUi);
                }

                ScheduleDataManager.ResetDirtyFlag();
            }
        }

        private void btnAddBellData_Click(object sender, EventArgs e)
        {
            pnlScheduleContainer.Controls.Add(ScheduleDataManager.AddEmptyScheduleData(DeleteScheduleFromList));
        }

        private void btnSaveScheduleData_Click(object sender, EventArgs e)
        {
            
            ScheduleDataManager.SaveDataToCSV();
        }

        private void btnCloseBellList_Click(object sender, EventArgs e)
        {
            bool IsDirtyOrEmptyPath = (ScheduleDataManager.IsDirty || string.IsNullOrEmpty(ScheduleDataManager.BellListFilePath));

            if (IsDirtyOrEmptyPath)
            {
                var dlgResult = MessageBox.Show("Do you want to save the content?", "Want to Save", buttons: MessageBoxButtons.YesNoCancel);
                if (dlgResult == DialogResult.Yes)
                {
                    ScheduleDataManager.SaveDataToCSV();
                    ClearBellList();
                }
                else if (dlgResult == DialogResult.No)
                {
                    ClearBellList();
                }
                else if (dlgResult == DialogResult.Cancel)
                {
                    // Dont do anything, Cancelling Out...........
                }
                
            }
            else if (!IsDirtyOrEmptyPath)
            {
              var  dlgResult = MessageBox.Show("Do you want to proceed? It will clear the current list.", "Want to Proceed", buttons: MessageBoxButtons.YesNo);
              if (dlgResult ==  DialogResult.Yes)
                {
                    ClearBellList();
                }
              else if (dlgResult == DialogResult.No)
                {
                    // Dont do anything, Cancelling Out...........
                }
            }

        }

        private void ClearBellList()
        {
            pnlScheduleContainer.Controls.Clear();
            ScheduleDataManager.BellDataUI.Clear();
            ScheduleDataManager.ResetDirtyFlag();
            this.Invalidate();
        }

        private void btnDownloadBellList_Click(object sender, EventArgs e)
        {
            if ((ScheduleDataManager.IsDirty) &&
                (MessageBox.Show("Do you want to save the existing content?", "Want to Save", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                ScheduleDataManager.SaveDataToCSV();
            }

            BellComunication BellComObj = BellComunication.ObjCommunication;
            string content = BellComObj.DownloadString();
            if (!BellConstants.IsSuccess)
            {
                if (string.IsNullOrEmpty(BellConstants.ErrorMessage))
                {
                    MessageBox.Show("Information is not downloaded due some unknown reason, please try again.");
                }
                else
                {
                    MessageBox.Show(BellConstants.ErrorMessage);
                }
                return;
            }
            
            string[] splitSeparator = { Environment.NewLine };
            string[] Content = content.Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries);
            {
                
                ScheduleDataManager.LoadData(Content);
                List<ScheduleData> dataUI = new List<ScheduleData>();
                dataUI = ScheduleDataManager.BellDataUI;
                pnlScheduleContainer.Controls.Clear();
                for (int i = 0; i < dataUI.Count; i++)
                {
                    ScheduleData TempDataUi = dataUI[i];
                    ScheduleDataModel SDM = new ScheduleDataModel();
                    SDM = TempDataUi.scheduleDM;
                    SDM.SerialNumber = i + 1;
                    TempDataUi.scheduleDM = SDM;
                    TempDataUi.Location = new Point(0, (i * 38));
                    TempDataUi.Controls["btnDelete"].Click += DeleteScheduleFromList;
                    TempDataUi.MakeDirty += ScheduleDataManager.ActionMakeDirty;
                    pnlScheduleContainer.Controls.Add(TempDataUi);
                }
            }

        }

        private void btnUploadBell_Click(object sender, EventArgs e)
        {
            BellComunication.ObjCommunication.UploadBells(ScheduleDataManager.GetListOfBells());
        }

        private void btnMultiDeviceUpload_Click(object sender, EventArgs e)
        {
            BellComunication.ObjCommunication.UploadBellsToMultipleDevice(ScheduleDataManager.GetListOfBells(), DeviceDataManager.DeviceDataUI);
        }

        private void BellForm_Load(object sender, EventArgs e)
        {
             pnlTestControls.Visible = false;
            menuStrip1.Visible = false;
        }

        private void btnSaveAsScheduleData_Click(object sender, EventArgs e)
        {
            ScheduleDataManager.SaveDataToCSV(SaveAs:true);
        }

        private void btnSaveAsDeviceList_Click(object sender, EventArgs e)
        {
            DeviceDataManager.SaveDataToCSV(SaveAs:true);
        }

       
    }
}
