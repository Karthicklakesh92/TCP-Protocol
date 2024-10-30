using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Tcp_sever_program
{
    /* TCP KEEPALIVE STRUCTURE */
    // Convert tcp_keepalive C struct To C# struct
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
    unsafe struct TcpKeepAlive
    {
        [System.Runtime.InteropServices.FieldOffset(0)]
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12)]

        public fixed byte Bytes[12];

        [System.Runtime.InteropServices.FieldOffset(0)]
        public uint On_Off;

        [System.Runtime.InteropServices.FieldOffset(4)]
        public uint KeepaLiveTime;

        [System.Runtime.InteropServices.FieldOffset(8)]
        public uint KeepaLiveInterval;
    }

    public partial class Main : Form
    {
        /*Server IP Address*/
        IPAddress Server_IP = null;

        /*Server Port Number*/
        System.Int32 Server_Port = 0;

        /*Server IPEndPoint*/
        IPEndPoint IPEndPoint = null;

        Socket Server = null;

        Socket Client = null;

        /*State Object*/
        State StateObject = null;

        /*Connection Status*/
        bool Connect_Result = false;

        public class State
        {
            public IPAddress Client_IPAddress = null;
            public System.Int32 Client_Port = 0;
            public Socket workSocket = null;
            public byte[] Sendbuffer = new byte[1024];
            public byte[] Receivebuffer = new byte[1024];
        }

        // ManualResetEvent instances signal completion.
        private static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static ManualResetEvent SendDone = new ManualResetEvent(false);
        private static ManualResetEvent ReceiveDone = new ManualResetEvent(false);

        /* TCP KEEP ALIVE METHODS */
        /* SETTING TCP KEEP ALIVE VALUES */
        public int SetKeepAliveValues(System.Net.Sockets.Socket Socket, bool On_Off, uint KeepaLiveTime, uint KeepaLiveInterval)
        {
            int Result = -1;

            unsafe
            {
                TcpKeepAlive KeepAliveValues = new TcpKeepAlive();

                KeepAliveValues.On_Off = Convert.ToUInt32(On_Off);
                KeepAliveValues.KeepaLiveTime = KeepaLiveTime;
                KeepAliveValues.KeepaLiveInterval = KeepaLiveInterval;

                byte[] InValue = new byte[12];

                for (int I = 0; I < 12; I++)
                    InValue[I] = KeepAliveValues.Bytes[I];

                Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                Result = Socket.IOControl(IOControlCode.KeepAliveValues, InValue, null);
            }

            return Result;
        }

        /* SETTING TCP KEEP ALIVE */
        public void Setting_Tcp_KeepAlive(Socket socket)
        {
            try
            {
                // Set 10 Hours: 10 * 60 * 60 * 1000 = 36,000,000 every 1 Second 1000
                int Result = SetKeepAliveValues(socket, true, 5000, 1000);
                if (Result == 0)
                {
                    logger("Keep Alive Set Successfully");
                }
            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }
        }

        public Main()
        {
            InitializeComponent();
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            ServerIPCombo.Items.Insert(0, myIP);
        }

   
        private void Listern_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Server_IP = IPAddress.Parse(ServerIPCombo.Text);
                Server_Port = int.Parse(ServerPortText.Text);

                IPEndPoint = new IPEndPoint(Server_IP, Server_Port);
                //ServerSocket = new TcpListener(IPEndPoint);

                // Create a TCP/IP socket.
                Server = new Socket(Server_IP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                Server.Bind(IPEndPoint);
                Server.Listen(100);

                logger("Start With Server Wait For Client Connection");

                Server.BeginAccept(new AsyncCallback(Asynchronous_Accept), Server);
                ConnectDone.WaitOne(1);

            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }
        }
        private void Asynchronous_Accept(IAsyncResult ar)
        {
            try
            {
                
                // Get the socket that handles the client request.
                Server = (Socket)ar.AsyncState;
                Client = Server.EndAccept(ar);

                Connect_Result = ConnectDone.Set();
                

                if (Connect_Result)
                {
                    StateObject = new State();
                    StateObject.workSocket = Client;

                    //* SETTING TCP KEEP ALIVE */
                    Setting_Tcp_KeepAlive(StateObject.workSocket);

                    logger("New Client Connection Established");
                   
                    
                   

                    Client.BeginReceive(StateObject.Receivebuffer, 0, StateObject.Receivebuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Receive), StateObject);
                    ReceiveDone.WaitOne(1);
                }
                else
                {
                    logger("Client Connection Not Established");
                    Server.BeginAccept(new AsyncCallback(Asynchronous_Accept), StateObject);
                }
            }
            catch (Exception ex)
            {
                logger(ex.Message);

                Connect_Result = false;

                logger("Client Connection Not Established");
                Server.BeginAccept(new AsyncCallback(Asynchronous_Accept), StateObject);
            }

        }

        public void Asynchronous_Receive(IAsyncResult ar)
        {
            string content = string.Empty;
            State so = null;
            Socket soc = null;
            int Read = 0;
            try
            {
                so = (State)ar.AsyncState;

                soc = so.workSocket;

                // Read data from the client socket. 
                Read = soc.EndReceive(ar);

                if (Read >0)
                {
                    if (ReceiveText.Checked || ReceiveHex.Checked)
                    {
                        if (ReceiveHex.Checked)
                        {
                            content = BitConverter.ToString(so.Receivebuffer, 0, Read);
                            ReceiveTextBox.Invoke(new MethodInvoker(delegate { ReceiveTextBox.AppendText(content + "\r\n"); }));
                        }
                        else
                        {
                            content = Encoding.UTF8.GetString(so.Receivebuffer, 0, Read);
                            ReceiveTextBox.Invoke(new MethodInvoker(delegate { ReceiveTextBox.AppendText(content + "\r\n"); }));
                        }
                    }
                }
                if (Read == 0)
                {
                    soc.Shutdown(SocketShutdown.Both);
                    soc.Close();
                    Connect_Result = false;

                    logger("A Remote Host Closed The Connection");

                    soc.BeginAccept(new AsyncCallback(Asynchronous_Accept), soc);
                }

                soc.BeginReceive(so.Receivebuffer, 0, so.Receivebuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Receive), so);
                ReceiveDone.Set();
            }
            catch (Exception ex)
            {
                logger(ex.Message);

                Connect_Result = false;

                if (Read != 0)
                {
                    soc.Shutdown(SocketShutdown.Both);
                    soc.Close();

                    Connect_Result = false;
                }
                else
                {
                    Server.Close();

                    Connect_Result = false;
                }

                IPEndPoint = new IPEndPoint(Server_IP, Server_Port);
                //ServerSocket = new TcpListener(IPEndPoint);

                // Create a TCP/IP socket.
                Server = new Socket(Server_IP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                Server.Bind(IPEndPoint);
                Server.Listen(100);

                logger("Start With Server Wait For Client Connection");

                Server.BeginAccept(new AsyncCallback(Asynchronous_Accept), Server);
                ConnectDone.WaitOne(1);
            }
        }

        private void Asynchronous_Send(IAsyncResult ar)
        {
            Socket soc = null;
            try
            {
                // Retrieve the socket from the state object.
                soc = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = soc.EndSend(ar);
                SendDone.Set();

            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }
        }

        private void logger(string msg)
        {
            StatusText.Invoke(new MethodInvoker(delegate { StatusText.AppendText(msg + "\r\n"); }));
        }

        private void Sent_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (Connect_Result)
                {


                    if (SentText.Checked || SentHex.Checked)
                    {
                        string data = SentTexBox.Text;

                        if (SentHex.Checked)
                        {
                            byte[] ba = Encoding.Default.GetBytes(data);
                            StateObject.Sendbuffer = ba;

                            Client.BeginSend(StateObject.Sendbuffer, 0, StateObject.Sendbuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Send), Client);
                            SendDone.WaitOne(1);
                        }
                        else
                        {

                            StateObject.Sendbuffer = Encoding.ASCII.GetBytes(data);
                            Client.BeginSend(StateObject.Sendbuffer, 0, StateObject.Sendbuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Send), Client);
                            SendDone.WaitOne(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select sent data type Text or Hex", "error message");
                    }

                }
            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }
            
        }

        private void SentClear_btn_Click(object sender, EventArgs e)
        {
            SentTexBox.Clear();
        }

        private void ReceiveClear_btn_Click(object sender, EventArgs e)
        {
            ReceiveTextBox.Clear();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
