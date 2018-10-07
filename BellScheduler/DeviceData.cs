using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BellScheduler
{
    public partial class DeviceData : UserControl
    {
        private DeviceDataModel _deviceDM;

        public event Action MakeDirty;
        public DeviceDataModel deviceDataModel
        {
            get
            {
                if (_deviceDM.DoClear != chkClear.Checked
                     || _deviceDM.Host != txtHost.Text
                     || _deviceDM.Port != txtPort.Text
                     || _deviceDM.UserName != txtUserName.Text
                     || _deviceDM.Password != txtPassword.Text
                     || _deviceDM.Password != txtPassword.Text)
                {
                    MakeDirty?.Invoke();
                }

                _deviceDM.SerialNumber = Convert.ToInt32(lblNumber.Text);
                _deviceDM.DoClear = chkClear.Checked;
                _deviceDM.Host = txtHost.Text;
                _deviceDM.Port = txtPort.Text;
                _deviceDM.UserName = txtUserName.Text;
                _deviceDM.Password = txtPassword.Text;
                _deviceDM.Password = txtPassword.Text;
                return _deviceDM;
            }
            
            set
            {
                lblNumber.Text =  value.SerialNumber.ToString();
                chkClear.Checked = _deviceDM.DoClear = value.DoClear;
                txtHost.Text = _deviceDM.Host = value.Host;
                txtPort.Text = _deviceDM.Port = value.Port;
                txtUserName.Text = _deviceDM.UserName = value.UserName;
                txtPassword.Text = _deviceDM.Password = value.Password;
                nudDelay.Value = value.Delay;

                if ((value.SerialNumber % 2) == 0)
                {
                    this.BackColor = Color.Snow;
                }
                else
                {
                    this.BackColor = Color.OldLace;
                }

            }
        }
       
       
        public DeviceData()
        {
            _deviceDM = new DeviceDataModel();
           
            InitializeComponent();

        }

        public void UnCheckForDownload()
        {
            chkDownload.Checked = false;
        }
        public void SelectForDownload()
        {
            chkDownload.Checked = true;
        }
    }

}
