namespace WinPortScanner
{
    partial class FormPortScanner
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtEndPort = new System.Windows.Forms.TextBox();
            this.txtStartPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblEndPort = new System.Windows.Forms.Label();
            this.lblStartPort = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureProcessing = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.txtEndPort);
            this.groupBox1.Controls.Add(this.txtStartPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.lblEndPort);
            this.groupBox1.Controls.Add(this.lblStartPort);
            this.groupBox1.Controls.Add(this.lblIp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.875F);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 251);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome: ";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(281, 193);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(108, 41);
            this.btnScan.TabIndex = 13;
            this.btnScan.Text = "Start Scanning";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtEndPort
            // 
            this.txtEndPort.Location = new System.Drawing.Point(272, 119);
            this.txtEndPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndPort.Name = "txtEndPort";
            this.txtEndPort.Size = new System.Drawing.Size(119, 32);
            this.txtEndPort.TabIndex = 12;
            this.txtEndPort.Text = "650";
            // 
            // txtStartPort
            // 
            this.txtStartPort.Location = new System.Drawing.Point(272, 79);
            this.txtStartPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStartPort.Name = "txtStartPort";
            this.txtStartPort.Size = new System.Drawing.Size(119, 32);
            this.txtStartPort.TabIndex = 11;
            this.txtStartPort.Text = "1";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(229, 39);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(161, 32);
            this.txtIp.TabIndex = 10;
            this.txtIp.Text = "127.0.0.1";
            // 
            // lblEndPort
            // 
            this.lblEndPort.AutoSize = true;
            this.lblEndPort.Location = new System.Drawing.Point(16, 119);
            this.lblEndPort.Name = "lblEndPort";
            this.lblEndPort.Size = new System.Drawing.Size(103, 26);
            this.lblEndPort.TabIndex = 9;
            this.lblEndPort.Text = "End Port:";
            // 
            // lblStartPort
            // 
            this.lblStartPort.AutoSize = true;
            this.lblStartPort.Location = new System.Drawing.Point(16, 79);
            this.lblStartPort.Name = "lblStartPort";
            this.lblStartPort.Size = new System.Drawing.Size(110, 26);
            this.lblStartPort.TabIndex = 8;
            this.lblStartPort.Text = "Start Port:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(16, 39);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(198, 26);
            this.lblIp.TabIndex = 7;
            this.lblIp.Text = "IP address to scan:";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(8, 262);
            this.richTextBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(457, 287);
            this.richTextBoxResult.TabIndex = 8;
            this.richTextBoxResult.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Crimson;
            this.btnStop.Location = new System.Drawing.Point(308, 570);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(157, 54);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSave.Location = new System.Drawing.Point(80, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 53);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureProcessing
            // 
            this.pictureProcessing.Image = global::WinPortScanner.Properties.Resources.loop_unscreen;
            this.pictureProcessing.Location = new System.Drawing.Point(471, 262);
            this.pictureProcessing.Name = "pictureProcessing";
            this.pictureProcessing.Size = new System.Drawing.Size(187, 170);
            this.pictureProcessing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProcessing.TabIndex = 11;
            this.pictureProcessing.TabStop = false;
            // 
            // FormPortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 668);
            this.Controls.Add(this.pictureProcessing);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPortScanner";
            this.Text = "PortScanner ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPortScanner_FormClosing);
            this.Load += new System.EventHandler(this.FormPortScanner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcessing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtEndPort;
        private System.Windows.Forms.TextBox txtStartPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblEndPort;
        private System.Windows.Forms.Label lblStartPort;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureProcessing;
    }
}