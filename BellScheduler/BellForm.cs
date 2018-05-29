using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellScheduler
{
    public partial class BellForm : Form
    {

        public void Download()
        {
            BellComunication BellComObj = new BellComunication();
            string content = BellComObj.DownloadString();
            string[] splitSeparator = { Environment.NewLine };
            BellContent.ObjContent.Content = content.Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries);
            rtbContent.Lines = BellContent.ObjContent.Content;
            BellContent.ObjContent.IsChanged = false;
        }
        public void Save()
        {

        }

        public void CloseBell()
        {
            if (!BellContent.ObjContent.IsSaved)
            {
                MessageBox.Show("This needs to save first");
            }
        }
        public BellForm()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            Download();
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            BellContent.ObjContent.IsChanged = true;
          
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseBell();
        }
    }
}
