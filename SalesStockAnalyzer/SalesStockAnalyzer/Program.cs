using Microsoft.Extensions.Configuration;
using SalesStockAnalyzer.Handlers;

namespace SalesStockAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder();
            //builder.AddJsonFile("AppSettings.json");
            //var configuration = builder.Build();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("AppSettings.json")
                .Build();

            string filePath = configuration["AppConfig:XmlFilePath"];

            var xmlReader = new XmlHandler();
            var xml = xmlReader.ReadXml(filePath);

            Console.WriteLine(xml);
        }
    }
}