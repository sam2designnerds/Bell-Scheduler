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
    public partial class ScheduleData : UserControl
    {
        private ScheduleDataModel _ScheduleDM;

        public event Action MakeDirty;
        public string GetBellNumbers()
        {
            string Result = string.Empty;
            Result += (chkBell1.Checked? "1" : "0");
            Result += (chkBell2.Checked ? "1" : "0");
            Result += (chkBell3.Checked ? "1" : "0");
            Result += (chkBell4.Checked ? "1" : "0");
            Result += (chkBell5.Checked ? "1" : "0");
            Result += (chkBell6.Checked ? "1" : "0");
            Result += (chkBell7.Checked ? "1" : "0");
            Result += (chkBell8.Checked ? "1" : "0");

            return Result;
        }
        public void SetBellNumbers(string BinaryStr)
        {
            if (BinaryStr.Length < 8)
            {
                for (int i = BinaryStr.Length; i < 8; i++)
                {
                    BinaryStr += "0";

                }
            }
            chkBell1.Checked = (BinaryStr[0] != '0');
            chkBell2.Checked = (BinaryStr[1] != '0');
            chkBell3.Checked = (BinaryStr[2] != '0');
            chkBell4.Checked = (BinaryStr[3] != '0');
            chkBell5.Checked = (BinaryStr[4] != '0');
            chkBell6.Checked = (BinaryStr[5] != '0');
            chkBell7.Checked = (BinaryStr[6] != '0');
            chkBell8.Checked = (BinaryStr[7] != '0');

        }

        public string GetBellDays()
        {
            string Result = string.Empty;
            Result += (chkDay1.Checked ? "1" : "0");
            Result += (chkDay2.Checked ? "1" : "0");
            Result += (chkDay3.Checked ? "1" : "0");
            Result += (chkDay4.Checked ? "1" : "0");
            Result += (chkDay5.Checked ? "1" : "0");
            Result += (chkDay6.Checked ? "1" : "0");
            Result += (chkDay7.Checked ? "1" : "0");
            // Result = "1010101";

            return Result;
        }

        public void SetBellDays(string BinaryStr)
        {
            if (BinaryStr.Length < 7)
            {
                for (int i = BinaryStr.Length ; i < 7; i++)
                {
                    BinaryStr += "0";
                }
            }
            chkDay1.Checked = (BinaryStr[0] != '0');
            chkDay2.Checked = (BinaryStr[1] != '0');
            chkDay3.Checked = (BinaryStr[2] != '0');
            chkDay4.Checked = (BinaryStr[3] != '0');
            chkDay5.Checked = (BinaryStr[4] != '0');
            chkDay6.Checked = (BinaryStr[5] != '0');
            chkDay7.Checked = (BinaryStr[6] != '0');
        }

        public ScheduleDataModel scheduleDM
        {
            get
            { 
                 if ( _ScheduleDM.BellName != txtName.Text
                     ||  _ScheduleDM.BellTime != dtpTime.Value
                     ||  _ScheduleDM.BellNumbers != GetBellNumbers()
                     ||  _ScheduleDM.BellDays != GetBellDays()
                     ||  _ScheduleDM.IsDateRequired != chkDate.Checked
                     ||   _ScheduleDM.BellDate != dtpDate.Value
                     ||  _ScheduleDM.BellDuration != Convert.ToInt32(txtDuration.Text)
                     ||  _ScheduleDM.PulseWidth != cmbPulseWidth.Text
                     ||  _ScheduleDM.IsBellUse != chkUse.Checked)
                {
                    MakeDirty?.Invoke();
                }
                 
                _ScheduleDM.SerialNumber = Convert.ToInt32(lblNumber.Text);
                _ScheduleDM.BellName = txtName.Text;
                _ScheduleDM.BellTime = dtpTime.Value;
                _ScheduleDM.BellNumbers = GetBellNumbers();
                _ScheduleDM.BellDays = GetBellDays();
                _ScheduleDM.IsDateRequired = chkDate.Checked;
                _ScheduleDM.BellDate = dtpDate.Value;
                _ScheduleDM.BellDuration = Convert.ToInt32(txtDuration.Text);
                _ScheduleDM.PulseWidth = cmbPulseWidth.Text;
                _ScheduleDM.IsBellUse = chkUse.Checked;
                _ScheduleDM.IsBellOnce = chkOnce.Checked;

                return _ScheduleDM;
            }

            set
            {
                lblNumber.Text = value.SerialNumber.ToString();
                txtName.Text = value.BellName;
                dtpTime.Value = value.BellTime;
                SetBellNumbers(value.BellNumbers);
                SetBellDays(value.BellDays);
                chkDate.Checked = value.IsDateRequired;
                dtpDate.Value = value.BellDate;
                txtDuration.Text = value.BellDuration.ToString();
                cmbPulseWidth.SelectedIndex = cmbPulseWidth.FindStringExact(value.PulseWidth);
                chkUse.Checked = value.IsBellUse;
                chkOnce.Checked = value.IsBellOnce;
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
        public ScheduleData()
        {
            _ScheduleDM = new ScheduleDataModel();
            InitializeComponent();
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {

            dtpDate.Enabled = chkDate.Checked;
            
        }

        private void ScheduleData_Paint(object sender, PaintEventArgs e)
        {
            dtpDate.Enabled = chkDate.Checked;
        }
    }
}
