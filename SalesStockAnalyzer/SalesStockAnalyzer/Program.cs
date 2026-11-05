using SalesStockAnalyzer.Controller;
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
            var reportController = new ReportController();

            string filePath = configurationHandler.GetXmlFilePath();

            var xml = xmlReader.ReadXml(filePath);                        

            var products = xmlManipulator.GetProducts(xml);

            Menu.Show();

            reportController.ShowReport(products);
        }
    }
}