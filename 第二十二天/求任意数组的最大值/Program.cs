using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 求任意数组的最大值
{
    class Program
    {
        public delegate int DelCompare(object o1, object o2);
        static void Main(string[] args)
        {
            object[] o = { "afs", "dsgdfh", "hgfhfgfhf" };
            //object result = GetMax(o, Compare2);
            object result = GetMax(o, (object o1, object o2) =>
               {
                   return ((string)o1).Length - ((string)o2).Length;
               }
            );
            Console.WriteLine(result);
        }

        public static object GetMax(object[] nums, DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        //public static int Compare1(object o1, object o2)
        //{
        //    int n1 = (int)o1;
        //    int n2 = (int)o2;
        //    return n1 - n2;
        //}

        //public static int Compare2(object o1, object o2)
        //{
        //    string s1 = (string)o1;
        //    string s2 = (string)o2;
        //    return s1.Length - s2.Length;
        //}
    }
}
