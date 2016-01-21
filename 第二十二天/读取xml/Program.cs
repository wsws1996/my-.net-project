using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 读取xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Books.xml");

            //XmlElement books= doc.DocumentElement;

            //XmlNodeList xnl= books.ChildNodes;
            //foreach (XmlNode item in xnl)
            //{
            //    foreach (XmlNode i in item)
            //    {
            //        Console.WriteLine(i.InnerText);
            //    }
            //}
            //Console.ReadKey();
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNodeList xnl= doc.SelectNodes("/Order/Items/OrderItem");
            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Count"].Value);
            //}

            XmlDocument doc = new XmlDocument();
            doc.Load("Order.xml");
            //XmlNode xn = doc.SelectSingleNode("/Order/Items/OrderItem[@Name='树']");
            //xn.Attributes["Count"].Value = "234";
            //xn.Attributes["Name"].Value = "190";
            //doc.Save("Order.xml");
            //Console.WriteLine("保存成功");

            //XmlElement order = doc.DocumentElement;
            //XmlNodeList xnl = order.ChildNodes;
            //foreach (XmlNode item in xnl)
            //{
            //    if (item.Name!= "Items")
            //    {
            //        continue;
            //    }
            //    foreach (XmlNode i in item)
            //    {
            //        if (i.Name!="OrderItem")
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("name:"+i.Attributes["Name"].Value);
            //        Console.WriteLine("count:"+i.Attributes["Count"].Value);
            //    }
            //}
            XmlNode xn= doc.SelectSingleNode("/Order/Items");
            xn.RemoveAll();
            doc.Save("Order.xml");
            Console.WriteLine("删除成功");

            Console.ReadKey();

        }
    }
}
