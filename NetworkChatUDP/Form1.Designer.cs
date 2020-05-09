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
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdFillUrT = new System.Windows.Forms.Button();
            this.cmdSendWaitUE = new System.Windows.Forms.Button();
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
            this.cmdGravity = new System.Windows.Forms.Button();
            this.cmdNuke = new System.Windows.Forms.Button();
            this.cmdSuddenDeath = new System.Windows.Forms.Button();
            this.cmdGetStatus = new System.Windows.Forms.Button();
            this.cmdMute = new System.Windows.Forms.Button();
            this.cmdBan = new System.Windows.Forms.Button();
            this.cmdTempban = new System.Windows.Forms.Button();
            this.cmdUnban = new System.Windows.Forms.Button();
            this.cmdSmite = new System.Windows.Forms.Button();
            this.cbxEnteredHex = new System.Windows.Forms.CheckBox();
            this.cmdStopListening = new System.Windows.Forms.Button();
            this.cmdStartListening = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListeningPort = new System.Windows.Forms.TextBox();
            this.cmdPlayerList = new System.Windows.Forms.Button();
            this.cmdSendWait = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.cmdTCPSendUE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtYourIP
            // 
            this.txtYourIP.Location = new System.Drawing.Point(128, 15);
            this.txtYourIP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtYourIP.Name = "txtYourIP";
            this.txtYourIP.ReadOnly = true;
            this.txtYourIP.Size = new System.Drawing.Size(146, 26);
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
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(146, 26);
            this.txtServerIP.TabIndex = 5;
            this.txtServerIP.Text = "127.0.0.1";
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
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(548, 26);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Svr Port";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(324, 602);
            this.txtServerPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(70, 26);
            this.txtServerPort.TabIndex = 6;
            this.txtServerPort.Text = "7070";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 938);
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
            this.txtOutput.Location = new System.Drawing.Point(16, 68);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(832, 516);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.WordWrap = false;
            // 
            // cmdClear
            // 
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdClear.Location = new System.Drawing.Point(786, 15);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(64, 42);
            this.cmdClear.TabIndex = 4;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdFillUrT
            // 
            this.cmdFillUrT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdFillUrT.Location = new System.Drawing.Point(20, 938);
            this.cmdFillUrT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdFillUrT.Name = "cmdFillUrT";
            this.cmdFillUrT.Size = new System.Drawing.Size(120, 54);
            this.cmdFillUrT.TabIndex = 23;
            this.cmdFillUrT.Text = "Fill UrT";
            this.cmdFillUrT.UseVisualStyleBackColor = true;
            this.cmdFillUrT.Click += new System.EventHandler(this.cmdFillUrT_Click);
            // 
            // cmdSendWaitUE
            // 
            this.cmdSendWaitUE.Location = new System.Drawing.Point(752, 642);
            this.cmdSendWaitUE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdSendWaitUE.Name = "cmdSendWaitUE";
            this.cmdSendWaitUE.Size = new System.Drawing.Size(98, 52);
            this.cmdSendWaitUE.TabIndex = 36;
            this.cmdSendWaitUE.Text = "UDP Send && Wait UE";
            this.cmdSendWaitUE.UseVisualStyleBackColor = true;
            this.cmdSendWaitUE.Click += new System.EventHandler(this.cmdSendWaitUE_Click);
            // 
            // cmdKick
            // 
            this.cmdKick.Location = new System.Drawing.Point(18, 702);
            this.cmdKick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdKick.Name = "cmdKick";
            this.cmdKick.Size = new System.Drawing.Size(123, 48);
            this.cmdKick.TabIndex = 39;
            this.cmdKick.Text = "kick";
            this.cmdKick.UseVisualStyleBackColor = true;
            this.cmdKick.Click += new System.EventHandler(this.cmdKick_Click);
            // 
            // cmdMap
            // 
            this.cmdMap.Location = new System.Drawing.Point(160, 702);
            this.cmdMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMap.Name = "cmdMap";
            this.cmdMap.Size = new System.Drawing.Size(123, 48);
            this.cmdMap.TabIndex = 40;
            this.cmdMap.Text = "map turnpike";
            this.cmdMap.UseVisualStyleBackColor = true;
            this.cmdMap.Click += new System.EventHandler(this.cmdMap_Click);
            // 
            // cmdReload
            // 
            this.cmdReload.Location = new System.Drawing.Point(298, 702);
            this.cmdReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdReload.Name = "cmdReload";
            this.cmdReload.Size = new System.Drawing.Size(123, 48);
            this.cmdReload.TabIndex = 41;
            this.cmdReload.Text = "reload map";
            this.cmdReload.UseVisualStyleBackColor = true;
            this.cmdReload.Click += new System.EventHandler(this.cmdReload_Click);
            // 
            // cmdSlap
            // 
            this.cmdSlap.Location = new System.Drawing.Point(442, 702);
            this.cmdSlap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSlap.Name = "cmdSlap";
            this.cmdSlap.Size = new System.Drawing.Size(123, 48);
            this.cmdSlap.TabIndex = 42;
            this.cmdSlap.Text = "slap";
            this.cmdSlap.UseVisualStyleBackColor = true;
            this.cmdSlap.Click += new System.EventHandler(this.cmdSlap_Click);
            // 
            // cmdFriendlyFire
            // 
            this.cmdFriendlyFire.Location = new System.Drawing.Point(585, 702);
            this.cmdFriendlyFire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdFriendlyFire.Name = "cmdFriendlyFire";
            this.cmdFriendlyFire.Size = new System.Drawing.Size(123, 48);
            this.cmdFriendlyFire.TabIndex = 43;
            this.cmdFriendlyFire.Text = "friendlyfire";
            this.cmdFriendlyFire.UseVisualStyleBackColor = true;
            this.cmdFriendlyFire.Click += new System.EventHandler(this.cmdFriendlyFire_Click);
            // 
            // cmdTimelimit
            // 
            this.cmdTimelimit.Location = new System.Drawing.Point(724, 702);
            this.cmdTimelimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdTimelimit.Name = "cmdTimelimit";
            this.cmdTimelimit.Size = new System.Drawing.Size(123, 48);
            this.cmdTimelimit.TabIndex = 44;
            this.cmdTimelimit.Text = "timelimit";
            this.cmdTimelimit.UseVisualStyleBackColor = true;
            this.cmdTimelimit.Click += new System.EventHandler(this.cmdTimelimit_Click);
            // 
            // cmdSwapteams
            // 
            this.cmdSwapteams.Location = new System.Drawing.Point(20, 762);
            this.cmdSwapteams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSwapteams.Name = "cmdSwapteams";
            this.cmdSwapteams.Size = new System.Drawing.Size(123, 48);
            this.cmdSwapteams.TabIndex = 45;
            this.cmdSwapteams.Text = "swapteams";
            this.cmdSwapteams.UseVisualStyleBackColor = true;
            this.cmdSwapteams.Click += new System.EventHandler(this.cmdSwapteams_Click);
            // 
            // cmdWaverespawn
            // 
            this.cmdWaverespawn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWaverespawn.Location = new System.Drawing.Point(160, 765);
            this.cmdWaverespawn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdWaverespawn.Name = "cmdWaverespawn";
            this.cmdWaverespawn.Size = new System.Drawing.Size(123, 48);
            this.cmdWaverespawn.TabIndex = 46;
            this.cmdWaverespawn.Text = "waverespawn";
            this.cmdWaverespawn.UseVisualStyleBackColor = true;
            this.cmdWaverespawn.Click += new System.EventHandler(this.cmdWaverespawn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "RconPass";
            // 
            // txtRconPassword
            // 
            this.txtRconPassword.Location = new System.Drawing.Point(496, 602);
            this.txtRconPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.PasswordChar = '*';
            this.txtRconPassword.Size = new System.Drawing.Size(104, 26);
            this.txtRconPassword.TabIndex = 47;
            this.txtRconPassword.Text = "testpass";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(609, 606);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Player Target";
            // 
            // txtPlayerTarget
            // 
            this.txtPlayerTarget.Location = new System.Drawing.Point(720, 602);
            this.txtPlayerTarget.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPlayerTarget.Name = "txtPlayerTarget";
            this.txtPlayerTarget.Size = new System.Drawing.Size(130, 26);
            this.txtPlayerTarget.TabIndex = 50;
            this.txtPlayerTarget.Text = "dkryzen";
            // 
            // cmdGravity
            // 
            this.cmdGravity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGravity.Location = new System.Drawing.Point(298, 765);
            this.cmdGravity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGravity.Name = "cmdGravity";
            this.cmdGravity.Size = new System.Drawing.Size(123, 48);
            this.cmdGravity.TabIndex = 51;
            this.cmdGravity.Text = "gravity";
            this.cmdGravity.UseVisualStyleBackColor = true;
            this.cmdGravity.Click += new System.EventHandler(this.cmdGravity_Click);
            // 
            // cmdNuke
            // 
            this.cmdNuke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuke.Location = new System.Drawing.Point(442, 765);
            this.cmdNuke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdNuke.Name = "cmdNuke";
            this.cmdNuke.Size = new System.Drawing.Size(123, 48);
            this.cmdNuke.TabIndex = 52;
            this.cmdNuke.Text = "nuke";
            this.cmdNuke.UseVisualStyleBackColor = true;
            this.cmdNuke.Click += new System.EventHandler(this.cmdNuke_Click);
            // 
            // cmdSuddenDeath
            // 
            this.cmdSuddenDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuddenDeath.Location = new System.Drawing.Point(585, 765);
            this.cmdSuddenDeath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSuddenDeath.Name = "cmdSuddenDeath";
            this.cmdSuddenDeath.Size = new System.Drawing.Size(123, 48);
            this.cmdSuddenDeath.TabIndex = 53;
            this.cmdSuddenDeath.Text = "suddendeath";
            this.cmdSuddenDeath.UseVisualStyleBackColor = true;
            this.cmdSuddenDeath.Click += new System.EventHandler(this.cmdSuddenDeath_Click);
            // 
            // cmdGetStatus
            // 
            this.cmdGetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGetStatus.Location = new System.Drawing.Point(724, 765);
            this.cmdGetStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdGetStatus.Name = "cmdGetStatus";
            this.cmdGetStatus.Size = new System.Drawing.Size(123, 48);
            this.cmdGetStatus.TabIndex = 54;
            this.cmdGetStatus.Text = "getstatus";
            this.cmdGetStatus.UseVisualStyleBackColor = true;
            this.cmdGetStatus.Click += new System.EventHandler(this.cmdGetStatus_Click);
            // 
            // cmdMute
            // 
            this.cmdMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMute.Location = new System.Drawing.Point(20, 826);
            this.cmdMute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdMute.Name = "cmdMute";
            this.cmdMute.Size = new System.Drawing.Size(123, 48);
            this.cmdMute.TabIndex = 55;
            this.cmdMute.Text = "mute";
            this.cmdMute.UseVisualStyleBackColor = true;
            this.cmdMute.Click += new System.EventHandler(this.cmdMute_Click);
            // 
            // cmdBan
            // 
            this.cmdBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBan.Location = new System.Drawing.Point(160, 826);
            this.cmdBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdBan.Name = "cmdBan";
            this.cmdBan.Size = new System.Drawing.Size(123, 48);
            this.cmdBan.TabIndex = 56;
            this.cmdBan.Text = "ban";
            this.cmdBan.UseVisualStyleBackColor = true;
            this.cmdBan.Click += new System.EventHandler(this.cmdBan_Click);
            // 
            // cmdTempban
            // 
            this.cmdTempban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTempban.Location = new System.Drawing.Point(298, 826);
            this.cmdTempban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdTempban.Name = "cmdTempban";
            this.cmdTempban.Size = new System.Drawing.Size(123, 48);
            this.cmdTempban.TabIndex = 57;
            this.cmdTempban.Text = "tempban";
            this.cmdTempban.UseVisualStyleBackColor = true;
            this.cmdTempban.Click += new System.EventHandler(this.cmdTempban_Click);
            // 
            // cmdUnban
            // 
            this.cmdUnban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnban.Location = new System.Drawing.Point(442, 826);
            this.cmdUnban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdUnban.Name = "cmdUnban";
            this.cmdUnban.Size = new System.Drawing.Size(123, 48);
            this.cmdUnban.TabIndex = 58;
            this.cmdUnban.Text = "unban";
            this.cmdUnban.UseVisualStyleBackColor = true;
            this.cmdUnban.Click += new System.EventHandler(this.cmdUnban_Click);
            // 
            // cmdSmite
            // 
            this.cmdSmite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSmite.Location = new System.Drawing.Point(585, 826);
            this.cmdSmite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSmite.Name = "cmdSmite";
            this.cmdSmite.Size = new System.Drawing.Size(123, 48);
            this.cmdSmite.TabIndex = 59;
            this.cmdSmite.Text = "smite";
            this.cmdSmite.UseVisualStyleBackColor = true;
            this.cmdSmite.Click += new System.EventHandler(this.cmdSmite_Click);
            // 
            // cbxEnteredHex
            // 
            this.cbxEnteredHex.AutoSize = true;
            this.cbxEnteredHex.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbxEnteredHex.Location = new System.Drawing.Point(161, 969);
            this.cbxEnteredHex.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbxEnteredHex.Name = "cbxEnteredHex";
            this.cbxEnteredHex.Size = new System.Drawing.Size(124, 24);
            this.cbxEnteredHex.TabIndex = 60;
            this.cbxEnteredHex.Text = "Entered Hex";
            this.cbxEnteredHex.UseVisualStyleBackColor = true;
            // 
            // cmdStopListening
            // 
            this.cmdStopListening.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdStopListening.Location = new System.Drawing.Point(724, 949);
            this.cmdStopListening.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdStopListening.Name = "cmdStopListening";
            this.cmdStopListening.Size = new System.Drawing.Size(123, 42);
            this.cmdStopListening.TabIndex = 62;
            this.cmdStopListening.Text = "Stop Listening";
            this.cmdStopListening.UseVisualStyleBackColor = true;
            this.cmdStopListening.Visible = false;
            // 
            // cmdStartListening
            // 
            this.cmdStartListening.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdStartListening.Location = new System.Drawing.Point(588, 949);
            this.cmdStartListening.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdStartListening.Name = "cmdStartListening";
            this.cmdStartListening.Size = new System.Drawing.Size(120, 42);
            this.cmdStartListening.TabIndex = 61;
            this.cmdStartListening.Text = "Start Listening";
            this.cmdStartListening.UseVisualStyleBackColor = true;
            this.cmdStartListening.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(584, 918);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Listening Port";
            this.label2.Visible = false;
            // 
            // txtListeningPort
            // 
            this.txtListeningPort.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtListeningPort.Location = new System.Drawing.Point(724, 915);
            this.txtListeningPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtListeningPort.Name = "txtListeningPort";
            this.txtListeningPort.Size = new System.Drawing.Size(123, 26);
            this.txtListeningPort.TabIndex = 63;
            this.txtListeningPort.Text = "7070";
            this.txtListeningPort.Visible = false;
            // 
            // cmdPlayerList
            // 
            this.cmdPlayerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlayerList.Location = new System.Drawing.Point(724, 826);
            this.cmdPlayerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdPlayerList.Name = "cmdPlayerList";
            this.cmdPlayerList.Size = new System.Drawing.Size(123, 48);
            this.cmdPlayerList.TabIndex = 65;
            this.cmdPlayerList.Text = "playerlist";
            this.cmdPlayerList.UseVisualStyleBackColor = true;
            this.cmdPlayerList.Click += new System.EventHandler(this.cmdPlayerList_Click);
            // 
            // cmdSendWait
            // 
            this.cmdSendWait.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmdSendWait.Location = new System.Drawing.Point(442, 938);
            this.cmdSendWait.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdSendWait.Name = "cmdSendWait";
            this.cmdSendWait.Size = new System.Drawing.Size(123, 52);
            this.cmdSendWait.TabIndex = 66;
            this.cmdSendWait.Text = "Send && Wait UrT";
            this.cmdSendWait.UseVisualStyleBackColor = true;
            this.cmdSendWait.Click += new System.EventHandler(this.cmdSendWait_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(81, 891);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(62, 20);
            this.lblHash.TabIndex = 67;
            this.lblHash.Text = "<hash>";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(160, 888);
            this.txtHash.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(405, 26);
            this.txtHash.TabIndex = 68;
            // 
            // cmdTCPSendUE
            // 
            this.cmdTCPSendUE.Location = new System.Drawing.Point(648, 643);
            this.cmdTCPSendUE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmdTCPSendUE.Name = "cmdTCPSendUE";
            this.cmdTCPSendUE.Size = new System.Drawing.Size(98, 52);
            this.cmdTCPSendUE.TabIndex = 69;
            this.cmdTCPSendUE.Text = "TCP Send && Wait UE";
            this.cmdTCPSendUE.UseVisualStyleBackColor = true;
            this.cmdTCPSendUE.Click += new System.EventHandler(this.cmdTCPSendUE_Click);
            // 
            // NetworkChatUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 1011);
            this.Controls.Add(this.cmdTCPSendUE);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.cmdSendWait);
            this.Controls.Add(this.cmdPlayerList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtListeningPort);
            this.Controls.Add(this.cmdStopListening);
            this.Controls.Add(this.cmdStartListening);
            this.Controls.Add(this.cbxEnteredHex);
            this.Controls.Add(this.cmdSmite);
            this.Controls.Add(this.cmdUnban);
            this.Controls.Add(this.cmdTempban);
            this.Controls.Add(this.cmdBan);
            this.Controls.Add(this.cmdMute);
            this.Controls.Add(this.cmdGetStatus);
            this.Controls.Add(this.cmdSuddenDeath);
            this.Controls.Add(this.cmdNuke);
            this.Controls.Add(this.cmdGravity);
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
            this.Controls.Add(this.cmdSendWaitUE);
            this.Controls.Add(this.cmdFillUrT);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYourIP);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdFillUrT;
        private System.Windows.Forms.Button cmdSendWaitUE;
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
        private System.Windows.Forms.Button cmdGravity;
        private System.Windows.Forms.Button cmdNuke;
        private System.Windows.Forms.Button cmdSuddenDeath;
        private System.Windows.Forms.Button cmdGetStatus;
        private System.Windows.Forms.Button cmdMute;
        private System.Windows.Forms.Button cmdBan;
        private System.Windows.Forms.Button cmdTempban;
        private System.Windows.Forms.Button cmdUnban;
        private System.Windows.Forms.Button cmdSmite;
        private System.Windows.Forms.CheckBox cbxEnteredHex;
        private System.Windows.Forms.Button cmdStopListening;
        private System.Windows.Forms.Button cmdStartListening;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListeningPort;
        private System.Windows.Forms.Button cmdPlayerList;
        private System.Windows.Forms.Button cmdSendWait;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button cmdTCPSendUE;
    }
}

