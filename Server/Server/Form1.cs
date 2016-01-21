using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtStart_Click(object sender, EventArgs e)
        {
            try
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
            catch { }
        }

        Socket socketSend;
        void Listen(object o)
        {
            try
            {
                Socket socketWatch = o as Socket;
                while (true)
                {
                    socketSend = socketWatch.Accept();
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":连接成功");
                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
            }
            catch { }
        }
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        void Recive(Object o)
        {
            try
            {
                Socket socketSend = o as Socket;
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
            }
            catch { }

        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text.Trim();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            buffer = list.ToArray();
            if (cboUsers.SelectedItem == null)
            {
                MessageBox.Show("请选择您要发送的对象");
                return;
            }
            string ip = cboUsers.SelectedItem.ToString();
            dicSocket[ip].Send(buffer);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            if (path == "" | path == null)
            {
                MessageBox.Show("请选择要发送的文件");
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                List<byte> list = new List<byte>();
                int r = fsRead.Read(buffer, 0, buffer.Length);
                list.Add(1);
                list.AddRange(buffer);
                buffer = list.ToArray();
                dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer, 0, r + 1, SocketFlags.None);
            }
        }

        private void btnZD_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
        }
    }
}
