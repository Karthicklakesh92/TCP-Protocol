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


namespace Tcp_Clinent_Program
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

        IPAddress Server_IP = null;
        System.Int32 Server_Port = 0;

        /*Client IP Address*/
        IPAddress ClientIP = null;

        /*Server Port Number*/
        System.Int32 ClientPort = 0;

        /*TCP client Socket*/
        TcpClient ClientSocket = null;

        /*ClientIPEndPoint*/
        IPEndPoint ClientIPEndPoint = null;

        /*State Object*/
        State StateObject = null;

        /*Connection Status*/
        bool Connect_Result = false;

        /*Client Socket Receive Data*/
        string ReceiveData = string.Empty;

        /*Connection Text Change*/
        string ConnectionSatuaTextChange = string.Empty;

        string ConnectButtonTextChange = string.Empty;

        /* FORE COLOR ON CONNECTION STATUS BUTTON */
        System.Drawing.Color ConnectionStatusColorChange = System.Drawing.Color.OrangeRed;

        // State object for receiving data from remote device.
        public class State
        {
            public IPAddress Server_IPAddress = null;
            public System.Int32 Server_Port = 0;
            public Socket workSocket = null;
            public byte[] Sendbuffer = new byte[1024];
            public byte[] Receivebuffer = new byte[1024];
        }

        // ManualResetEvent instances signal completion.
        private static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static ManualResetEvent SendDone = new ManualResetEvent(false);
        private static ManualResetEvent ReceiveDone = new ManualResetEvent(false);

        /* DELEGATE FOR METHOD STRING ARGUMENT WITH VOID RETURN TYPE */
        delegate void StringArgReturningVoidDelegate(string text);

        /* DELEGATE FOR METHOD COLOR ARGUMENT WITH VOID RETURN TYPE */
        delegate void ColorArgReturningVoidDelegate(System.Drawing.Color colour);

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
            try
            {
                InitializeComponent();

                string hostName = Dns.GetHostName();

                IPHostEntry ipEntry = Dns.GetHostByName(hostName);
                IPAddress[] addr = ipEntry.AddressList;

                for (int i = 0; i < addr.Length; i++)
                {
                    Client_IP_Combo.Items.Insert(0, addr[i].ToString());
                }


              
                
               
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClientConnect();

            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }

        }
        private void TcpClientConnect()
        {
            try
            {
                if (!Connect_Result & Connect_Btn.Text == "Connect")
                {
                    ClientIP = IPAddress.Parse(Client_IP_Combo.Text);
                    ClientPort = int.Parse(Client_Port_Text.Text);

                    Server_IP = IPAddress.Parse(Server_IP_Text.Text);
                    Server_Port = int.Parse(Server_Port_Text.Text);

                    ClientIPEndPoint = new IPEndPoint(ClientIP, ClientPort);
                    ClientSocket = new TcpClient(ClientIPEndPoint);

                    //* SETTING TCP KEEP ALIVE */
                    Setting_Tcp_KeepAlive(ClientSocket.Client);

                    StateObject = new State();
                    if (StateObject == null)
                    {
                        logger("StateObject Create Not Successfully");
                    }
                    else
                    {
                        logger("StateObject Create Successfully");
                        StateObject.Server_IPAddress = Server_IP;
                        StateObject.Server_Port = Server_Port;
                        StateObject.workSocket = ClientSocket.Client;
                    }
                  
                    ClientSocket.Client.BeginConnect(Server_IP, Server_Port, new AsyncCallback(Asynchronous_Connect), StateObject);
                    ConnectDone.WaitOne(1);
                }
                else if (Connect_Btn.Text == "Disconnected")
                {
                    if (ClientSocket != null)
                    {
                        ClientSocket.Close();
                        Connect_Result = false;

                        Connect_Btn.Text = "Connect";
                        Connect_Btn.Invoke(new MethodInvoker(delegate { Connect_Btn.Text = "Connect"; }));
                        Connection_Status_btn.ForeColor = Color.Red;
                        Connection_Status_btn.Text = "Disconnected";
                    }
                }
            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }
        }
        private void Asynchronous_Connect(IAsyncResult ar)
        {
            State so = null;
            Socket soc = null;

            try
            {
                so = (State)ar.AsyncState;
                soc = so.workSocket;

                // Complete the connection.
                soc.EndConnect(ar);

                // Signal that the connection has been made.
                Connect_Result = ConnectDone.Set();

                if (Connect_Result)
                {

                    ConnectionStatusColorChange = Color.Lime;
                    Thread MyThread1 = new Thread(new ThreadStart(ThreadProcSafe1));
                    MyThread1.Start();

                    ConnectionSatuaTextChange = "Connected";
                    Thread MyThread2 = new Thread(new ThreadStart(ThreadProcSafe2));
                    MyThread2.Start();

                    ConnectButtonTextChange = "Disconnected";
                    Thread MyThread3 = new Thread(new ThreadStart(ThreadProcSafe3));
                    MyThread3.Start();

                    logger("Client Connected With Server");

                    ClientSocket.Client.BeginReceive(so.Receivebuffer, 0, so.Receivebuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Receive), so);
                    ReceiveDone.WaitOne();
                }
                else
                {
                    Connect_Result = false;

                    ConnectionStatusColorChange = Color.Red;
                    Thread MyThread4 = new Thread(new ThreadStart(ThreadProcSafe1));
                    MyThread4.Start();

                    ConnectionSatuaTextChange = "Connecting...";
                    Thread MyThread5 = new Thread(new ThreadStart(ThreadProcSafe2));
                    MyThread5.Start();

                    logger("Client Connecting With Server...");

                    soc.BeginConnect(Server_IP, Server_Port, new AsyncCallback(Asynchronous_Connect), so);
                    ConnectDone.WaitOne();

                }
            }
            catch (Exception ex)
            {
                logger(ex.Message);

                Connect_Result = false;

                ConnectionStatusColorChange = Color.Red;
                Thread MyThread4 = new Thread(new ThreadStart(ThreadProcSafe1));
                MyThread4.Start();

                ConnectionSatuaTextChange = "Connecting...";
                Thread MyThread5 = new Thread(new ThreadStart(ThreadProcSafe2));
                MyThread5.Start();

                logger("Client Connecting With Server... ");

                soc.BeginConnect(Server_IP, Server_Port, new AsyncCallback(Asynchronous_Connect), so);
                ConnectDone.WaitOne();
            }
        }

        private void Asynchronous_Receive(IAsyncResult ar)
        {
            State so = null;
            Socket soc = null;
            int Read = 0;

            try
            {
                so = (State)ar.AsyncState;
                soc = so.workSocket;

                Read = soc.EndReceive(ar);

                if (Read != 0)
                {
                    if (ReceiveHexSelect.Checked || ReceiveTextSelect.Checked)
                    {
                        if (ReceiveHexSelect.Checked)
                        {
                            ReceiveData = BitConverter.ToString(so.Receivebuffer, 0, Read);

                            ReceiveText.Invoke(new MethodInvoker(delegate { ReceiveText.AppendText(ReceiveData + "\r\n"); }));
                        }
                        if (ReceiveTextSelect.Checked)
                        {

                            ReceiveData = Encoding.UTF8.GetString(so.Receivebuffer, 0, Read);

                            ReceiveText.Invoke(new MethodInvoker(delegate { ReceiveText.AppendText(ReceiveData + "\r\n"); }));
                        }
                    }
                    
                }
                if (Read == 0)
                {
                    //Closing Socket
                    //soc.Shutdown(SocketShutdown.Both);
                    //soc.Close();

                    Connect_Result = false;

                    logger("A Remote Host Closed The Connection");

                    ConnectionStatusColorChange = Color.Red;
                    Thread MyThread1 = new Thread(new ThreadStart(ThreadProcSafe1));
                    MyThread1.Start();

                    ConnectionSatuaTextChange = "Disconnected";
                    Thread MyThread2 = new Thread(new ThreadStart(ThreadProcSafe2));
                    MyThread2.Start();

                }
                // Get the rest of the data.
                soc.BeginReceive(so.Receivebuffer, 0, so.Receivebuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Receive), so);
                ReceiveDone.Set();
            }
            catch (Exception ex)
            {
                logger(ex.Message);

                Connect_Result = false;

                ConnectionStatusColorChange = Color.Red;
                Thread MyThread1 = new Thread(new ThreadStart(ThreadProcSafe1));
                MyThread1.Start();

                ConnectionSatuaTextChange = "Disconnected";
                Thread MyThread2 = new Thread(new ThreadStart(ThreadProcSafe2));
                MyThread2.Start();

                if (Read != 0)
                {
                    soc.Shutdown(SocketShutdown.Both);
                    soc.Close();

                    Connect_Result = false;
                }
                else
                {
                    ClientSocket.Close();

                    Connect_Result = false;
                }

                /* CREATING TCP CLIENT */
                ClientIPEndPoint = new IPEndPoint(ClientIP, ClientPort);

                ClientSocket = new TcpClient(ClientIPEndPoint);

                ClientIPEndPoint = new IPEndPoint(Server_IP, Server_Port); ;


                //* SETTING TCP KEEP ALIVE */
                Setting_Tcp_KeepAlive(ClientSocket.Client);

                /* CREATING STATE OBJECT */
                StateObject = new State();
                if (StateObject == null)
                {
                    logger("StateObject Create Not Successfully");
                }
                else
                {
                    logger("StateObject Create Successfully");
                    StateObject.Server_IPAddress = Server_IP;
                    StateObject.Server_Port = Server_Port;
                    StateObject.workSocket = ClientSocket.Client;
                }
                ConnectionStatusColorChange = Color.Red;
                Thread MyThread3 = new Thread(new ThreadStart(ThreadProcSafe1));
                MyThread3.Start();

                ConnectionSatuaTextChange = "Connecting...";
                Thread MyThread4 = new Thread(new ThreadStart(ThreadProcSafe2));
                MyThread4.Start();

                logger("Client Connecting With Server...");

                ClientSocket.Client.BeginConnect(ClientIPEndPoint, new AsyncCallback(Asynchronous_Connect), StateObject);
                ConnectDone.WaitOne();
            }
        }

        private void ThreadProcSafe1()
        {            
            this.SetColor_On_ConnectionStatusColorChangeButton(ConnectionStatusColorChange);
        }

        private void ThreadProcSafe2()
        {
            this.SetText_On_ConnectionStatus(ConnectionSatuaTextChange);
        }

        private void ThreadProcSafe3()
        {
            this.SetText_On_ConnectButton(ConnectButtonTextChange);
        }

        private void SetText_On_ConnectionStatus(string text)
        {

            if (this.Connection_Status_btn.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText_On_ConnectionStatus);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Connection_Status_btn.Text = text;
            }
        }


        private void SetText_On_ConnectButton(string text)
        {

            if (this.Connect_Btn.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText_On_ConnectButton);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Connect_Btn.Text = text;
            }
        }

        /* METHOD TO UPDATE FORE COLOR IN SCAN STATUS LABEL FROM OTHER THREADS */
        private void SetColor_On_ConnectionStatusColorChangeButton(System.Drawing.Color Color)
        {
            try
            {
                if (this.Connection_Status_btn.InvokeRequired)
                {
                    ColorArgReturningVoidDelegate d = new ColorArgReturningVoidDelegate(SetColor_On_ConnectionStatusColorChangeButton);
                    this.Invoke(d, new object[] { Color });
                }
                else
                {
                    Connection_Status_btn.ForeColor = Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client_Port_Text.Text = "1026";
            Server_Port_Text.Text = "1025";       
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (Connect_Result)
                {
                    string data = SendText.Text;
                    if (SendTextSelect.Checked || SendHexSelect.Checked)
                    {
                        if (SendTextSelect.Checked)
                        {
                            StateObject.Sendbuffer = System.Text.Encoding.ASCII.GetBytes(data);
                            ClientSocket.Client.BeginSend(StateObject.Sendbuffer, 0, StateObject.Sendbuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Send), StateObject);
                            SendDone.WaitOne(1);
                        }
                        else
                        {
                            byte[] SendData = Encoding.Default.GetBytes(data);

                            StateObject.Sendbuffer = SendData;
                            ClientSocket.Client.BeginSend(StateObject.Sendbuffer, 0, StateObject.Sendbuffer.Length, SocketFlags.None, new AsyncCallback(Asynchronous_Send), StateObject);
                            SendDone.WaitOne(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select sent data type Text or Hex","error message");

                    }
                }
            }
            catch(Exception ex)
            {
                logger(ex.Message);
            }
        }
        private void Asynchronous_Send(IAsyncResult ar)
        {
            State so;
            Socket soc;
            try
            {
                so = (State)ar.AsyncState;
                soc = so.workSocket;
                int write = soc.EndSend(ar);
                SendDone.Set();
            }
            catch (Exception ex)
            {
                logger(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendText.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReceiveText.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ClientSocket != null)
            {
                ClientSocket.Close();
            }
            Application.Exit();    
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClientSocket != null)
            {
                ClientSocket.Close();
            }
        }

        private void ReceiveText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceiveTextSelect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Client_IP_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server_IP_Text.Text = Client_IP_Combo.Text;
            ClientIP = IPAddress.Parse(Server_IP_Text.Text);
        }
    }
}
