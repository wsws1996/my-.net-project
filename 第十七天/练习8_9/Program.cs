using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "addfs";
            //Console.WriteLine(s.Length);
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            int max = GetMax(new int[] { 1, 4, 7, 4, 2 });
            Console.WriteLine(max);
        }

        public static int GetMax(params int[] nums)
        {
            List<int> list = new List<int>();
            list.AddRange(nums);
            list.Sort();
            return list[list.Count - 1];
        }

        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
