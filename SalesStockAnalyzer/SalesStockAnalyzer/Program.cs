using Microsoft.Extensions.Configuration;
using SalesStockAnalyzer.Handlers;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurationHandler = new ConfigurationHandler();

            string filePath = configurationHandler.GetXmlFilePath();

            var xmlReader = new XmlHandler();
            var xml = xmlReader.ReadXml(filePath);

            Console.WriteLine(xml);
        }
    }
}