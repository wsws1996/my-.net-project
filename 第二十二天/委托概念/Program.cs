using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托概念
{
    public delegate void DelSayHi(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHi del = SayHiEnglish;
            //del("张三");
            Test("张三", SayHiEnglish);
        }

        public static void Test(string name, DelSayHi del)
        {
            del(name);
        }

        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了吗？" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you" + name);
        }
    }
}
