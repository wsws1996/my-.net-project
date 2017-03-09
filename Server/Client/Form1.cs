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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socketSend;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                socketSend.Connect(point);
                ShowMsg("连接成功");
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start();
            }
            catch { }
        }

        void Recive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    int n = buffer[0];
                    if (n == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint + ":" + s);
                    }
                    else if (n == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Title = "请选择要保存的位置";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.Create, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");
                    }
                    else if (n == 2)
                    {
                        ZD();
                    }
                }
            }
            catch { }
        }

        void ZD()
        {
            Point oldLocation = this.Location;
            for (int i = 0; i < 5000; i++)
            {
                this.Location = new Point(oldLocation.X - 2, oldLocation.Y - 2);
                this.Location = new Point(oldLocation.X + 2, oldLocation.Y + 2);
            }
            this.Location = oldLocation;
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMsg.Text.Trim();
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                socketSend.Send(buffer);
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
