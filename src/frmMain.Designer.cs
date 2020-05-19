namespace LOIC
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdTargetIP = new System.Windows.Forms.Button();
            this.txtTargetIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdTargetURL = new System.Windows.Forms.Button();
            this.txtTargetURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAllowGzip = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbFailed = new System.Windows.Forms.Label();
            this.lbRequested = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbDownloaded = new System.Windows.Forms.Label();
            this.lbDownloading = new System.Windows.Forms.Label();
            this.lbRequesting = new System.Windows.Forms.Label();
            this.lbConnecting = new System.Windows.Forms.Label();
            this.lbIdle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chkUseGet = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLSpT = new System.Windows.Forms.TextBox();
            this.chkMsgRandom = new System.Windows.Forms.CheckBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.chkWaitReply = new System.Windows.Forms.CheckBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtSubsite = new System.Windows.Forms.TextBox();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdAttack = new System.Windows.Forms.Button();
            this.TTip = new System.Windows.Forms.ToolTip(this.components);
            this.tShowStats = new System.Windows.Forms.Timer(this.components);
            this.tCheckOL = new System.Windows.Forms.Timer(this.components);
            this.tZergRush = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdTargetIP);
            this.groupBox1.Controls.Add(this.txtTargetIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdTargetURL);
            this.groupBox1.Controls.Add(this.txtTargetURL);
            this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Location = new System.Drawing.Point(37, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(786, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select your target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdTargetIP
            // 
            this.cmdTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdTargetIP.ForeColor = System.Drawing.Color.Azure;
            this.cmdTargetIP.Location = new System.Drawing.Point(632, 100);
            this.cmdTargetIP.Margin = new System.Windows.Forms.Padding(0);
            this.cmdTargetIP.Name = "cmdTargetIP";
            this.cmdTargetIP.Size = new System.Drawing.Size(140, 60);
            this.cmdTargetIP.TabIndex = 4;
            this.cmdTargetIP.Text = "Get IP";
            this.cmdTargetIP.UseVisualStyleBackColor = false;
            this.cmdTargetIP.Click += new System.EventHandler(this.cmdTargetIP_Click);
            // 
            // txtTargetIP
            // 
            this.txtTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTargetIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetIP.ForeColor = System.Drawing.Color.Azure;
            this.txtTargetIP.Location = new System.Drawing.Point(109, 111);
            this.txtTargetIP.Name = "txtTargetIP";
            this.txtTargetIP.Size = new System.Drawing.Size(493, 39);
            this.txtTargetIP.TabIndex = 3;
            this.TTip.SetToolTip(this.txtTargetIP, "If you know your target\'s IP, enter the IP here and click \"Lock on\"");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdTargetURL
            // 
            this.cmdTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdTargetURL.ForeColor = System.Drawing.Color.Azure;
            this.cmdTargetURL.Location = new System.Drawing.Point(633, 32);
            this.cmdTargetURL.Margin = new System.Windows.Forms.Padding(0);
            this.cmdTargetURL.Name = "cmdTargetURL";
            this.cmdTargetURL.Size = new System.Drawing.Size(140, 60);
            this.cmdTargetURL.TabIndex = 2;
            this.cmdTargetURL.Text = "Get IP";
            this.cmdTargetURL.UseVisualStyleBackColor = false;
            this.cmdTargetURL.Click += new System.EventHandler(this.cmdTargetURL_Click);
            // 
            // txtTargetURL
            // 
            this.txtTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTargetURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetURL.ForeColor = System.Drawing.Color.Azure;
            this.txtTargetURL.Location = new System.Drawing.Point(109, 38);
            this.txtTargetURL.Name = "txtTargetURL";
            this.txtTargetURL.Size = new System.Drawing.Size(493, 39);
            this.txtTargetURL.TabIndex = 1;
            this.TTip.SetToolTip(this.txtTargetURL, "If you don\'t know your target\'s IP, enter a URL here and click \"Lock on\"");
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtTarget);
            this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Location = new System.Drawing.Point(37, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1119, 239);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected target";
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarget.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.ForeColor = System.Drawing.Color.Azure;
            this.txtTarget.Location = new System.Drawing.Point(14, 51);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(8);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(1091, 145);
            this.txtTarget.TabIndex = 1;
            this.txtTarget.TabStop = false;
            this.txtTarget.Text = "N O N E !";
            this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtTarget, "The currently selected target");
            this.txtTarget.Enter += new System.EventHandler(this.txtTarget_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.chkAllowGzip);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.chkUseGet);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSLSpT);
            this.groupBox3.Controls.Add(this.chkMsgRandom);
            this.groupBox3.Controls.Add(this.chkRandom);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.chkWaitReply);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.txtSubsite);
            this.groupBox3.Controls.Add(this.txtTimeout);
            this.groupBox3.Controls.Add(this.txtThreads);
            this.groupBox3.Controls.Add(this.cbMethod);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.Controls.Add(this.tbSpeed);
            this.groupBox3.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Location = new System.Drawing.Point(37, 496);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1117, 583);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Attack options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Append random chars to:";
            // 
            // chkAllowGzip
            // 
            this.chkAllowGzip.AutoSize = true;
            this.chkAllowGzip.Enabled = false;
            this.chkAllowGzip.Location = new System.Drawing.Point(309, 166);
            this.chkAllowGzip.Name = "chkAllowGzip";
            this.chkAllowGzip.Size = new System.Drawing.Size(161, 36);
            this.chkAllowGzip.TabIndex = 33;
            this.chkAllowGzip.Text = "use gZip";
            this.TTip.SetToolTip(this.chkAllowGzip, "If checked, enables Gzip support for HTTP methods");
            this.chkAllowGzip.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.lbFailed);
            this.groupBox5.Controls.Add(this.lbRequested);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.lbDownloaded);
            this.groupBox5.Controls.Add(this.lbDownloading);
            this.groupBox5.Controls.Add(this.lbRequesting);
            this.groupBox5.Controls.Add(this.lbConnecting);
            this.groupBox5.Controls.Add(this.lbIdle);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox5.Location = new System.Drawing.Point(6, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1105, 234);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Attack status";
            // 
            // lbFailed
            // 
            this.lbFailed.AutoSize = true;
            this.lbFailed.Location = new System.Drawing.Point(855, 65);
            this.lbFailed.Name = "lbFailed";
            this.lbFailed.Size = new System.Drawing.Size(0, 32);
            this.lbFailed.TabIndex = 24;
            this.lbFailed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbFailed, "How many times (in total) the webserver didn\'t respond. High number = server down" +
        ".");
            // 
            // lbRequested
            // 
            this.lbRequested.AutoSize = true;
            this.lbRequested.Location = new System.Drawing.Point(314, 147);
            this.lbRequested.Name = "lbRequested";
            this.lbRequested.Size = new System.Drawing.Size(0, 32);
            this.lbRequested.TabIndex = 23;
            this.lbRequested.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbRequested, "How many times (in total) a download has been requested");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(855, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 32);
            this.label22.TabIndex = 22;
            this.label22.Text = "Failed";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(314, 117);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(150, 32);
            this.label23.TabIndex = 21;
            this.label23.Text = "Requested";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDownloaded
            // 
            this.lbDownloaded.AutoSize = true;
            this.lbDownloaded.Location = new System.Drawing.Point(556, 147);
            this.lbDownloaded.Name = "lbDownloaded";
            this.lbDownloaded.Size = new System.Drawing.Size(0, 32);
            this.lbDownloaded.TabIndex = 20;
            this.lbDownloaded.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbDownloaded, "How many times (in total) that a download has been initiated");
            // 
            // lbDownloading
            // 
            this.lbDownloading.AutoSize = true;
            this.lbDownloading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.lbDownloading.Location = new System.Drawing.Point(556, 65);
            this.lbDownloading.Name = "lbDownloading";
            this.lbDownloading.Size = new System.Drawing.Size(0, 32);
            this.lbDownloading.TabIndex = 19;
            this.lbDownloading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbDownloading, "How many threads that are downloading information from the server");
            // 
            // lbRequesting
            // 
            this.lbRequesting.AutoSize = true;
            this.lbRequesting.Location = new System.Drawing.Point(314, 65);
            this.lbRequesting.Name = "lbRequesting";
            this.lbRequesting.Size = new System.Drawing.Size(0, 32);
            this.lbRequesting.TabIndex = 18;
            this.lbRequesting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbRequesting, "How many threads that are requesting information from the server");
            // 
            // lbConnecting
            // 
            this.lbConnecting.AutoSize = true;
            this.lbConnecting.Location = new System.Drawing.Point(78, 147);
            this.lbConnecting.Name = "lbConnecting";
            this.lbConnecting.Size = new System.Drawing.Size(0, 32);
            this.lbConnecting.TabIndex = 17;
            this.lbConnecting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbConnecting, "How many threads that are trying to connect");
            // 
            // lbIdle
            // 
            this.lbIdle.AutoSize = true;
            this.lbIdle.Location = new System.Drawing.Point(78, 65);
            this.lbIdle.Name = "lbIdle";
            this.lbIdle.Size = new System.Drawing.Size(0, 32);
            this.lbIdle.TabIndex = 16;
            this.lbIdle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TTip.SetToolTip(this.lbIdle, "How many threads that are without work. Should be 0");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(556, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 32);
            this.label12.TabIndex = 15;
            this.label12.Text = "Downloaded";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(556, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 32);
            this.label13.TabIndex = 14;
            this.label13.Text = "Downloading";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 32);
            this.label14.TabIndex = 13;
            this.label14.Text = "Requesting";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 32);
            this.label15.TabIndex = 12;
            this.label15.Text = "Connecting";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 32);
            this.label16.TabIndex = 11;
            this.label16.Text = "Idle";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkUseGet
            // 
            this.chkUseGet.AutoSize = true;
            this.chkUseGet.Enabled = false;
            this.chkUseGet.Location = new System.Drawing.Point(140, 166);
            this.chkUseGet.Name = "chkUseGet";
            this.chkUseGet.Size = new System.Drawing.Size(163, 36);
            this.chkUseGet.TabIndex = 32;
            this.chkUseGet.Text = "use GET";
            this.TTip.SetToolTip(this.chkUseGet, "If checked it uses the GET method instead of POST.");
            this.chkUseGet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sockets / Thread";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSLSpT
            // 
            this.txtSLSpT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtSLSpT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSLSpT.Enabled = false;
            this.txtSLSpT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLSpT.ForeColor = System.Drawing.Color.Azure;
            this.txtSLSpT.Location = new System.Drawing.Point(595, 215);
            this.txtSLSpT.Name = "txtSLSpT";
            this.txtSLSpT.Size = new System.Drawing.Size(65, 39);
            this.txtSLSpT.TabIndex = 30;
            this.txtSLSpT.Text = "25";
            this.txtSLSpT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtSLSpT, "Amount of sockets per thread");
            // 
            // chkMsgRandom
            // 
            this.chkMsgRandom.Location = new System.Drawing.Point(589, 27);
            this.chkMsgRandom.Name = "chkMsgRandom";
            this.chkMsgRandom.Size = new System.Drawing.Size(176, 48);
            this.chkMsgRandom.TabIndex = 29;
            this.chkMsgRandom.Text = "Message";
            this.TTip.SetToolTip(this.chkMsgRandom, "Enable appending random chars to the message every request");
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Enabled = false;
            this.chkRandom.Location = new System.Drawing.Point(474, 33);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(109, 36);
            this.chkRandom.TabIndex = 28;
            this.chkRandom.Text = "URL";
            this.TTip.SetToolTip(this.chkRandom, "Enable appending random chars to the subsite every request");
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(679, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(272, 32);
            this.label18.TabIndex = 25;
            this.label18.Text = "TCP / UDP message";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(340, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 32);
            this.label17.TabIndex = 24;
            this.label17.Text = "HTTP Subsite";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Timeout";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Threads";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Port";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(691, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(354, 32);
            this.label20.TabIndex = 18;
            this.label20.Text = "<= faster  Speed  slower =>";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkWaitReply
            // 
            this.chkWaitReply.AutoSize = true;
            this.chkWaitReply.Location = new System.Drawing.Point(476, 166);
            this.chkWaitReply.Name = "chkWaitReply";
            this.chkWaitReply.Size = new System.Drawing.Size(215, 36);
            this.chkWaitReply.TabIndex = 7;
            this.chkWaitReply.Text = "Wait for reply";
            this.TTip.SetToolTip(this.chkWaitReply, "Don\'t disconnect before the server\'s started to answer");
            this.chkWaitReply.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.ForeColor = System.Drawing.Color.Azure;
            this.txtData.Location = new System.Drawing.Point(635, 112);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(349, 39);
            this.txtData.TabIndex = 3;
            this.txtData.Text = "U dun goofed";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtData, "The data to send in TCP/UDP mode");
            // 
            // txtSubsite
            // 
            this.txtSubsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtSubsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsite.ForeColor = System.Drawing.Color.Azure;
            this.txtSubsite.Location = new System.Drawing.Point(254, 112);
            this.txtSubsite.Name = "txtSubsite";
            this.txtSubsite.Size = new System.Drawing.Size(375, 39);
            this.txtSubsite.TabIndex = 2;
            this.txtSubsite.Text = "/";
            this.txtSubsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtSubsite, "What subsite to target (when using HTTP as type)");
            // 
            // txtTimeout
            // 
            this.txtTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeout.ForeColor = System.Drawing.Color.Azure;
            this.txtTimeout.Location = new System.Drawing.Point(130, 112);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(118, 39);
            this.txtTimeout.TabIndex = 1;
            this.txtTimeout.Text = "30";
            this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtTimeout, "Max time in seconds to wait for a response.");
            // 
            // txtThreads
            // 
            this.txtThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThreads.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThreads.ForeColor = System.Drawing.Color.Azure;
            this.txtThreads.Location = new System.Drawing.Point(262, 215);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(65, 39);
            this.txtThreads.TabIndex = 6;
            this.txtThreads.Text = "10";
            this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtThreads, "How many users LOIC should emulate");
            this.txtThreads.Leave += new System.EventHandler(this.txtThreads_Leave);
            // 
            // cbMethod
            // 
            this.cbMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMethod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMethod.ForeColor = System.Drawing.Color.Azure;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "HTTP",
            "ReCoil",
            "slowLOIC",
            "ICMP"});
            this.cbMethod.Location = new System.Drawing.Point(781, 164);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(145, 40);
            this.cbMethod.TabIndex = 5;
            this.cbMethod.Text = "TCP";
            this.TTip.SetToolTip(this.cbMethod, "What type of attack to launch");
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.cbMethod_SelectedIndexChanged);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.Azure;
            this.txtPort.Location = new System.Drawing.Point(898, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(60, 39);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "80";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTip.SetToolTip(this.txtPort, "What port to attack (regular websites use 80)");
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(676, 208);
            this.tbSpeed.Maximum = 50;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(369, 114);
            this.tbSpeed.TabIndex = 8;
            this.TTip.SetToolTip(this.tbSpeed, "Use this to increase or reduce attack speed");
            this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.cmdAttack);
            this.groupBox4.ForeColor = System.Drawing.Color.LightBlue;
            this.groupBox4.Location = new System.Drawing.Point(829, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 192);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Ready?";
            // 
            // cmdAttack
            // 
            this.cmdAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.cmdAttack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAttack.ForeColor = System.Drawing.Color.Azure;
            this.cmdAttack.Location = new System.Drawing.Point(48, 70);
            this.cmdAttack.Name = "cmdAttack";
            this.cmdAttack.Size = new System.Drawing.Size(246, 68);
            this.cmdAttack.TabIndex = 1;
            this.cmdAttack.Text = "Initiate";
            this.TTip.SetToolTip(this.cmdAttack, "I sincerely hope you can guess what this button does.");
            this.cmdAttack.UseVisualStyleBackColor = false;
            this.cmdAttack.Click += new System.EventHandler(this.cmdAttack_Click);
            // 
            // tShowStats
            // 
            this.tShowStats.Interval = 20;
            this.tShowStats.Tick += new System.EventHandler(this.tShowStats_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1188, 1112);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::LOIC.Properties.Resources.LOIC_ICO;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_Closed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdTargetURL;
		private System.Windows.Forms.TextBox txtTargetURL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdTargetIP;
		private System.Windows.Forms.TextBox txtTargetIP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtThreads;
		private System.Windows.Forms.ComboBox cbMethod;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button cmdAttack;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lbDownloaded;
		private System.Windows.Forms.Label lbDownloading;
		private System.Windows.Forms.Label lbRequesting;
		private System.Windows.Forms.Label lbConnecting;
		private System.Windows.Forms.Label lbIdle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbFailed;
		private System.Windows.Forms.Label lbRequested;
		private System.Windows.Forms.TextBox txtSubsite;
		private System.Windows.Forms.ToolTip TTip;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Timer tShowStats;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox chkWaitReply;
		private System.Windows.Forms.TrackBar tbSpeed;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox chkMsgRandom;
		private System.Windows.Forms.CheckBox chkRandom;
		private System.Windows.Forms.Timer tCheckOL;
		private System.Windows.Forms.Timer tZergRush;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSLSpT;
		private System.Windows.Forms.CheckBox chkAllowGzip;
		private System.Windows.Forms.CheckBox chkUseGet;
        private System.Windows.Forms.Label label4;
    }
}