using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellScheduler
{
    public partial class DeviceData : UserControl
    {
        public int DeviceNumber
        { 
        get
        {
                return Convert.ToInt32(lblNumber.Text);  //txtHost.Text;
        }
        set
        {
                lblNumber.Text = value.ToString();
        }

     }
        public DeviceData()
        {
            InitializeComponent();
        }
    }
}
