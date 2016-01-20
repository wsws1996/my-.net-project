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
            XmlDocument doc = new XmlDocument();
            doc.Load("Order.xml");
            XmlNodeList xnl= doc.SelectNodes("/Order/Items/OrderItem");
            foreach (XmlNode node in xnl)
            {
                Console.WriteLine(node.Attributes["Name"].Value);
                Console.WriteLine(node.Attributes["Count"].Value);
            }
        }
    }
}
