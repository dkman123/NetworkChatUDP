namespace NetworkChatUDP
{
    partial class NetworkChatUDP
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
            this.txtYourIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStartListening = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListeningPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.cmdSendOnly = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.cmdStopListening = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdFillUrT = new System.Windows.Forms.Button();
            this.cmdFillSG15Plyr = new System.Windows.Forms.Button();
            this.cmdFillSG16Plyr = new System.Windows.Forms.Button();
            this.cmdSG16Info = new System.Windows.Forms.Button();
            this.cmdSG15Info = new System.Windows.Forms.Button();
            this.cmdUE4HS = new System.Windows.Forms.Button();
            this.cbxEnteredHex = new System.Windows.Forms.CheckBox();
            this.cmdUE4c = new System.Windows.Forms.Button();
            this.cmdSendWait = new System.Windows.Forms.Button();
            this.cmdSendWaitUE = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYourIP
            // 
            this.txtYourIP.Location = new System.Drawing.Point(127, 15);
            this.txtYourIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYourIP.Name = "txtYourIP";
            this.txtYourIP.ReadOnly = true;
            this.txtYourIP.Size = new System.Drawing.Size(147, 26);
            this.txtYourIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your IP";
            // 
            // cmdStartListening
            // 
            this.cmdStartListening.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdStartListening.Location = new System.Drawing.Point(462, 64);
            this.cmdStartListening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdStartListening.Name = "cmdStartListening";
            this.cmdStartListening.Size = new System.Drawing.Size(129, 42);
            this.cmdStartListening.TabIndex = 2;
            this.cmdStartListening.Text = "Start Listening";
            this.cmdStartListening.UseVisualStyleBackColor = true;
            this.cmdStartListening.Click += new System.EventHandler(this.cmdStartListening_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listening Port";
            // 
            // txtListeningPort
            // 
            this.txtListeningPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtListeningPort.Location = new System.Drawing.Point(127, 66);
            this.txtListeningPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtListeningPort.Name = "txtListeningPort";
            this.txtListeningPort.Size = new System.Drawing.Size(147, 26);
            this.txtListeningPort.TabIndex = 1;
            this.txtListeningPort.Text = "7070";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server IP";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(94, 602);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(147, 26);
            this.txtServerIP.TabIndex = 5;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // cmdSendOnly
            // 
            this.cmdSendOnly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSendOnly.Location = new System.Drawing.Point(463, 811);
            this.cmdSendOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSendOnly.Name = "cmdSendOnly";
            this.cmdSendOnly.Size = new System.Drawing.Size(98, 58);
            this.cmdSendOnly.TabIndex = 8;
            this.cmdSendOnly.Text = "Send Only";
            this.cmdSendOnly.UseVisualStyleBackColor = true;
            this.cmdSendOnly.Click += new System.EventHandler(this.cmdSendOnly_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(94, 655);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(650, 26);
            this.txtMessage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Server Port";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(358, 602);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(84, 26);
            this.txtServerPort.TabIndex = 6;
            this.txtServerPort.Text = "7070";
            // 
            // cmdStopListening
            // 
            this.cmdStopListening.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdStopListening.Location = new System.Drawing.Point(611, 64);
            this.cmdStopListening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdStopListening.Name = "cmdStopListening";
            this.cmdStopListening.Size = new System.Drawing.Size(129, 42);
            this.cmdStopListening.TabIndex = 3;
            this.cmdStopListening.Text = "Stop Listening";
            this.cmdStopListening.UseVisualStyleBackColor = true;
            this.cmdStopListening.Click += new System.EventHandler(this.cmdStopListening_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(459, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Send message ~ or EXIT to stop the listener.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(459, 624);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Graves (`) get replaced with 0xFF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stop Listening only works after receiving a message";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(17, 124);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(832, 459);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.WordWrap = false;
            // 
            // cmdClear
            // 
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClear.Location = new System.Drawing.Point(788, 64);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(64, 42);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdFillUrT
            // 
            this.cmdFillUrT.Location = new System.Drawing.Point(12, 732);
            this.cmdFillUrT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdFillUrT.Name = "cmdFillUrT";
            this.cmdFillUrT.Size = new System.Drawing.Size(82, 39);
            this.cmdFillUrT.TabIndex = 23;
            this.cmdFillUrT.Text = "Fill UrT";
            this.cmdFillUrT.UseVisualStyleBackColor = true;
            this.cmdFillUrT.Click += new System.EventHandler(this.cmdFillUrT_Click);
            // 
            // cmdFillSG15Plyr
            // 
            this.cmdFillSG15Plyr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFillSG15Plyr.Location = new System.Drawing.Point(122, 732);
            this.cmdFillSG15Plyr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdFillSG15Plyr.Name = "cmdFillSG15Plyr";
            this.cmdFillSG15Plyr.Size = new System.Drawing.Size(129, 39);
            this.cmdFillSG15Plyr.TabIndex = 24;
            this.cmdFillSG15Plyr.Text = "Fill SG 15 Plyr";
            this.cmdFillSG15Plyr.UseVisualStyleBackColor = true;
            this.cmdFillSG15Plyr.Click += new System.EventHandler(this.cmdFillSG15Plyr_Click);
            // 
            // cmdFillSG16Plyr
            // 
            this.cmdFillSG16Plyr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFillSG16Plyr.Location = new System.Drawing.Point(271, 732);
            this.cmdFillSG16Plyr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdFillSG16Plyr.Name = "cmdFillSG16Plyr";
            this.cmdFillSG16Plyr.Size = new System.Drawing.Size(128, 39);
            this.cmdFillSG16Plyr.TabIndex = 25;
            this.cmdFillSG16Plyr.Text = "Fill SG 16 Plyr";
            this.cmdFillSG16Plyr.UseVisualStyleBackColor = true;
            this.cmdFillSG16Plyr.Click += new System.EventHandler(this.cmdFillSG16Plyr_Click);
            // 
            // cmdSG16Info
            // 
            this.cmdSG16Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSG16Info.Location = new System.Drawing.Point(570, 732);
            this.cmdSG16Info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSG16Info.Name = "cmdSG16Info";
            this.cmdSG16Info.Size = new System.Drawing.Size(128, 39);
            this.cmdSG16Info.TabIndex = 27;
            this.cmdSG16Info.Text = "Fill SG 16 Info";
            this.cmdSG16Info.UseVisualStyleBackColor = true;
            this.cmdSG16Info.Click += new System.EventHandler(this.cmdSG16Info_Click);
            // 
            // cmdSG15Info
            // 
            this.cmdSG15Info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSG15Info.Location = new System.Drawing.Point(421, 732);
            this.cmdSG15Info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSG15Info.Name = "cmdSG15Info";
            this.cmdSG15Info.Size = new System.Drawing.Size(129, 39);
            this.cmdSG15Info.TabIndex = 26;
            this.cmdSG15Info.Text = "Fill SG 15 Info";
            this.cmdSG15Info.UseVisualStyleBackColor = true;
            this.cmdSG15Info.Click += new System.EventHandler(this.cmdSG15Info_Click);
            // 
            // cmdUE4HS
            // 
            this.cmdUE4HS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUE4HS.Location = new System.Drawing.Point(17, 830);
            this.cmdUE4HS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdUE4HS.Name = "cmdUE4HS";
            this.cmdUE4HS.Size = new System.Drawing.Size(104, 39);
            this.cmdUE4HS.TabIndex = 31;
            this.cmdUE4HS.Text = "Fill UE4 HS";
            this.cmdUE4HS.UseVisualStyleBackColor = true;
            this.cmdUE4HS.Click += new System.EventHandler(this.cmdUE4HS_Click);
            // 
            // cbxEnteredHex
            // 
            this.cbxEnteredHex.AutoSize = true;
            this.cbxEnteredHex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxEnteredHex.Location = new System.Drawing.Point(725, 740);
            this.cbxEnteredHex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxEnteredHex.Name = "cbxEnteredHex";
            this.cbxEnteredHex.Size = new System.Drawing.Size(124, 24);
            this.cbxEnteredHex.TabIndex = 32;
            this.cbxEnteredHex.Text = "Entered Hex";
            this.cbxEnteredHex.UseVisualStyleBackColor = true;
            // 
            // cmdUE4c
            // 
            this.cmdUE4c.Location = new System.Drawing.Point(149, 830);
            this.cmdUE4c.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdUE4c.Name = "cmdUE4c";
            this.cmdUE4c.Size = new System.Drawing.Size(92, 39);
            this.cmdUE4c.TabIndex = 34;
            this.cmdUE4c.Text = "Fill UE4 C";
            this.cmdUE4c.UseVisualStyleBackColor = true;
            this.cmdUE4c.Click += new System.EventHandler(this.cmdUE4c_Click);
            // 
            // cmdSendWait
            // 
            this.cmdSendWait.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdSendWait.Location = new System.Drawing.Point(751, 811);
            this.cmdSendWait.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSendWait.Name = "cmdSendWait";
            this.cmdSendWait.Size = new System.Drawing.Size(98, 58);
            this.cmdSendWait.TabIndex = 35;
            this.cmdSendWait.Text = "Send && Wait";
            this.cmdSendWait.UseVisualStyleBackColor = true;
            this.cmdSendWait.Click += new System.EventHandler(this.cmdSendWait_Click);
            // 
            // cmdSendWaitUE
            // 
            this.cmdSendWaitUE.Location = new System.Drawing.Point(751, 642);
            this.cmdSendWaitUE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSendWaitUE.Name = "cmdSendWaitUE";
            this.cmdSendWaitUE.Size = new System.Drawing.Size(98, 52);
            this.cmdSendWaitUE.TabIndex = 36;
            this.cmdSendWaitUE.Text = "Send && Wait UE";
            this.cmdSendWaitUE.UseVisualStyleBackColor = true;
            this.cmdSendWaitUE.Click += new System.EventHandler(this.cmdSendWaitUE_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 811);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "For anything";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 839);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "other than UE";
            // 
            // NetworkChatUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 890);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmdSendWaitUE);
            this.Controls.Add(this.cmdSendWait);
            this.Controls.Add(this.cmdUE4c);
            this.Controls.Add(this.cbxEnteredHex);
            this.Controls.Add(this.cmdUE4HS);
            this.Controls.Add(this.cmdSG16Info);
            this.Controls.Add(this.cmdSG15Info);
            this.Controls.Add(this.cmdFillSG16Plyr);
            this.Controls.Add(this.cmdFillSG15Plyr);
            this.Controls.Add(this.cmdFillUrT);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdStopListening);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cmdSendOnly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtListeningPort);
            this.Controls.Add(this.cmdStartListening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYourIP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NetworkChatUDP";
            this.Text = "NetworkChatUDP";
            this.Load += new System.EventHandler(this.NetworkChatUDP_Load);
            this.Resize += new System.EventHandler(this.NetworkChatUDP_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYourIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStartListening;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListeningPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button cmdSendOnly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Button cmdStopListening;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdFillUrT;
        private System.Windows.Forms.Button cmdFillSG15Plyr;
        private System.Windows.Forms.Button cmdFillSG16Plyr;
        private System.Windows.Forms.Button cmdSG16Info;
        private System.Windows.Forms.Button cmdSG15Info;
        private System.Windows.Forms.Button cmdUE4HS;
        private System.Windows.Forms.CheckBox cbxEnteredHex;
        private System.Windows.Forms.Button cmdUE4c;
        private System.Windows.Forms.Button cmdSendWait;
        private System.Windows.Forms.Button cmdSendWaitUE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

