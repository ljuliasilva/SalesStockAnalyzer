using SalesStockAnalyzer.Handlers;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\..\\..\\..\\Sales_Stock.xml";

            var xmlReader = new XmlHandler();
            var xml = xmlReader.ReadXml(filePath);

            Console.WriteLine(xml);                    
        }
    }
}