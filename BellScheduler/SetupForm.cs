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
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BellComunication.ObjCommunication.DoClear = chkClear.Checked;
            BellComunication.ObjCommunication.Host = txtHost.Text;
            BellComunication.ObjCommunication.Port = txtPort.Text;
           // BellComunication.ObjCommunication.Protocol = cmbProtocol.Text;
            BellComunication.ObjCommunication.UserName = txtUserName.Text;
            BellComunication.ObjCommunication.Password = txtPassword.Text;
            int delay;
            var CanParse = int.TryParse(txtDelay.Text, out delay);
            if (CanParse)
            {
                BellComunication.ObjCommunication.Delay = delay;
            } 
            else
            {
                MessageBox.Show("Please enter a valid number of Delay filed.");
                return;
            }
            

            BellComunication.ObjCommunication.SaveSettings();
            this.Close();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            BellComunication.ObjCommunication.RetriveSettings();
            chkClear.Checked = BellComunication.ObjCommunication.DoClear;
            txtHost.Text = BellComunication.ObjCommunication.Host;
            txtPort.Text = BellComunication.ObjCommunication.Port;
            txtUserName.Text = BellComunication.ObjCommunication.UserName;
            txtPassword.Text = BellComunication.ObjCommunication.Password;
            txtDelay.Text = BellComunication.ObjCommunication.Delay.ToString();

           // cmbProtocol.SelectedIndex = cmbProtocol.FindStringExact(BellComunication.ObjCommunication.Protocol);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
