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
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BellContent.ObjContent.Content = rtbContent.Lines;
            Save();
        }
    }
}
