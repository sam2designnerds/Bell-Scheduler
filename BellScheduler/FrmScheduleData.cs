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
    public partial class FrmScheduleData : Form
    {
        List<ScheduleData> SData = new List<ScheduleData>();
        public FrmScheduleData()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            ScheduleData SD = new ScheduleData();
            SData.Add(SD);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SData.Count; i++)
            {
               SData[i].Location = new Point(10, 30 + (i * 28));
                pnlContent.Controls.Add(SData[i]);

                     //10+(i* Data[i].Height -5)
                //Data[i].Location = new Point(10, 5 + (i * 28));

                //Data[i].DeviceNumber = i + 1;
                //panel2.Controls.Add(Data[i]);
            }
        }
    }
}
