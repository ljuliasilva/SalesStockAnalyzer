using SalesStockAnalyzer.Handlers;
using SalesStockAnalyzer.Services;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurationHandler = new ConfigurationHandler();
            var xmlReader = new XmlHandler();
            var xmlManipulator = new XmlHandler();

            string filePath = configurationHandler.GetXmlFilePath();

            var xml = xmlReader.ReadXml(filePath);                        

            var products = xmlManipulator.GetProducts(xml);

        }
    }
}