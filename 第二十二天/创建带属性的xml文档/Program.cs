using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 创建带属性的xml文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerXml = "<p>aaa</p>";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "100001";
            order.AppendChild(customerNumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            orderItem1.SetAttribute("Name", "树");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);

            doc.Save("Order.xml");
            Console.WriteLine("success");
        }
    }
}
