using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习15_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "马龙", "迈克尔乔丹", "第机密了", "题目邓肯", "布莱恩特" };
            Console.WriteLine(GetLongest(names));
        }

        public static string GetLongest(string []names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > max.Length)
                {
                    max = names[i];
                }
            }
            return max;   
        }
    }
}
