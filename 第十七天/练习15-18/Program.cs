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
            //string[] names = { "马龙", "迈克尔乔丹", "第机密了", "题目邓肯", "布莱恩特" };
            //Console.WriteLine(GetLongest(names));
            //int[] numbers = { 1, 3, 5, 6, 8, 333 };
            //double avg = GetAvg(numbers);
            //avg = Convert.ToDouble(avg.ToString("0.00"));
            //Console.WriteLine(avg);
            //int[] nums = { 1, 3, 4, 5, 8, 10 };
            //Array.Sort(nums);
            //Array.Reverse(nums);
            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //};
            int[] nums = new int[30];
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1, 101);
            }
            double sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            double avg = sum / nums.Length;
            avg = Convert.ToDouble(avg.ToString("0.00"));
            Console.WriteLine(avg);
        }

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }

        public static string GetLongest(string[] names)
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
