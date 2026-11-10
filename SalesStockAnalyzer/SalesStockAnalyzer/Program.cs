using SalesStockAnalyzer.Controller;
using SalesStockAnalyzer.Handlers;
using SalesStockAnalyzer.Presentation;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

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

            var catalog = new AssemblyCatalog(typeof(ReportController).Assembly);

            using var container = new CompositionContainer(catalog);

            var reportController = new ReportController();

            container.ComposeParts(reportController);

            Menu.Show();

            reportController.ShowReport(products);
        }
    }
}