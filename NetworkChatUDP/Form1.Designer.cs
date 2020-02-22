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
            this.cmdKick = new System.Windows.Forms.Button();
            this.cmdMap = new System.Windows.Forms.Button();
            this.cmdReload = new System.Windows.Forms.Button();
            this.cmdSlap = new System.Windows.Forms.Button();
            this.cmdFriendlyFire = new System.Windows.Forms.Button();
            this.cmdTimelimit = new System.Windows.Forms.Button();
            this.cmdSwapteams = new System.Windows.Forms.Button();
            this.cmdWaverespawn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRconPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlayerTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtYourIP
            // 
            this.txtYourIP.Location = new System.Drawing.Point(85, 10);
            this.txtYourIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtYourIP.Name = "txtYourIP";
            this.txtYourIP.ReadOnly = true;
            this.txtYourIP.Size = new System.Drawing.Size(99, 20);
            this.txtYourIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your IP";
            // 
            // cmdStartListening
            // 
            this.cmdStartListening.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdStartListening.Location = new System.Drawing.Point(308, 42);
            this.cmdStartListening.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdStartListening.Name = "cmdStartListening";
            this.cmdStartListening.Size = new System.Drawing.Size(86, 27);
            this.cmdStartListening.TabIndex = 2;
            this.cmdStartListening.Text = "Start Listening";
            this.cmdStartListening.UseVisualStyleBackColor = true;
            this.cmdStartListening.Click += new System.EventHandler(this.cmdStartListening_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listening Port";
            // 
            // txtListeningPort
            // 
            this.txtListeningPort.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtListeningPort.Location = new System.Drawing.Point(85, 43);
            this.txtListeningPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtListeningPort.Name = "txtListeningPort";
            this.txtListeningPort.Size = new System.Drawing.Size(99, 20);
            this.txtListeningPort.TabIndex = 1;
            this.txtListeningPort.Text = "7070";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Server IP";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(63, 391);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(99, 20);
            this.txtServerIP.TabIndex = 5;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // cmdSendOnly
            // 
            this.cmdSendOnly.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdSendOnly.Location = new System.Drawing.Point(309, 608);
            this.cmdSendOnly.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdSendOnly.Name = "cmdSendOnly";
            this.cmdSendOnly.Size = new System.Drawing.Size(65, 38);
            this.cmdSendOnly.TabIndex = 8;
            this.cmdSendOnly.Text = "Send Only";
            this.cmdSendOnly.UseVisualStyleBackColor = true;
            this.cmdSendOnly.Click += new System.EventHandler(this.cmdSendOnly_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(63, 426);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(435, 20);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Svr Port";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(216, 391);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(48, 20);
            this.txtServerPort.TabIndex = 6;
            this.txtServerPort.Text = "7070";
            // 
            // cmdStopListening
            // 
            this.cmdStopListening.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdStopListening.Location = new System.Drawing.Point(407, 42);
            this.cmdStopListening.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdStopListening.Name = "cmdStopListening";
            this.cmdStopListening.Size = new System.Drawing.Size(86, 27);
            this.cmdStopListening.TabIndex = 3;
            this.cmdStopListening.Text = "Stop Listening";
            this.cmdStopListening.UseVisualStyleBackColor = true;
            this.cmdStopListening.Click += new System.EventHandler(this.cmdStopListening_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(324, 562);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Send message ~ or EXIT to stop the listener.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 562);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Graves (`) get replaced with 0xFF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stop Listening only works after receiving a message";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(11, 81);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(556, 300);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.WordWrap = false;
            // 
            // cmdClear
            // 
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClear.Location = new System.Drawing.Point(525, 42);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(43, 27);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdFillUrT
            // 
            this.cmdFillUrT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdFillUrT.Location = new System.Drawing.Point(12, 578);
            this.cmdFillUrT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdFillUrT.Name = "cmdFillUrT";
            this.cmdFillUrT.Size = new System.Drawing.Size(55, 25);
            this.cmdFillUrT.TabIndex = 23;
            this.cmdFillUrT.Text = "Fill UrT";
            this.cmdFillUrT.UseVisualStyleBackColor = true;
            this.cmdFillUrT.Click += new System.EventHandler(this.cmdFillUrT_Click);
            // 
            // cmdFillSG15Plyr
            // 
            this.cmdFillSG15Plyr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdFillSG15Plyr.Location = new System.Drawing.Point(81, 578);
            this.cmdFillSG15Plyr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdFillSG15Plyr.Name = "cmdFillSG15Plyr";
            this.cmdFillSG15Plyr.Size = new System.Drawing.Size(86, 25);
            this.cmdFillSG15Plyr.TabIndex = 24;
            this.cmdFillSG15Plyr.Text = "Fill SG 15 Plyr";
            this.cmdFillSG15Plyr.UseVisualStyleBackColor = true;
            this.cmdFillSG15Plyr.Click += new System.EventHandler(this.cmdFillSG15Plyr_Click);
            // 
            // cmdFillSG16Plyr
            // 
            this.cmdFillSG16Plyr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdFillSG16Plyr.Location = new System.Drawing.Point(181, 578);
            this.cmdFillSG16Plyr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdFillSG16Plyr.Name = "cmdFillSG16Plyr";
            this.cmdFillSG16Plyr.Size = new System.Drawing.Size(85, 25);
            this.cmdFillSG16Plyr.TabIndex = 25;
            this.cmdFillSG16Plyr.Text = "Fill SG 16 Plyr";
            this.cmdFillSG16Plyr.UseVisualStyleBackColor = true;
            this.cmdFillSG16Plyr.Click += new System.EventHandler(this.cmdFillSG16Plyr_Click);
            // 
            // cmdSG16Info
            // 
            this.cmdSG16Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdSG16Info.Location = new System.Drawing.Point(380, 578);
            this.cmdSG16Info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdSG16Info.Name = "cmdSG16Info";
            this.cmdSG16Info.Size = new System.Drawing.Size(85, 25);
            this.cmdSG16Info.TabIndex = 27;
            this.cmdSG16Info.Text = "Fill SG 16 Info";
            this.cmdSG16Info.UseVisualStyleBackColor = true;
            this.cmdSG16Info.Click += new System.EventHandler(this.cmdSG16Info_Click);
            // 
            // cmdSG15Info
            // 
            this.cmdSG15Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdSG15Info.Location = new System.Drawing.Point(281, 578);
            this.cmdSG15Info.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdSG15Info.Name = "cmdSG15Info";
            this.cmdSG15Info.Size = new System.Drawing.Size(86, 25);
            this.cmdSG15Info.TabIndex = 26;
            this.cmdSG15Info.Text = "Fill SG 15 Info";
            this.cmdSG15Info.UseVisualStyleBackColor = true;
            this.cmdSG15Info.Click += new System.EventHandler(this.cmdSG15Info_Click);
            // 
            // cmdUE4HS
            // 
            this.cmdUE4HS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdUE4HS.Location = new System.Drawing.Point(11, 621);
            this.cmdUE4HS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdUE4HS.Name = "cmdUE4HS";
            this.cmdUE4HS.Size = new System.Drawing.Size(69, 25);
            this.cmdUE4HS.TabIndex = 31;
            this.cmdUE4HS.Text = "Fill UE4 HS";
            this.cmdUE4HS.UseVisualStyleBackColor = true;
            this.cmdUE4HS.Click += new System.EventHandler(this.cmdUE4HS_Click);
            // 
            // cbxEnteredHex
            // 
            this.cbxEnteredHex.AutoSize = true;
            this.cbxEnteredHex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxEnteredHex.Location = new System.Drawing.Point(483, 583);
            this.cbxEnteredHex.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxEnteredHex.Name = "cbxEnteredHex";
            this.cbxEnteredHex.Size = new System.Drawing.Size(85, 17);
            this.cbxEnteredHex.TabIndex = 32;
            this.cbxEnteredHex.Text = "Entered Hex";
            this.cbxEnteredHex.UseVisualStyleBackColor = true;
            // 
            // cmdUE4c
            // 
            this.cmdUE4c.Location = new System.Drawing.Point(100, 621);
            this.cmdUE4c.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdUE4c.Name = "cmdUE4c";
            this.cmdUE4c.Size = new System.Drawing.Size(61, 25);
            this.cmdUE4c.TabIndex = 34;
            this.cmdUE4c.Text = "Fill UE4 C";
            this.cmdUE4c.UseVisualStyleBackColor = true;
            this.cmdUE4c.Click += new System.EventHandler(this.cmdUE4c_Click);
            // 
            // cmdSendWait
            // 
            this.cmdSendWait.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdSendWait.Location = new System.Drawing.Point(501, 608);
            this.cmdSendWait.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdSendWait.Name = "cmdSendWait";
            this.cmdSendWait.Size = new System.Drawing.Size(65, 38);
            this.cmdSendWait.TabIndex = 35;
            this.cmdSendWait.Text = "Send && Wait";
            this.cmdSendWait.UseVisualStyleBackColor = true;
            this.cmdSendWait.Click += new System.EventHandler(this.cmdSendWait_Click);
            // 
            // cmdSendWaitUE
            // 
            this.cmdSendWaitUE.Location = new System.Drawing.Point(501, 417);
            this.cmdSendWaitUE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmdSendWaitUE.Name = "cmdSendWaitUE";
            this.cmdSendWaitUE.Size = new System.Drawing.Size(65, 34);
            this.cmdSendWaitUE.TabIndex = 36;
            this.cmdSendWaitUE.Text = "Send && Wait UE";
            this.cmdSendWaitUE.UseVisualStyleBackColor = true;
            this.cmdSendWaitUE.Click += new System.EventHandler(this.cmdSendWaitUE_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(433, 608);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "For anything";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(429, 627);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "other than UE";
            // 
            // cmdKick
            // 
            this.cmdKick.Location = new System.Drawing.Point(12, 456);
            this.cmdKick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdKick.Name = "cmdKick";
            this.cmdKick.Size = new System.Drawing.Size(82, 31);
            this.cmdKick.TabIndex = 39;
            this.cmdKick.Text = "kick";
            this.cmdKick.UseVisualStyleBackColor = true;
            this.cmdKick.Click += new System.EventHandler(this.cmdKick_Click);
            // 
            // cmdMap
            // 
            this.cmdMap.Location = new System.Drawing.Point(107, 456);
            this.cmdMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdMap.Name = "cmdMap";
            this.cmdMap.Size = new System.Drawing.Size(82, 31);
            this.cmdMap.TabIndex = 40;
            this.cmdMap.Text = "map turnpike";
            this.cmdMap.UseVisualStyleBackColor = true;
            this.cmdMap.Click += new System.EventHandler(this.cmdMap_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Location = new System.Drawing.Point(199, 456);
            this.cmdReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(82, 31);
            this.cmdReload.TabIndex = 41;
            this.cmdReload.Text = "reload";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // cmdSlap
            // 
            this.cmdSlap.Location = new System.Drawing.Point(295, 456);
            this.cmdSlap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSlap.Name = "cmdSlap";
            this.cmdSlap.Size = new System.Drawing.Size(82, 31);
            this.cmdSlap.TabIndex = 42;
            this.cmdSlap.Text = "slap";
            this.cmdSlap.UseVisualStyleBackColor = true;
            this.cmdSlap.Click += new System.EventHandler(this.cmdSlap_Click);
            // 
            // cmdFriendlyFire
            // 
            this.cmdFriendlyFire.Location = new System.Drawing.Point(390, 456);
            this.cmdFriendlyFire.Margin = new System.Windows.Forms.Padding(2);
            this.cmdFriendlyFire.Name = "cmdFriendlyFire";
            this.cmdFriendlyFire.Size = new System.Drawing.Size(82, 31);
            this.cmdFriendlyFire.TabIndex = 43;
            this.cmdFriendlyFire.Text = "friendlyfire";
            this.cmdFriendlyFire.UseVisualStyleBackColor = true;
            this.cmdFriendlyFire.Click += new System.EventHandler(this.cmdFriendlyFire_Click);
            // 
            // cmdTimelimit
            // 
            this.cmdTimelimit.Location = new System.Drawing.Point(483, 456);
            this.cmdTimelimit.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTimelimit.Name = "cmdTimelimit";
            this.cmdTimelimit.Size = new System.Drawing.Size(82, 31);
            this.cmdTimelimit.TabIndex = 44;
            this.cmdTimelimit.Text = "timelimit";
            this.cmdTimelimit.UseVisualStyleBackColor = true;
            this.cmdTimelimit.Click += new System.EventHandler(this.cmdTimelimit_Click);
            // 
            // cmdSwapteams
            // 
            this.cmdSwapteams.Location = new System.Drawing.Point(13, 495);
            this.cmdSwapteams.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSwapteams.Name = "cmdSwapteams";
            this.cmdSwapteams.Size = new System.Drawing.Size(82, 31);
            this.cmdSwapteams.TabIndex = 45;
            this.cmdSwapteams.Text = "swapteams";
            this.cmdSwapteams.UseVisualStyleBackColor = true;
            this.cmdSwapteams.Click += new System.EventHandler(this.cmdSwapteams_Click);
            // 
            // cmdWaverespawn
            // 
            this.cmdWaverespawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWaverespawn.Location = new System.Drawing.Point(107, 497);
            this.cmdWaverespawn.Margin = new System.Windows.Forms.Padding(2);
            this.cmdWaverespawn.Name = "cmdWaverespawn";
            this.cmdWaverespawn.Size = new System.Drawing.Size(82, 31);
            this.cmdWaverespawn.TabIndex = 46;
            this.cmdWaverespawn.Text = "waverespawn";
            this.cmdWaverespawn.UseVisualStyleBackColor = true;
            this.cmdWaverespawn.Click += new System.EventHandler(this.cmdWaverespawn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 394);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "RconPass";
            // 
            // txtRconPassword
            // 
            this.txtRconPassword.Location = new System.Drawing.Point(331, 391);
            this.txtRconPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.PasswordChar = '*';
            this.txtRconPassword.Size = new System.Drawing.Size(71, 20);
            this.txtRconPassword.TabIndex = 47;
            this.txtRconPassword.Text = "testpass";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(406, 394);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Player Target";
            // 
            // txtPlayerTarget
            // 
            this.txtPlayerTarget.Location = new System.Drawing.Point(480, 391);
            this.txtPlayerTarget.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPlayerTarget.Name = "txtPlayerTarget";
            this.txtPlayerTarget.Size = new System.Drawing.Size(88, 20);
            this.txtPlayerTarget.TabIndex = 50;
            this.txtPlayerTarget.Text = "dkryzen";
            // 
            // NetworkChatUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 657);
            this.Controls.Add(this.txtPlayerTarget);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRconPassword);
            this.Controls.Add(this.cmdWaverespawn);
            this.Controls.Add(this.cmdSwapteams);
            this.Controls.Add(this.cmdTimelimit);
            this.Controls.Add(this.cmdFriendlyFire);
            this.Controls.Add(this.cmdSlap);
            this.Controls.Add(this.cmdReload);
            this.Controls.Add(this.cmdMap);
            this.Controls.Add(this.cmdKick);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.Button cmdKick;
        private System.Windows.Forms.Button cmdMap;
        private System.Windows.Forms.Button cmdReload;
        private System.Windows.Forms.Button cmdSlap;
        private System.Windows.Forms.Button cmdFriendlyFire;
        private System.Windows.Forms.Button cmdTimelimit;
        private System.Windows.Forms.Button cmdSwapteams;
        private System.Windows.Forms.Button cmdWaverespawn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRconPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlayerTarget;
    }
}

