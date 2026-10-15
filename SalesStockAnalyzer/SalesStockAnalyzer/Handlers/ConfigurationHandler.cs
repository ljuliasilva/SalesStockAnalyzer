using Microsoft.Extensions.Configuration;

namespace SalesStockAnalyzer.Handlers
{
    public class ConfigurationHandler
    {
        public string GetXmlFilePath()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("AppSettings.json")
                .Build();

            return configuration["AppConfig:XmlFilePath"];
        }
    }
}