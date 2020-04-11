using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkChatUDP
{
    class Removed
    {

        #region removed functions
        private void cmdFillSG15Plyr_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "192.168.200.153";
            txtServerPort.Text = "27015";
            txtMessage.Text = "````U````";
            cbxEnteredHex.Checked = false;
        }

        private void cmdFillSG16Plyr_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "192.168.200.153";
            txtServerPort.Text = "27016";
            txtMessage.Text = "````U````";
            cbxEnteredHex.Checked = false;
        }

        private void cmdSG15Info_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "192.168.200.153";
            txtServerPort.Text = "27015";
            txtMessage.Text = "````TSource Engine Query";
            cbxEnteredHex.Checked = false;
        }

        private void cmdSG16Info_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "192.168.200.153";
            txtServerPort.Text = "27016";
            txtMessage.Text = "````TSource Engine Query";
            cbxEnteredHex.Checked = false;
        }

        private void cmdUE4HS_Click(object sender, EventArgs e)
        {
            // UE4 Handshake
            // initiate challenge
            txtServerIP.Text = "192.168.200.153";
            txtServerPort.Text = "7777";
            txtMessage.Text = "01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 08";
            cbxEnteredHex.Checked = true;
        }

        private void cmdUE4c_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "127.0.0.1";
            txtServerPort.Text = "7070";
            txtMessage.Text = "rcon testpass kick userTwo";
            cbxEnteredHex.Checked = false;
        }

        private void cmdSendOnly_Click(object sender, EventArgs e)
        {
            StartClientNoWait();
        }

        public void StartClientNoWait()
        {
            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                //IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());  //obsolete
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                //IPAddress ipAddress = ipHostInfo.AddressList[0];
                //IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);
                //IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); //ipHostInfo.AddressList[0];
                IPAddress ipAddress = IPAddress.Parse(this.txtServerIP.Text);
                int port = Int32.Parse(this.txtServerPort.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);

                // Create a socket.
                Socket sender = new Socket(AddressFamily.InterNetwork
                    , SocketType.Dgram, ProtocolType.Udp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.ReceiveTimeout = 30 * 1000;  // 30 secs
                    sender.ReceiveTimeout = 30 * 1000;  // 30 secs
                    sender.ReceiveTimeout = 30 * 1000;  // 30 secs
                    sender.SendTimeout = 30 * 1000;  // 30 secs
                    sender.Connect(remoteEP);

                    // ww will listen for a response on 1 port higher than we sent on
                    //UdpClient listener = new UdpClient(((IPEndPoint)sender.LocalEndPoint).Port + 1, AddressFamily.InterNetwork);

                    //Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                    this.AddOutput(string.Format("Client: Socket connected to {0}", sender.RemoteEndPoint.ToString()));

                    // Encode the data string into a byte array.
                    //byte[] msg = Encoding.ASCII.GetBytes(string.Format("{0}{1}", this.txtMessage.Text, "<EOF>"));
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


                    //// try receiving on the same port
                    //byte[] bytes = new byte[1500];
                    //int bytesRec = sender.Receive(bytes);
                    //string data = null;
                    //data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    //// Receive the response from the remote device.
                    ////int bytesRec = sender.Receive(bytes);
                    ////Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                    //this.AddOutput(string.Format("Client Received: {0}", data));
                    //this.AddOutput(string.Format("  Hex: {0}", this.ToHexString(bytes, " ")));

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

    }
}
