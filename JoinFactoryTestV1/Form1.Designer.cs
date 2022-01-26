
namespace JoinFactoryTestV1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rButSerial = new System.Windows.Forms.RadioButton();
            this.rButTCPIP = new System.Windows.Forms.RadioButton();
            this.gBoxTCPIP = new System.Windows.Forms.GroupBox();
            this.tBoxServerAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxSerial = new System.Windows.Forms.GroupBox();
            this.cBoxDeviceComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxServerStatus = new System.Windows.Forms.TextBox();
            this.lServerStatus = new System.Windows.Forms.Label();
            this.btnStartFactoryTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRelayCondition = new System.Windows.Forms.Button();
            this.btnRelay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnACVoltageCondition = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGroundCondition = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gBoxTCPIP.SuspendLayout();
            this.gBoxSerial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // rButSerial
            // 
            this.rButSerial.AutoSize = true;
            this.rButSerial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rButSerial.Location = new System.Drawing.Point(12, 12);
            this.rButSerial.Name = "rButSerial";
            this.rButSerial.Size = new System.Drawing.Size(142, 32);
            this.rButSerial.TabIndex = 0;
            this.rButSerial.TabStop = true;
            this.rButSerial.Text = "Seri Bağlantı";
            this.rButSerial.UseVisualStyleBackColor = true;
            this.rButSerial.CheckedChanged += new System.EventHandler(this.rButSerial_CheckedChanged);
            // 
            // rButTCPIP
            // 
            this.rButTCPIP.AutoSize = true;
            this.rButTCPIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rButTCPIP.Location = new System.Drawing.Point(170, 12);
            this.rButTCPIP.Name = "rButTCPIP";
            this.rButTCPIP.Size = new System.Drawing.Size(165, 32);
            this.rButTCPIP.TabIndex = 1;
            this.rButTCPIP.TabStop = true;
            this.rButTCPIP.Text = "TCP/IP Bağlantı";
            this.rButTCPIP.UseVisualStyleBackColor = true;
            this.rButTCPIP.CheckedChanged += new System.EventHandler(this.rButTCPIP_CheckedChanged);
            // 
            // gBoxTCPIP
            // 
            this.gBoxTCPIP.Controls.Add(this.tBoxServerAddr);
            this.gBoxTCPIP.Controls.Add(this.label1);
            this.gBoxTCPIP.Location = new System.Drawing.Point(24, 44);
            this.gBoxTCPIP.Name = "gBoxTCPIP";
            this.gBoxTCPIP.Size = new System.Drawing.Size(266, 108);
            this.gBoxTCPIP.TabIndex = 2;
            this.gBoxTCPIP.TabStop = false;
            this.gBoxTCPIP.Text = "TCP/IP Client";
            // 
            // tBoxServerAddr
            // 
            this.tBoxServerAddr.Location = new System.Drawing.Point(95, 43);
            this.tBoxServerAddr.Name = "tBoxServerAddr";
            this.tBoxServerAddr.Size = new System.Drawing.Size(165, 27);
            this.tBoxServerAddr.TabIndex = 3;
            this.tBoxServerAddr.Text = "192.168.2.58:1248";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            // 
            // gBoxSerial
            // 
            this.gBoxSerial.Controls.Add(this.cBoxDeviceComPort);
            this.gBoxSerial.Controls.Add(this.label2);
            this.gBoxSerial.Location = new System.Drawing.Point(18, 50);
            this.gBoxSerial.Name = "gBoxSerial";
            this.gBoxSerial.Size = new System.Drawing.Size(292, 108);
            this.gBoxSerial.TabIndex = 3;
            this.gBoxSerial.TabStop = false;
            this.gBoxSerial.Text = "Seri Bağlantı";
            // 
            // cBoxDeviceComPort
            // 
            this.cBoxDeviceComPort.FormattingEnabled = true;
            this.cBoxDeviceComPort.Location = new System.Drawing.Point(158, 54);
            this.cBoxDeviceComPort.Name = "cBoxDeviceComPort";
            this.cBoxDeviceComPort.Size = new System.Drawing.Size(128, 28);
            this.cBoxDeviceComPort.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cihaz Seri Giriş";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 29);
            this.progressBar1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(6, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 58);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "KAPAT";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpen.Location = new System.Drawing.Point(6, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 58);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "AÇ";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxServerStatus);
            this.groupBox2.Controls.Add(this.lServerStatus);
            this.groupBox2.Location = new System.Drawing.Point(170, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Durumu";
            // 
            // tBoxServerStatus
            // 
            this.tBoxServerStatus.Location = new System.Drawing.Point(3, 102);
            this.tBoxServerStatus.Multiline = true;
            this.tBoxServerStatus.Name = "tBoxServerStatus";
            this.tBoxServerStatus.Size = new System.Drawing.Size(125, 69);
            this.tBoxServerStatus.TabIndex = 11;
            // 
            // lServerStatus
            // 
            this.lServerStatus.AutoSize = true;
            this.lServerStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lServerStatus.Location = new System.Drawing.Point(6, 46);
            this.lServerStatus.Name = "lServerStatus";
            this.lServerStatus.Size = new System.Drawing.Size(103, 38);
            this.lServerStatus.TabIndex = 6;
            this.lServerStatus.Text = "KAPALI";
            // 
            // btnStartFactoryTest
            // 
            this.btnStartFactoryTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartFactoryTest.Location = new System.Drawing.Point(32, 406);
            this.btnStartFactoryTest.Name = "btnStartFactoryTest";
            this.btnStartFactoryTest.Size = new System.Drawing.Size(246, 58);
            this.btnStartFactoryTest.TabIndex = 6;
            this.btnStartFactoryTest.Text = "Fabrika Testini Başlat";
            this.btnStartFactoryTest.UseVisualStyleBackColor = true;
            this.btnStartFactoryTest.Click += new System.EventHandler(this.btnStartFactoryTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(341, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "CİHAZ 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRelayCondition);
            this.groupBox3.Controls.Add(this.btnRelay);
            this.groupBox3.Location = new System.Drawing.Point(450, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Röle Modu";
            // 
            // btnRelayCondition
            // 
            this.btnRelayCondition.BackColor = System.Drawing.SystemColors.Window;
            this.btnRelayCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRelayCondition.Location = new System.Drawing.Point(146, 26);
            this.btnRelayCondition.Name = "btnRelayCondition";
            this.btnRelayCondition.Size = new System.Drawing.Size(82, 58);
            this.btnRelayCondition.TabIndex = 7;
            this.btnRelayCondition.UseVisualStyleBackColor = false;
            // 
            // btnRelay
            // 
            this.btnRelay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRelay.Location = new System.Drawing.Point(6, 26);
            this.btnRelay.Name = "btnRelay";
            this.btnRelay.Size = new System.Drawing.Size(134, 58);
            this.btnRelay.TabIndex = 6;
            this.btnRelay.Text = "RÖLE AÇ";
            this.btnRelay.UseVisualStyleBackColor = true;
            this.btnRelay.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnACVoltageCondition);
            this.groupBox4.Location = new System.Drawing.Point(690, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AC Voltaj";
            // 
            // btnACVoltageCondition
            // 
            this.btnACVoltageCondition.BackColor = System.Drawing.SystemColors.Window;
            this.btnACVoltageCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnACVoltageCondition.Location = new System.Drawing.Point(6, 26);
            this.btnACVoltageCondition.Name = "btnACVoltageCondition";
            this.btnACVoltageCondition.Size = new System.Drawing.Size(83, 58);
            this.btnACVoltageCondition.TabIndex = 7;
            this.btnACVoltageCondition.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGroundCondition);
            this.groupBox5.Location = new System.Drawing.Point(802, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 100);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Topraklama";
            // 
            // btnGroundCondition
            // 
            this.btnGroundCondition.BackColor = System.Drawing.SystemColors.Window;
            this.btnGroundCondition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGroundCondition.Location = new System.Drawing.Point(18, 26);
            this.btnGroundCondition.Name = "btnGroundCondition";
            this.btnGroundCondition.Size = new System.Drawing.Size(83, 58);
            this.btnGroundCondition.TabIndex = 7;
            this.btnGroundCondition.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(371, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(276, 98);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 476);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gBoxTCPIP);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartFactoryTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBoxSerial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rButTCPIP);
            this.Controls.Add(this.rButSerial);
            this.Name = "Form1";
            this.Text = "Join Factory Test";
            this.gBoxTCPIP.ResumeLayout(false);
            this.gBoxTCPIP.PerformLayout();
            this.gBoxSerial.ResumeLayout(false);
            this.gBoxSerial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rButSerial;
        private System.Windows.Forms.RadioButton rButTCPIP;
        private System.Windows.Forms.GroupBox gBoxTCPIP;
        private System.Windows.Forms.TextBox tBoxServerAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxSerial;
        private System.Windows.Forms.ComboBox cBoxDeviceComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lServerStatus;
        private System.Windows.Forms.Button btnStartFactoryTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRelayCondition;
        private System.Windows.Forms.Button btnRelay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnACVoltageCondition;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGroundCondition;
        private System.Windows.Forms.TextBox tBoxServerStatus;
        private System.Windows.Forms.TextBox textBox1;
    }
}

