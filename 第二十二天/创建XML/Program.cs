using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace 创建XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);

            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "水浒传";
            book1.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            book1.AppendChild(price1);

            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "好看";
            book1.AppendChild(des1);

            doc.Save("Doc.xml");
            Console.WriteLine("保存成功");
        }
    }
}
