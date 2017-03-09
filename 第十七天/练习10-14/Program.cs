using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习10_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("请输入一个数字");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    bool b = IsPrime(n);
            //    Console.WriteLine(b);
            //}
            int sum = GetPrimeSum();
            Console.WriteLine(sum);
        }

        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
