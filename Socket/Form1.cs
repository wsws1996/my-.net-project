using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Socket学习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            socketWatch.Bind(point);
            ShowMsg("监听成功");
            socketWatch.Listen(3);

            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketWatch);

        }

        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                Socket socketSend = socketWatch.Accept();
                ShowMsg(socketSend.RemoteEndPoint.ToString() + "连接成功");
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
        }

        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int r = socketSend.Receive(buffer);
                string str = Encoding.UTF8.GetString(buffer, 0, r);
                ShowMsg(socketSend.RemoteEndPoint + ":" + str);
            }
        }
        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
