namespace BellScheduler
{
    partial class DeviceData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.chkClear = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkDownload = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(7, 9);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(17, 17);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            // 
            // txtHost
            // 
            this.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHost.Location = new System.Drawing.Point(77, 4);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(243, 22);
            this.txtHost.TabIndex = 1;
            // 
            // chkClear
            // 
            this.chkClear.AutoSize = true;
            this.chkClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.chkClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClear.Location = new System.Drawing.Point(44, 10);
            this.chkClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkClear.Name = "chkClear";
            this.chkClear.Size = new System.Drawing.Size(14, 13);
            this.chkClear.TabIndex = 2;
            this.chkClear.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(345, 4);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(75, 22);
            this.txtPort.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(444, 4);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(98, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(567, 4);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(103, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // nudDelay
            // 
            this.nudDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDelay.Location = new System.Drawing.Point(689, 4);
            this.nudDelay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(100, 22);
            this.nudDelay.TabIndex = 6;
            this.nudDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(812, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkDownload
            // 
            this.chkDownload.AutoSize = true;
            this.chkDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDownload.Location = new System.Drawing.Point(935, 9);
            this.chkDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDownload.Name = "chkDownload";
            this.chkDownload.Size = new System.Drawing.Size(14, 13);
            this.chkDownload.TabIndex = 10;
            this.chkDownload.UseVisualStyleBackColor = true;
            // 
            // DeviceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chkDownload);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.chkClear);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeviceData";
            this.Size = new System.Drawing.Size(999, 34);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.CheckBox chkClear;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkDownload;
    }
}
