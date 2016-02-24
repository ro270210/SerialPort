namespace PCComm
{
    partial class FrmSettings
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDataHMI = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStopHMI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParityHMI = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboBaudHMI = new System.Windows.Forms.ComboBox();
            this.cboPortHMI = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDataMain = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStopMain = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboParityMain = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboBaudMain = new System.Windows.Forms.ComboBox();
            this.cboPortMain = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxMainTimer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxHMITimer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTestCount = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboDataHMI);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboStopHMI);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboParityHMI);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.cboBaudHMI);
            this.groupBox2.Controls.Add(this.cboPortHMI);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收模块设置";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Bits";
            // 
            // cboDataHMI
            // 
            this.cboDataHMI.FormattingEnabled = true;
            this.cboDataHMI.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboDataHMI.Location = new System.Drawing.Point(9, 180);
            this.cboDataHMI.Name = "cboDataHMI";
            this.cboDataHMI.Size = new System.Drawing.Size(76, 20);
            this.cboDataHMI.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stop Bits";
            // 
            // cboStopHMI
            // 
            this.cboStopHMI.FormattingEnabled = true;
            this.cboStopHMI.Location = new System.Drawing.Point(9, 143);
            this.cboStopHMI.Name = "cboStopHMI";
            this.cboStopHMI.Size = new System.Drawing.Size(76, 20);
            this.cboStopHMI.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Baud Rate";
            // 
            // cboParityHMI
            // 
            this.cboParityHMI.FormattingEnabled = true;
            this.cboParityHMI.Location = new System.Drawing.Point(9, 105);
            this.cboParityHMI.Name = "cboParityHMI";
            this.cboParityHMI.Size = new System.Drawing.Size(76, 20);
            this.cboParityHMI.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 12);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Port";
            // 
            // cboBaudHMI
            // 
            this.cboBaudHMI.FormattingEnabled = true;
            this.cboBaudHMI.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cboBaudHMI.Location = new System.Drawing.Point(9, 68);
            this.cboBaudHMI.Name = "cboBaudHMI";
            this.cboBaudHMI.Size = new System.Drawing.Size(76, 20);
            this.cboBaudHMI.TabIndex = 11;
            // 
            // cboPortHMI
            // 
            this.cboPortHMI.FormattingEnabled = true;
            this.cboPortHMI.Location = new System.Drawing.Point(9, 31);
            this.cboPortHMI.Name = "cboPortHMI";
            this.cboPortHMI.Size = new System.Drawing.Size(76, 20);
            this.cboPortHMI.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboDataMain);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboStopMain);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboParityMain);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboBaudMain);
            this.groupBox1.Controls.Add(this.cboPortMain);
            this.groupBox1.Location = new System.Drawing.Point(143, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 204);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发射模块设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data Bits";
            // 
            // cboDataMain
            // 
            this.cboDataMain.FormattingEnabled = true;
            this.cboDataMain.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboDataMain.Location = new System.Drawing.Point(9, 180);
            this.cboDataMain.Name = "cboDataMain";
            this.cboDataMain.Size = new System.Drawing.Size(76, 20);
            this.cboDataMain.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stop Bits";
            // 
            // cboStopMain
            // 
            this.cboStopMain.FormattingEnabled = true;
            this.cboStopMain.Location = new System.Drawing.Point(9, 143);
            this.cboStopMain.Name = "cboStopMain";
            this.cboStopMain.Size = new System.Drawing.Size(76, 20);
            this.cboStopMain.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Parity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Baud Rate";
            // 
            // cboParityMain
            // 
            this.cboParityMain.FormattingEnabled = true;
            this.cboParityMain.Location = new System.Drawing.Point(9, 105);
            this.cboParityMain.Name = "cboParityMain";
            this.cboParityMain.Size = new System.Drawing.Size(76, 20);
            this.cboParityMain.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Port";
            // 
            // cboBaudMain
            // 
            this.cboBaudMain.FormattingEnabled = true;
            this.cboBaudMain.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cboBaudMain.Location = new System.Drawing.Point(9, 68);
            this.cboBaudMain.Name = "cboBaudMain";
            this.cboBaudMain.Size = new System.Drawing.Size(76, 20);
            this.cboBaudMain.TabIndex = 11;
            // 
            // cboPortMain
            // 
            this.cboPortMain.FormattingEnabled = true;
            this.cboPortMain.Location = new System.Drawing.Point(9, 31);
            this.cboPortMain.Name = "cboPortMain";
            this.cboPortMain.Size = new System.Drawing.Size(76, 20);
            this.cboPortMain.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "确定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoText);
            this.groupBox4.Controls.Add(this.rdoHex);
            this.groupBox4.Location = new System.Drawing.Point(278, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 66);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "编码设置";
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Location = new System.Drawing.Point(6, 35);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(47, 16);
            this.rdoText.TabIndex = 1;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.Location = new System.Drawing.Point(6, 15);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(41, 16);
            this.rdoHex.TabIndex = 0;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "Hex";
            this.rdoHex.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxTestCount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbxMainTimer);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbxHMITimer);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(278, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 130);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "时延设置";
            // 
            // cbxMainTimer
            // 
            this.cbxMainTimer.FormattingEnabled = true;
            this.cbxMainTimer.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24"});
            this.cbxMainTimer.Location = new System.Drawing.Point(6, 70);
            this.cbxMainTimer.Name = "cbxMainTimer";
            this.cbxMainTimer.Size = new System.Drawing.Size(76, 20);
            this.cbxMainTimer.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "发送模块时延";
            // 
            // cbxHMITimer
            // 
            this.cbxHMITimer.FormattingEnabled = true;
            this.cbxHMITimer.Items.AddRange(new object[] {
            "100",
            "110",
            "120",
            "130",
            "140",
            "150",
            "160",
            "170",
            "180",
            "190",
            "200",
            "250",
            "300"});
            this.cbxHMITimer.Location = new System.Drawing.Point(6, 32);
            this.cbxHMITimer.Name = "cbxHMITimer";
            this.cbxHMITimer.Size = new System.Drawing.Size(76, 20);
            this.cbxHMITimer.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "接收模块时延";
            // 
            // cbxTestCount
            // 
            this.cbxTestCount.FormattingEnabled = true;
            this.cbxTestCount.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbxTestCount.Location = new System.Drawing.Point(5, 106);
            this.cbxTestCount.Name = "cbxTestCount";
            this.cbxTestCount.Size = new System.Drawing.Size(76, 20);
            this.cbxTestCount.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "测试次数";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(398, 278);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDataHMI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStopHMI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParityHMI;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboBaudHMI;
        private System.Windows.Forms.ComboBox cboPortHMI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDataMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStopMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboParityMain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboBaudMain;
        private System.Windows.Forms.ComboBox cboPortMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxMainTimer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxHMITimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTestCount;
        private System.Windows.Forms.Label label13;
    }
}