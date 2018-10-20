namespace BellScheduler
{
    partial class BellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BellForm));
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDeviceList = new System.Windows.Forms.Panel();
            this.pnlHeaderDeviceList = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblClearSchedule = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBellNumbers = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBell = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlScheduleContainer = new System.Windows.Forms.Panel();
            this.pnlTestControls = new System.Windows.Forms.Panel();
            this.btnDownloadBellList = new System.Windows.Forms.Button();
            this.btnUploadBell = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbSchedule = new System.Windows.Forms.TabPage();
            this.pnlContainerForScheduleTab = new System.Windows.Forms.Panel();
            this.pnlScheduleButton = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseBellList = new System.Windows.Forms.Button();
            this.btnAddBellData = new System.Windows.Forms.Button();
            this.btnOpenBellList = new System.Windows.Forms.Button();
            this.btnSaveScheduleData = new System.Windows.Forms.Button();
            this.tbDevices = new System.Windows.Forms.TabPage();
            this.pndDeviceTabContainer = new System.Windows.Forms.Panel();
            this.PnlDeviceButtons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSingleDownload = new System.Windows.Forms.Button();
            this.btnOpenDeviceList = new System.Windows.Forms.Button();
            this.btnCloseDeviceList = new System.Windows.Forms.Button();
            this.btnSaveDeviceList = new System.Windows.Forms.Button();
            this.btnMultiDeviceUpload = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnSaveAsScheduleData = new System.Windows.Forms.Button();
            this.btnSaveAsDeviceList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeaderDeviceList.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlScheduleContainer.SuspendLayout();
            this.pnlTestControls.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tbSchedule.SuspendLayout();
            this.pnlContainerForScheduleTab.SuspendLayout();
            this.pnlScheduleButton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbDevices.SuspendLayout();
            this.pndDeviceTabContainer.SuspendLayout();
            this.PnlDeviceButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbContent.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(3, 15);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(124, 125);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            this.rtbContent.TextChanged += new System.EventHandler(this.rtbContent_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(47, 14);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(87, 34);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1340, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Visible = false;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 53);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(59, 82);
            this.btnSaveAs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(59, 111);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 34);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(59, 151);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 33);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnSaveAs);
            this.panel1.Location = new System.Drawing.Point(76, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 108);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDeviceList
            // 
            this.pnlDeviceList.AutoScroll = true;
            this.pnlDeviceList.BackColor = System.Drawing.Color.LightBlue;
            this.pnlDeviceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDeviceList.Location = new System.Drawing.Point(3, 34);
            this.pnlDeviceList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDeviceList.Name = "pnlDeviceList";
            this.pnlDeviceList.Size = new System.Drawing.Size(1031, 601);
            this.pnlDeviceList.TabIndex = 8;
            // 
            // pnlHeaderDeviceList
            // 
            this.pnlHeaderDeviceList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeaderDeviceList.Controls.Add(this.label10);
            this.pnlHeaderDeviceList.Controls.Add(this.label1);
            this.pnlHeaderDeviceList.Controls.Add(this.lblPassword);
            this.pnlHeaderDeviceList.Controls.Add(this.lblUserName);
            this.pnlHeaderDeviceList.Controls.Add(this.lblPort);
            this.pnlHeaderDeviceList.Controls.Add(this.lblHost);
            this.pnlHeaderDeviceList.Controls.Add(this.lblClearSchedule);
            this.pnlHeaderDeviceList.Controls.Add(this.lblNumber);
            this.pnlHeaderDeviceList.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeaderDeviceList.Location = new System.Drawing.Point(3, 2);
            this.pnlHeaderDeviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeaderDeviceList.Name = "pnlHeaderDeviceList";
            this.pnlHeaderDeviceList.Size = new System.Drawing.Size(998, 33);
            this.pnlHeaderDeviceList.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(883, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Download";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delay(ms)";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(573, 6);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(448, 6);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "UserName";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(359, 6);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(44, 20);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHost.Location = new System.Drawing.Point(157, 6);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(118, 20);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Server Name";
            // 
            // lblClearSchedule
            // 
            this.lblClearSchedule.AutoSize = true;
            this.lblClearSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearSchedule.Location = new System.Drawing.Point(36, 6);
            this.lblClearSchedule.Name = "lblClearSchedule";
            this.lblClearSchedule.Size = new System.Drawing.Size(54, 20);
            this.lblClearSchedule.TabIndex = 1;
            this.lblClearSchedule.Text = "Clear";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(0, 6);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(32, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "No";
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.BackColor = System.Drawing.Color.LightBlue;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.label9);
            this.pnlHeader.Controls.Add(this.label8);
            this.pnlHeader.Controls.Add(this.label6);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.lblBellNumbers);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.label5);
            this.pnlHeader.Controls.Add(this.lblBell);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.lblName);
            this.pnlHeader.Controls.Add(this.label7);
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(4, 2);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1103, 46);
            this.pnlHeader.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(932, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Use";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(829, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "S    M    T    W    T    F    S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "-- -- --  -Day- -- -- --";
            // 
            // lblBellNumbers
            // 
            this.lblBellNumbers.AutoSize = true;
            this.lblBellNumbers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBellNumbers.Location = new System.Drawing.Point(284, 18);
            this.lblBellNumbers.Name = "lblBellNumbers";
            this.lblBellNumbers.Size = new System.Drawing.Size(193, 20);
            this.lblBellNumbers.TabIndex = 8;
            this.lblBellNumbers.Text = "1    2    3    4    5    6    7    8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(981, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Once";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(880, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "PW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(737, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // lblBell
            // 
            this.lblBell.AutoSize = true;
            this.lblBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBell.Location = new System.Drawing.Point(284, -1);
            this.lblBell.Name = "lblBell";
            this.lblBell.Size = new System.Drawing.Size(182, 20);
            this.lblBell.TabIndex = 3;
            this.lblBell.Text = "-- -- --  -Bell- -- -- --";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(192, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(69, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "No";
            // 
            // pnlScheduleContainer
            // 
            this.pnlScheduleContainer.AutoScroll = true;
            this.pnlScheduleContainer.BackColor = System.Drawing.Color.LightBlue;
            this.pnlScheduleContainer.Controls.Add(this.pnlTestControls);
            this.pnlScheduleContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlScheduleContainer.Location = new System.Drawing.Point(4, 48);
            this.pnlScheduleContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlScheduleContainer.Name = "pnlScheduleContainer";
            this.pnlScheduleContainer.Size = new System.Drawing.Size(1133, 603);
            this.pnlScheduleContainer.TabIndex = 5;
            // 
            // pnlTestControls
            // 
            this.pnlTestControls.Controls.Add(this.btnDownloadBellList);
            this.pnlTestControls.Controls.Add(this.rtbContent);
            this.pnlTestControls.Controls.Add(this.btnUploadBell);
            this.pnlTestControls.Location = new System.Drawing.Point(792, 316);
            this.pnlTestControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTestControls.Name = "pnlTestControls";
            this.pnlTestControls.Size = new System.Drawing.Size(272, 188);
            this.pnlTestControls.TabIndex = 4;
            // 
            // btnDownloadBellList
            // 
            this.btnDownloadBellList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadBellList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadBellList.Location = new System.Drawing.Point(144, 80);
            this.btnDownloadBellList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownloadBellList.Name = "btnDownloadBellList";
            this.btnDownloadBellList.Size = new System.Drawing.Size(100, 34);
            this.btnDownloadBellList.TabIndex = 5;
            this.btnDownloadBellList.Text = "Download";
            this.btnDownloadBellList.UseVisualStyleBackColor = true;
            this.btnDownloadBellList.Click += new System.EventHandler(this.btnDownloadBellList_Click);
            // 
            // btnUploadBell
            // 
            this.btnUploadBell.BackColor = System.Drawing.Color.LightBlue;
            this.btnUploadBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadBell.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadBell.Location = new System.Drawing.Point(152, 34);
            this.btnUploadBell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadBell.Name = "btnUploadBell";
            this.btnUploadBell.Size = new System.Drawing.Size(85, 33);
            this.btnUploadBell.TabIndex = 4;
            this.btnUploadBell.Text = "Upload";
            this.btnUploadBell.UseVisualStyleBackColor = false;
            this.btnUploadBell.Click += new System.EventHandler(this.btnUploadBell_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbSchedule);
            this.tabControl.Controls.Add(this.tbDevices);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1340, 683);
            this.tabControl.TabIndex = 10;
            // 
            // tbSchedule
            // 
            this.tbSchedule.BackColor = System.Drawing.Color.LightBlue;
            this.tbSchedule.Controls.Add(this.pnlContainerForScheduleTab);
            this.tbSchedule.Controls.Add(this.pnlScheduleButton);
            this.tbSchedule.Location = new System.Drawing.Point(4, 32);
            this.tbSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSchedule.Name = "tbSchedule";
            this.tbSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSchedule.Size = new System.Drawing.Size(1332, 647);
            this.tbSchedule.TabIndex = 0;
            this.tbSchedule.Text = "  Bell Schedule   ";
            this.tbSchedule.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pnlContainerForScheduleTab
            // 
            this.pnlContainerForScheduleTab.BackColor = System.Drawing.Color.LightBlue;
            this.pnlContainerForScheduleTab.Controls.Add(this.pnlHeader);
            this.pnlContainerForScheduleTab.Controls.Add(this.pnlScheduleContainer);
            this.pnlContainerForScheduleTab.Location = new System.Drawing.Point(3, 2);
            this.pnlContainerForScheduleTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainerForScheduleTab.Name = "pnlContainerForScheduleTab";
            this.pnlContainerForScheduleTab.Size = new System.Drawing.Size(1143, 661);
            this.pnlContainerForScheduleTab.TabIndex = 11;
            // 
            // pnlScheduleButton
            // 
            this.pnlScheduleButton.BackColor = System.Drawing.Color.LightBlue;
            this.pnlScheduleButton.Controls.Add(this.panel2);
            this.pnlScheduleButton.Location = new System.Drawing.Point(1168, 10);
            this.pnlScheduleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlScheduleButton.Name = "pnlScheduleButton";
            this.pnlScheduleButton.Size = new System.Drawing.Size(153, 667);
            this.pnlScheduleButton.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSaveAsScheduleData);
            this.panel2.Controls.Add(this.btnCloseBellList);
            this.panel2.Controls.Add(this.btnAddBellData);
            this.panel2.Controls.Add(this.btnOpenBellList);
            this.panel2.Controls.Add(this.btnSaveScheduleData);
            this.panel2.Location = new System.Drawing.Point(9, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 264);
            this.panel2.TabIndex = 3;
            // 
            // btnCloseBellList
            // 
            this.btnCloseBellList.BackColor = System.Drawing.Color.LightBlue;
            this.btnCloseBellList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBellList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseBellList.Location = new System.Drawing.Point(20, 213);
            this.btnCloseBellList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseBellList.Name = "btnCloseBellList";
            this.btnCloseBellList.Size = new System.Drawing.Size(85, 33);
            this.btnCloseBellList.TabIndex = 3;
            this.btnCloseBellList.Text = "Clear";
            this.btnCloseBellList.UseVisualStyleBackColor = false;
            this.btnCloseBellList.Click += new System.EventHandler(this.btnCloseBellList_Click);
            // 
            // btnAddBellData
            // 
            this.btnAddBellData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBellData.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBellData.Location = new System.Drawing.Point(20, 163);
            this.btnAddBellData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBellData.Name = "btnAddBellData";
            this.btnAddBellData.Size = new System.Drawing.Size(85, 33);
            this.btnAddBellData.TabIndex = 1;
            this.btnAddBellData.Text = "Add Bell";
            this.btnAddBellData.UseVisualStyleBackColor = true;
            this.btnAddBellData.Click += new System.EventHandler(this.btnAddBellData_Click);
            // 
            // btnOpenBellList
            // 
            this.btnOpenBellList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOpenBellList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBellList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBellList.Location = new System.Drawing.Point(20, 17);
            this.btnOpenBellList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenBellList.Name = "btnOpenBellList";
            this.btnOpenBellList.Size = new System.Drawing.Size(85, 33);
            this.btnOpenBellList.TabIndex = 0;
            this.btnOpenBellList.Text = "Open";
            this.btnOpenBellList.UseVisualStyleBackColor = true;
            this.btnOpenBellList.Click += new System.EventHandler(this.btnOpenBellList_Click);
            // 
            // btnSaveScheduleData
            // 
            this.btnSaveScheduleData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveScheduleData.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScheduleData.Location = new System.Drawing.Point(20, 69);
            this.btnSaveScheduleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveScheduleData.Name = "btnSaveScheduleData";
            this.btnSaveScheduleData.Size = new System.Drawing.Size(85, 33);
            this.btnSaveScheduleData.TabIndex = 2;
            this.btnSaveScheduleData.Text = "Save";
            this.btnSaveScheduleData.UseVisualStyleBackColor = true;
            this.btnSaveScheduleData.Click += new System.EventHandler(this.btnSaveScheduleData_Click);
            // 
            // tbDevices
            // 
            this.tbDevices.BackColor = System.Drawing.Color.LightBlue;
            this.tbDevices.Controls.Add(this.pndDeviceTabContainer);
            this.tbDevices.Location = new System.Drawing.Point(4, 32);
            this.tbDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDevices.Name = "tbDevices";
            this.tbDevices.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDevices.Size = new System.Drawing.Size(1332, 647);
            this.tbDevices.TabIndex = 1;
            this.tbDevices.Text = "  Device List   ";
            this.tbDevices.Click += new System.EventHandler(this.tbDevices_Click);
            // 
            // pndDeviceTabContainer
            // 
            this.pndDeviceTabContainer.BackColor = System.Drawing.Color.LightBlue;
            this.pndDeviceTabContainer.Controls.Add(this.pnlHeaderDeviceList);
            this.pndDeviceTabContainer.Controls.Add(this.PnlDeviceButtons);
            this.pndDeviceTabContainer.Controls.Add(this.pnlDeviceList);
            this.pndDeviceTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pndDeviceTabContainer.Location = new System.Drawing.Point(3, 2);
            this.pndDeviceTabContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pndDeviceTabContainer.Name = "pndDeviceTabContainer";
            this.pndDeviceTabContainer.Size = new System.Drawing.Size(1326, 643);
            this.pndDeviceTabContainer.TabIndex = 10;
            // 
            // PnlDeviceButtons
            // 
            this.PnlDeviceButtons.Controls.Add(this.panel3);
            this.PnlDeviceButtons.Controls.Add(this.panel1);
            this.PnlDeviceButtons.Location = new System.Drawing.Point(1059, 10);
            this.PnlDeviceButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlDeviceButtons.Name = "PnlDeviceButtons";
            this.PnlDeviceButtons.Size = new System.Drawing.Size(209, 498);
            this.PnlDeviceButtons.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSaveAsDeviceList);
            this.panel3.Controls.Add(this.btnSingleDownload);
            this.panel3.Controls.Add(this.btnOpenDeviceList);
            this.panel3.Controls.Add(this.btnCloseDeviceList);
            this.panel3.Controls.Add(this.btnSaveDeviceList);
            this.panel3.Controls.Add(this.btnMultiDeviceUpload);
            this.panel3.Controls.Add(this.btnAddDevice);
            this.panel3.Location = new System.Drawing.Point(27, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 353);
            this.panel3.TabIndex = 13;
            // 
            // btnSingleDownload
            // 
            this.btnSingleDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleDownload.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleDownload.Location = new System.Drawing.Point(19, 200);
            this.btnSingleDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSingleDownload.Name = "btnSingleDownload";
            this.btnSingleDownload.Size = new System.Drawing.Size(113, 34);
            this.btnSingleDownload.TabIndex = 13;
            this.btnSingleDownload.Text = "Download";
            this.btnSingleDownload.UseVisualStyleBackColor = true;
            this.btnSingleDownload.Click += new System.EventHandler(this.btnDownloadBellList_Click);
            // 
            // btnOpenDeviceList
            // 
            this.btnOpenDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDeviceList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDeviceList.Location = new System.Drawing.Point(31, 18);
            this.btnOpenDeviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenDeviceList.Name = "btnOpenDeviceList";
            this.btnOpenDeviceList.Size = new System.Drawing.Size(88, 33);
            this.btnOpenDeviceList.TabIndex = 8;
            this.btnOpenDeviceList.Text = "Open";
            this.btnOpenDeviceList.UseVisualStyleBackColor = true;
            this.btnOpenDeviceList.Click += new System.EventHandler(this.btnOpenDeviceList_Click);
            // 
            // btnCloseDeviceList
            // 
            this.btnCloseDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDeviceList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseDeviceList.Location = new System.Drawing.Point(31, 301);
            this.btnCloseDeviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseDeviceList.Name = "btnCloseDeviceList";
            this.btnCloseDeviceList.Size = new System.Drawing.Size(88, 34);
            this.btnCloseDeviceList.TabIndex = 12;
            this.btnCloseDeviceList.Text = "Clear";
            this.btnCloseDeviceList.UseVisualStyleBackColor = true;
            this.btnCloseDeviceList.Click += new System.EventHandler(this.btnCloseDeviceList_Click);
            // 
            // btnSaveDeviceList
            // 
            this.btnSaveDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDeviceList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDeviceList.Location = new System.Drawing.Point(31, 65);
            this.btnSaveDeviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveDeviceList.Name = "btnSaveDeviceList";
            this.btnSaveDeviceList.Size = new System.Drawing.Size(88, 33);
            this.btnSaveDeviceList.TabIndex = 9;
            this.btnSaveDeviceList.Text = "Save";
            this.btnSaveDeviceList.UseVisualStyleBackColor = true;
            this.btnSaveDeviceList.Click += new System.EventHandler(this.btnSaveDeviceList_Click);
            // 
            // btnMultiDeviceUpload
            // 
            this.btnMultiDeviceUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiDeviceUpload.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiDeviceUpload.Location = new System.Drawing.Point(31, 250);
            this.btnMultiDeviceUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMultiDeviceUpload.Name = "btnMultiDeviceUpload";
            this.btnMultiDeviceUpload.Size = new System.Drawing.Size(88, 34);
            this.btnMultiDeviceUpload.TabIndex = 11;
            this.btnMultiDeviceUpload.Text = "Upload";
            this.btnMultiDeviceUpload.UseVisualStyleBackColor = true;
            this.btnMultiDeviceUpload.Click += new System.EventHandler(this.btnMultiDeviceUpload_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDevice.Location = new System.Drawing.Point(19, 155);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(107, 33);
            this.btnAddDevice.TabIndex = 10;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnSaveAsScheduleData
            // 
            this.btnSaveAsScheduleData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAsScheduleData.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsScheduleData.Location = new System.Drawing.Point(19, 115);
            this.btnSaveAsScheduleData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAsScheduleData.Name = "btnSaveAsScheduleData";
            this.btnSaveAsScheduleData.Size = new System.Drawing.Size(85, 33);
            this.btnSaveAsScheduleData.TabIndex = 4;
            this.btnSaveAsScheduleData.Text = "Save As";
            this.btnSaveAsScheduleData.UseVisualStyleBackColor = true;
            this.btnSaveAsScheduleData.Click += new System.EventHandler(this.btnSaveAsScheduleData_Click);
            // 
            // btnSaveAsDeviceList
            // 
            this.btnSaveAsDeviceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAsDeviceList.Font = new System.Drawing.Font("Segoe UI Emoji", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsDeviceList.Location = new System.Drawing.Point(31, 110);
            this.btnSaveAsDeviceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAsDeviceList.Name = "btnSaveAsDeviceList";
            this.btnSaveAsDeviceList.Size = new System.Drawing.Size(88, 33);
            this.btnSaveAsDeviceList.TabIndex = 14;
            this.btnSaveAsDeviceList.Text = "Save As";
            this.btnSaveAsDeviceList.UseVisualStyleBackColor = true;
            this.btnSaveAsDeviceList.Click += new System.EventHandler(this.btnSaveAsDeviceList_Click);
            // 
            // BellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1340, 711);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "BellForm";
            this.Text = "Bell Scheduler";
            this.Load += new System.EventHandler(this.BellForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlHeaderDeviceList.ResumeLayout(false);
            this.pnlHeaderDeviceList.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlScheduleContainer.ResumeLayout(false);
            this.pnlTestControls.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tbSchedule.ResumeLayout(false);
            this.pnlContainerForScheduleTab.ResumeLayout(false);
            this.pnlScheduleButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tbDevices.ResumeLayout(false);
            this.pndDeviceTabContainer.ResumeLayout(false);
            this.PnlDeviceButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDeviceList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbSchedule;
        private System.Windows.Forms.TabPage tbDevices;
        private System.Windows.Forms.Panel PnlDeviceButtons;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnSaveDeviceList;
        private System.Windows.Forms.Button btnOpenDeviceList;
        private System.Windows.Forms.Panel pnlHeaderDeviceList;
        private System.Windows.Forms.Label lblClearSchedule;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel pnlScheduleButton;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBell;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBellNumbers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlScheduleContainer;
        private System.Windows.Forms.Button btnOpenBellList;
        private System.Windows.Forms.Panel pnlContainerForScheduleTab;
        private System.Windows.Forms.Button btnAddBellData;
        private System.Windows.Forms.Button btnSaveScheduleData;
        private System.Windows.Forms.Panel pndDeviceTabContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUploadBell;
        private System.Windows.Forms.Button btnCloseBellList;
        private System.Windows.Forms.Button btnCloseDeviceList;
        private System.Windows.Forms.Button btnMultiDeviceUpload;
        private System.Windows.Forms.Button btnDownloadBellList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTestControls;
        private System.Windows.Forms.Button btnSingleDownload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveAsScheduleData;
        private System.Windows.Forms.Button btnSaveAsDeviceList;
    }
}