using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //int[] nums = new int[50];
            //Random r = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int rNumber = r.Next(0, 10);
            //    nums[i] = rNumber;
            //}
            //Console.WriteLine("请输入一个数字");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i] + "\t");
            //    if ((i + 1) % n == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //string s = "AAAAAAABC";
            //Console.WriteLine(ProcessStr(s));
            int n1 = 10;
            int n2 = 20;
            //n1 = n1 - n2;
            //n2 = n1 + n2;
            //n1 = n2 - n1;
            Change(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }

        public static void Change(ref int n1,ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        public static string ProcessStr(string str)
        {
            string s = str.Substring(0, 1).ToLower();
            return s + str.Substring(1);
        }
        public static string GetLevel(int score)
        {
            string level = null;
            if (score >= 90)
            {
                level = "优";
            }
            else if (score >= 80)
            {
                level = "良";
            }
            else if (score >= 70)
            {
                level = "中";
            }
            else if (score >= 60)
            {
                level = "差";
            }
            else
            {
                level = "不及格";
            }
            return level;
        }
    }
}
