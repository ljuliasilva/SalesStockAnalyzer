using SalesStockAnalyzer.Handlers;
using SalesStockAnalyzer.Presentation;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurationHandler = new ConfigurationHandler();
            var xmlReader = new XmlHandler();
            var xmlManipulator = new XmlHandler();
            var menu = new Menu();

            string filePath = configurationHandler.GetXmlFilePath();

            var xml = xmlReader.ReadXml(filePath);                        

            var products = xmlManipulator.GetProducts(xml);

            Menu.Show();
        }
    }
}