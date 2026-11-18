using SalesStockAnalyzer.Controller;
using SalesStockAnalyzer.Enums;
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

            string filePath = configurationHandler.GetXmlFilePath();

            var xml = xmlReader.ReadXml(filePath);

            var products = xmlManipulator.GetProducts(xml);

            var catalog = new AssemblyCatalog(typeof(ReportController).Assembly);

            using var container = new CompositionContainer(catalog);

            var reportController = new ReportController();

            container.ComposeParts(reportController);

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();

                int option = Menu.Show();

                if (!Enum.IsDefined(typeof(MenuOptionsEnum), option))
                {
                    Console.Clear();

                    Console.WriteLine("Invalid option. Please try again.\n");
                    Console.WriteLine("Press any key to return to the menu...");

                    Console.ReadKey();

                    continue;
                }

                if (option == (int)MenuOptionsEnum.Exit)
                {
                    Console.Clear();

                    Console.WriteLine("Exiting application...");

                    isRunning = false;

                    continue;
                }

                Console.Clear();

                reportController.ShowReport(products, option);

                Console.WriteLine("\nPress any key to return to the menu...");

                Console.ReadKey();
            }
        }
    }
}