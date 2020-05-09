using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.HashFunction;
using System.Data.HashFunction.CityHash;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkChatUDP
{
    public partial class NetworkChatUDP : Form
    {
        /// <summary>
        ///  running = listening as server
        /// </summary>
        public bool running = false;
        /// <summary>
        /// waiting = waiting for a response (as a sender)
        /// </summary>
        public bool waiting = false;

        public NetworkChatUDP()
        {
            InitializeComponent();
        }

        #region form functions

        public void AddOutput(string str)
        {
            txtOutput.AppendText(str);
            txtOutput.AppendText("\r\n");
        }

        private void NetworkChatUDP_Load(object sender, EventArgs e)
        {
            string ip = GetLocalIPAddress();
            this.txtYourIP.Text = ip;

            //ICityHashConfig cityHashConfig = new CityHashConfig();
            //ICityHash cityHash = CityHashFactory.Instance.Create(cityHashConfig);
            ICityHash cityHash = CityHashFactory.Instance.Create();
            IHashValue hashValue32 = cityHash.ComputeHash(txtRconPassword.Text, 32);
            // this gives us lowercase, which is what we want
            txtHash.Text = hashValue32.AsHexString();
        }

        private void NetworkChatUDP_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                /// if it's wider than the base width (screen says 787, but resize says around 593)
                if (this.Width > 600)
                {
                    /// current width - (starting form width - starting output width)
                    txtOutput.Width = this.Width - (787 - 744);
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void txtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cmdSendWaitUE_Click(sender, e);
            }
        }

        #endregion

        #region network listen functions (unused)

        public void StartListening()
        {
            // Establish the local endpoint for the socket.
            // Dns.GetHostName returns the name of the 
            // host running the application.
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            int port = Int32.Parse(this.txtListeningPort.Text);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);

            //// Create a socket.
            //Socket listener = new Socket(AddressFamily.InterNetwork,
            //    SocketType.Stream, ProtocolType.Tcp);
            UdpClient listener = new UdpClient(port, AddressFamily.InterNetwork);

            this.running = true;
            this.cmdStartListening.Enabled = false;
            this.cmdStopListening.Enabled = true;

            // Bind the socket to the local endpoint and 
            // listen for incoming connections.
            try
            {
                // Start listening for connections.
                while (this.running)
                {
                    //Console.WriteLine("Waiting for a connection...");
                    this.AddOutput("Server: Waiting for a connection...");
                    // Program is suspended while waiting for an incoming connection.
                    string data = null;

                    // just fill remote with something.  Receive will overwrite it with the remote endpoint
                    IPEndPoint remote = localEndPoint;
                    byte[] bytes = listener.Receive(ref remote);
                    int bytesRec = bytes.Length;
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    if ("~".Equals(data) || "EXIT".Equals(data))
                    {
                        this.running = false;
                    }

                    // Show the data on the console.
                    //Console.WriteLine("Text received : {0}", data);
                    this.AddOutput(string.Format("Received from {0}: {1}", remote.Address.ToString(), data));
                    this.AddOutput(string.Format("  Hex: {0}", this.ToHexString(bytes, " ")));

                    // Echo the data back to the client.
                    //byte[] msg = Encoding.ASCII.GetBytes(data);
                    byte[] msg = new byte[bytes.Length];
                    bytes.CopyTo(msg, 0);

                    // send echo message
                    IPEndPoint remoteEP = new IPEndPoint(remote.Address, remote.Port);
                    listener.Send(msg, msg.Length, remoteEP);

                    Application.DoEvents();
                }//while
            }//try
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                this.AddOutput(string.Format("Error: {0}", ex.ToString()));
            }

            this.cmdStopListening.Enabled = false;
            this.cmdStartListening.Enabled = true;

            listener.Close();
            //Console.WriteLine("\nPress ENTER to continue...");
            //Console.Read();
        }

        private void cmdStartListening_Click(object sender, EventArgs e)
        {
            StartListening();
        }

        private void cmdStopListening_Click(object sender, EventArgs e)
        {
            this.running = false;
            this.waiting = false;
        }

        #endregion

        #region string functions

        public static byte[] StringToByteArray(string hex)
        {
            hex = hex.Replace(" ", "");

            if (hex.Length % 2 == 1)
                throw new Exception("The hex cannot have an odd length");

            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public string ToHexString(string input, string delimiter)
        {
            byte[] bytes = Encoding.Default.GetBytes(input);
            var hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", delimiter);
            return hexString;
        }

        public string ToHexString(byte[] bytes, string delimiter)
        {
            var hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", delimiter);
            return hexString;
        }

        #endregion

        #region network send functions

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void cmdSendWaitUE_Click(object sender, EventArgs e)
        {
            this.StartClientWaitUE();
        }

        public void StartClientWaitUE()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = IPAddress.Parse(this.txtServerIP.Text);
                int port = Int32.Parse(this.txtServerPort.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a socket.
                Socket sender = new Socket(AddressFamily.InterNetwork
                    , SocketType.Dgram, ProtocolType.Udp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.ReceiveTimeout = 15 * 1000;  // in milliseconds
                    sender.SendTimeout = 15 * 1000;  // in milliseconds
                    sender.Connect(remoteEP);

                    //Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                    this.AddOutput(string.Format("Client: Socket connected to {0}", sender.RemoteEndPoint.ToString()));

                    // Encode the data string into a byte array.
                    byte[] msg;
                    if (cbxEnteredHex.Checked)
                    {
                        msg = StringToByteArray(this.txtMessage.Text);
                    }
                    else
                    {
                        msg = Encoding.ASCII.GetBytes(this.txtMessage.Text);
                        // replace graves with 0xFF
                        for (int idx = 0; idx < msg.Length; idx++)
                        {
                            if ('`' == msg[idx]) msg[idx] = 0xFF;
                        }
                    }//else

                    string msgText = null;
                    msgText += Encoding.ASCII.GetString(msg, 0, msg.Length);
                    //this.AddOutput(string.Format("Client sent msg {0}", msgText));

                    // for some strange reason UE4 is receiving the string shifted one character to the right
                    for (int idx2 = 0; idx2 < msg.Length; idx2++)
                    {
                        msg[idx2]--;
                    }

                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);
                    this.AddOutput(string.Format("Client sent msg {0}  ({1})", msgText, bytesSent));

                    //this.Refresh();
                    this.txtOutput.Refresh();

                    //// try receiving on the same port
                    byte[] bytes = new byte[1500];
                    /// stalls everything if a response isn't received
                    int bytesRec = sender.Receive(bytes);
                    
                    ////int bytesRec = 0;
                    ////SocketAsyncEventArgs socketArgs = new SocketAsyncEventArgs();
                    ////socketArgs.SetBuffer(bytes, 0, bytes.Length);
                    ////socketArgs.RemoteEndPoint = new IPEndPoint(
                    ////    sender.AddressFamily == AddressFamily.InterNetwork ? IPAddress.Any : IPAddress.IPv6Any, 0);
                    ////this.waiting = true;
                    ////while (!sender.ReceiveFromAsync(socketArgs) && this.waiting)
                    ////{
                    ////    if (socketArgs.SocketError == SocketError.Success)
                    ////    {
                    ////        bytesRec = socketArgs.BytesTransferred;
                    ////        this.waiting = false;
                    ////    }
                    ////}//while

                    // for some strange reason UE4 is sending the string shifted one character to the left
                    for (int idx2 = 0; idx2 < bytes.Length; idx2++)
                    {
                        bytes[idx2]++;
                    }

                    if (bytesRec != 0)
                    {
                        string data = null;
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        // Receive the response from the remote device.
                        //int bytesRec = sender.Receive(bytes);
                        //Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                        this.AddOutput(string.Format("Client Received: {0} ({1})", data, data.Length));
                        //this.AddOutput(string.Format("  Hex: {0}", this.ToHexString(bytes, " ")));
                    }//if

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }//try
                catch (ArgumentNullException ane)
                {
                    //Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    this.AddOutput(string.Format("ArgumentNullException: {0}", ane.ToString()));
                }
                catch (SocketException se)
                {
                    //Console.WriteLine("SocketException : {0}", se.ToString());
                    this.AddOutput(string.Format("SocketException: {0}", se.ToString()));
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Unexpected exception : {0}", ex.ToString());
                    this.AddOutput(string.Format("Unexpected exception: {0}", ex.ToString()));
                }
            }//try
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                this.AddOutput(string.Format("Error: {0}", e.ToString()));
            }
        }

        private void cmdTCPSendUE_Click(object sender, EventArgs e)
        {
            this.StartTCPClientWaitUE();
        }

        public void StartTCPClientWaitUE()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = IPAddress.Parse(this.txtServerIP.Text);
                int port = Int32.Parse(this.txtServerPort.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a socket.
                Socket sender = new Socket(AddressFamily.InterNetwork
                    , SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.ReceiveTimeout = 15 * 1000;  // in milliseconds
                    sender.SendTimeout = 15 * 1000;  // in milliseconds
                    sender.Connect(remoteEP);

                    //Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                    this.AddOutput(string.Format("Client: Socket connected to {0}", sender.RemoteEndPoint.ToString()));

                    // Encode the data string into a byte array.
                    byte[] msg;
                    if (cbxEnteredHex.Checked)
                    {
                        msg = StringToByteArray(this.txtMessage.Text);
                    }
                    else
                    {
                        msg = Encoding.ASCII.GetBytes(this.txtMessage.Text);
                        // replace graves with 0xFF
                        for (int idx = 0; idx < msg.Length; idx++)
                        {
                            if ('`' == msg[idx]) msg[idx] = 0xFF;
                        }
                    }//else

                    string msgText = null;
                    msgText += Encoding.ASCII.GetString(msg, 0, msg.Length);
                    //this.AddOutput(string.Format("Client sent msg {0}", msgText));

                    // for some strange reason UE4 is receiving the string shifted one character to the right
                    for (int idx2 = 0; idx2 < msg.Length; idx2++)
                    {
                        msg[idx2]--;
                    }

                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);
                    this.AddOutput(string.Format("Client sent msg {0}  ({1})", msgText, bytesSent));

                    //this.Refresh();
                    this.txtOutput.Refresh();

                    //// try receiving on the same port
                    byte[] bytes = new byte[1500];
                    /// stalls everything if a response isn't received
                    int bytesRec = sender.Receive(bytes);

                    ////int bytesRec = 0;
                    ////SocketAsyncEventArgs socketArgs = new SocketAsyncEventArgs();
                    ////socketArgs.SetBuffer(bytes, 0, bytes.Length);
                    ////socketArgs.RemoteEndPoint = new IPEndPoint(
                    ////    sender.AddressFamily == AddressFamily.InterNetwork ? IPAddress.Any : IPAddress.IPv6Any, 0);
                    ////this.waiting = true;
                    ////while (!sender.ReceiveFromAsync(socketArgs) && this.waiting)
                    ////{
                    ////    if (socketArgs.SocketError == SocketError.Success)
                    ////    {
                    ////        bytesRec = socketArgs.BytesTransferred;
                    ////        this.waiting = false;
                    ////    }
                    ////}//while

                    // for some strange reason UE4 is sending the string shifted one character to the left
                    for (int idx2 = 0; idx2 < bytes.Length; idx2++)
                    {
                        bytes[idx2]++;
                    }

                    if (bytesRec != 0)
                    {
                        string data = null;
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        // Receive the response from the remote device.
                        //int bytesRec = sender.Receive(bytes);
                        //Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                        this.AddOutput(string.Format("Client Received: {0} ({1})", data, data.Length));
                        //this.AddOutput(string.Format("  Hex: {0}", this.ToHexString(bytes, " ")));
                    }//if

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }//try
                catch (ArgumentNullException ane)
                {
                    //Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    this.AddOutput(string.Format("ArgumentNullException: {0}", ane.ToString()));
                }
                catch (SocketException se)
                {
                    //Console.WriteLine("SocketException : {0}", se.ToString());
                    this.AddOutput(string.Format("SocketException: {0}", se.ToString()));
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Unexpected exception : {0}", ex.ToString());
                    this.AddOutput(string.Format("Unexpected exception: {0}", ex.ToString()));
                }
            }//try
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                this.AddOutput(string.Format("Error: {0}", e.ToString()));
            }
        }

        #endregion

        #region UrT 4.x

        private void cmdFillUrT_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "192.168.200.157";
            txtServerPort.Text = "27960";
            txtMessage.Text = "````getstatus";
            cbxEnteredHex.Checked = false;
        }

        private void cmdSendWait_Click(object sender, EventArgs e)
        {
            StartClient();
        }

        public void StartClient()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = IPAddress.Parse(this.txtServerIP.Text);
                int port = Int32.Parse(this.txtServerPort.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a socket.
                Socket sender = new Socket(AddressFamily.InterNetwork
                    , SocketType.Dgram, ProtocolType.Udp);

                // Connect the socket to the remote endpoint. Catch any errors.
                // Connect the socket to the remote endpoint. Catch any errors.
                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.ReceiveTimeout = 15 * 1000;  // 30 secs
                    sender.SendTimeout = 15 * 1000;  // 30 secs
                    sender.Connect(remoteEP);

                    //Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                    this.AddOutput(string.Format("Client: Socket connected to {0}", sender.RemoteEndPoint.ToString()));

                    // Encode the data string into a byte array.
                    byte[] msg;
                    if (cbxEnteredHex.Checked)
                    {
                        msg = StringToByteArray(this.txtMessage.Text);
                    }
                    else
                    {
                        msg = Encoding.ASCII.GetBytes(this.txtMessage.Text);
                        // replace graves with 0xFF
                        for (int idx = 0; idx < msg.Length; idx++)
                        {
                            if ('`' == msg[idx]) msg[idx] = 0xFF;
                        }
                    }//else

                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);

                    // try receiving on the same port
                    byte[] bytes = new byte[1500];
                    int bytesRec = sender.Receive(bytes);
                    string data = null;
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    //// Receive the response from the remote device.
                    //Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    this.AddOutput(string.Format("Client Received: {0}", data));
                    this.AddOutput(string.Format("  Hex: {0}", this.ToHexString(bytes, " ")));

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }//try
                catch (ArgumentNullException ane)
                {
                    //Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    this.AddOutput(string.Format("ArgumentNullException: {0}", ane.ToString()));
                }
                catch (SocketException se)
                {
                    //Console.WriteLine("SocketException : {0}", se.ToString());
                    this.AddOutput(string.Format("SocketException: {0}", se.ToString()));
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Unexpected exception : {0}", ex.ToString());
                    this.AddOutput(string.Format("Unexpected exception: {0}", ex.ToString()));
                }
            }//try
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                this.AddOutput(string.Format("Error: {0}", e.ToString()));
            }
        }

        #endregion

        #region Action Buttons

        private void cmdKick_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} kick {1}", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdMap_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} map turnpike", txtHash.Text);
        }

        private void cmdReload_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} reload", txtHash.Text);
        }

        private void cmdSlap_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} slap {1} 2", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdFriendlyFire_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} friendlyfire 0", txtHash.Text);
        }

        private void cmdTimelimit_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} timelimit 22", txtHash.Text);
        }

        private void cmdSwapteams_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} swapteams", txtHash.Text);
        }

        private void cmdWaverespawn_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} waverespawn 1", txtHash.Text);
        }

        private void cmdGravity_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} gravity 500", txtHash.Text);
        }

        private void cmdSuddenDeath_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} suddendeath 1", txtHash.Text);
        }

        private void cmdNuke_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} nuke {1}", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdMute_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} mute {1} 60", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdBan_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} ban {1}", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdTempban_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} tempban {1} 20m", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdUnban_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} unban {1}", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdSmite_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("rcon {0} smite {1}", txtHash.Text, txtPlayerTarget.Text);
        }

        private void cmdPlayerList_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "playerlist";
        }

        private void cmdGetStatus_Click(object sender, EventArgs e)
        {
            txtMessage.Text = string.Format("getstatus");
        }

        #endregion

    }
}
