using SalesStockAnalyzer.Handlers;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var configurationHandler = new ConfigurationHandler();

            string filePath = configurationHandler.GetXmlFilePath();

            var xmlReader = new XmlReaderHandler();
            var xml = xmlReader.ReadXml(filePath);

            Console.WriteLine(xml);

            var xmlManipulator = new XmlManipulatorHandler();

            var products = xmlManipulator.GetProducts(xml);

            foreach (var product in products.Products)
            {
                Console.WriteLine();
                Console.WriteLine(product.Name);
            }
        }
    }
}