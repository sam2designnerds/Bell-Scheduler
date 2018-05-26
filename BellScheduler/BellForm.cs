﻿using System;
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
        public BellForm()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            BellComunication BellComObj = new BellComunication();
            string content = BellComObj.DownloadString();
            string[] splitSeparator = {Environment.NewLine};
            rtbContent.Lines = content.Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
