using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace 外部命令接收器
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("本程序读取E:下operation.txt文件");
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
            p.StartInfo.CreateNoWindow = true;//不显示程序窗口
            p.Start();//启动程序

            DateTime d = (new FileInfo("E:\\operation.txt")).LastWriteTime;

            while (true)
            {
                Thread.Sleep(5000);
                if (!File.Exists("E:\\operation.txt"))
                {
                    continue;
                }
                DateTime n = (new FileInfo("E:\\operation.txt")).LastWriteTime;
                if (n != d)
                {
                    string str = File.ReadAllText("E:\\operation.txt");
                    if (str.Trim() == "")
                    {
                        continue;
                    }
                    string[] info = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (info[0] == "1")
                    {
                        p.StandardInput.WriteLine("rasdial 宽带连接 " + info[1] + " " + info[2]);
                    }
                    else if (info[0] == "0")
                    {
                        p.StandardInput.WriteLine("rasdial 宽带连接 /disconnect");
                    }
                    else
                    {
                        File.WriteAllText("E:\\error.txt", DateTime.Now + "输入格式非法");
                    }
                    File.Delete("E:\\operation.txt");
                }
            }
        }
    }
}
