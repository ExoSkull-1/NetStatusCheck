namespace NetStatusCheck
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPing = new System.Windows.Forms.Label();
            this.imgStatus = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numMaxTimeout = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter IP-Address:";
            // 
            // txtIP
            // 
            this.txtIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtIP.Location = new System.Drawing.Point(407, 10);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(176, 23);
            this.txtIP.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnStart.Location = new System.Drawing.Point(76, 80);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(685, 39);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Begin watching";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(72, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Interval:";
            // 
            // numInterval
            // 
            this.numInterval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numInterval.Location = new System.Drawing.Point(229, 48);
            this.numInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(127, 20);
            this.numInterval.TabIndex = 4;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(362, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "sec";
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StatusBox.Location = new System.Drawing.Point(12, 125);
            this.StatusBox.Multiline = true;
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusBox.Size = new System.Drawing.Size(822, 306);
            this.StatusBox.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClear.Location = new System.Drawing.Point(12, 437);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(389, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Status";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // lblPing
            // 
            this.lblPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPing.AutoSize = true;
            this.lblPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblPing.Location = new System.Drawing.Point(799, 88);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(35, 22);
            this.lblPing.TabIndex = 8;
            this.lblPing.Text = "[   ]";
            // 
            // imgStatus
            // 
            this.imgStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgStatus.BackColor = System.Drawing.Color.White;
            this.imgStatus.Location = new System.Drawing.Point(803, 60);
            this.imgStatus.Name = "imgStatus";
            this.imgStatus.Size = new System.Drawing.Size(25, 25);
            this.imgStatus.TabIndex = 9;
            this.imgStatus.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(723, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "sec";
            // 
            // numMaxTimeout
            // 
            this.numMaxTimeout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numMaxTimeout.Location = new System.Drawing.Point(590, 49);
            this.numMaxTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMaxTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxTimeout.Name = "numMaxTimeout";
            this.numMaxTimeout.Size = new System.Drawing.Size(127, 20);
            this.numMaxTimeout.TabIndex = 11;
            this.numMaxTimeout.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.Location = new System.Drawing.Point(433, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max Timeout:";
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSaveLog.Location = new System.Drawing.Point(437, 437);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(397, 39);
            this.btnSaveLog.TabIndex = 13;
            this.btnSaveLog.Text = "Save log";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 480);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numMaxTimeout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imgStatus);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "NetStatusCheck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.PictureBox imgStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMaxTimeout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveLog;
    }
}

