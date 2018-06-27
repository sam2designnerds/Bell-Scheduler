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
            BellComunication.ObjCommunication.Host = txtHost.Text;
            BellComunication.ObjCommunication.Port = txtPort.Text;
            BellComunication.ObjCommunication.Protocol = cmbProtocol.Text;
            BellComunication.ObjCommunication.UserName = txtUserName.Text;
            BellComunication.ObjCommunication.Password = txtPassword.Text;

            BellComunication.ObjCommunication.SaveSettings();
            this.Close();
        }

        private void SetupForm_Load(object sender, EventArgs e)
        {
            BellComunication.ObjCommunication.RetriveSettings();
            txtHost.Text = BellComunication.ObjCommunication.Host;
            txtPort.Text = BellComunication.ObjCommunication.Port;
            txtUserName.Text = BellComunication.ObjCommunication.UserName;
            txtPassword.Text = BellComunication.ObjCommunication.Password;

            cmbProtocol.SelectedIndex = cmbProtocol.FindStringExact(BellComunication.ObjCommunication.Protocol);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
