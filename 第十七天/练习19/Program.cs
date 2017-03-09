using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习19
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "规范化个咳嗽规范化个韩国队和规划法规和奋咳嗽斗和发货的地方和高咳嗽房价的非官咳嗽方涣发咳嗽大号韩咳嗽国队和奋斗收咳嗽费的规范发的噶发个";
            //int i = 0;
            //int index = str.IndexOf("咳嗽");
            //i++;
            //Console.WriteLine(index);
            //while (index != -1)
            //{
            //    index = str.IndexOf("咳嗽", index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    i++;
            //    Console.WriteLine(index);
            //}
            //Console.WriteLine("共" + i + "个");
            //string s = "hello              world,你   好     世界";
            //s = s.Trim();
            //string[] sNew = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //s = string.Join(" ", sNew);
            //Console.WriteLine(s);
            //    List<string> list = new List<string>();
            //    while (true)
            //    {
            //        Console.WriteLine("请输入学员姓名，输入quit退出");
            //        string name = Console.ReadLine();
            //        if (name.ToLower() == "quit")
            //        {
            //            break;
            //        }
            //        list.Add(name);
            //    }
            //    Console.WriteLine("list.Count:" + list.Count);
            //    int i = 0;
            //    foreach (string item in list)
            //    {
            //        if (item[0]=='王')
            //        {
            //            i++;
            //            Console.WriteLine(item);
            //        }
            //    }
            //    Console.WriteLine(i);
            //string[] names = { "中国", "每个", "内容", "zcf" };
            //Array.Reverse(names);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
public class Person
{
    public string Name
    {
        get;
        set;
    }

    public char Gender
    {
        get;
        set;
    }
    public int Age
    {
        get;
        set;
    }
    public virtual void SayHi()
    {
        Console.WriteLine("父类");
    }
}

public class Employee:Person
{
    public double Salary
    {
        get;
        set;
    }
    public override void SayHi()
    {
        Console.WriteLine("子类重写");
    }
}