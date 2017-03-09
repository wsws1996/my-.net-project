using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 为什么要使用委托
{
    public delegate string DelProStr(string name);
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "abCDefG", "HUtgfg", "GDGDDfgegfhGDGD" };
            //ProcessStrToUpper(names);
            //ProcessStrToLower(names);
            //ProcessStrSYH(names);
            ProStr(names, delegate (string name)
            {
                return "\"" + name + "\"";
            }
                );
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public static void ProStr(string[] name, DelProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }

        //public static string StrToUpper(string name)
        //{
        //    return name.ToUpper();
        //}

        //public static string StrToLower(string name)
        //{
        //    return name.ToLower();
        //}

        //public static string StrSYH(string name)
        //{
        //    return "\"" + name + "\"";
        //}

        //public static void ProcessStrToUpper(string [] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToUpper();
        //    }
        //}
        //public static void ProcessStrToLower(string [] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToLower();
        //    }
        //}
        //public static void ProcessStrSYH(string [] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = "\"" + names[i] + "\"";
        //    }
        //}
    }
}
