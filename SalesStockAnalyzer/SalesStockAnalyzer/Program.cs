using System.Xml.Linq;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Repo\\SalesStockAnalyzer\\Sales_Stock.xml";

            var xml = ReadXml(filePath);

            Console.WriteLine(xml);                    
        }
        static XDocument ReadXml(string filePath)
        {
            var xml = XDocument.Load(filePath);

            return xml;
        }
    }
}