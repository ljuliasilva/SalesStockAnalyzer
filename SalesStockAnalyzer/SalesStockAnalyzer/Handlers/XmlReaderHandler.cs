using System.Xml.Linq;

namespace SalesStockAnalyzer.Handlers
{
    public class XmlReaderHandler
    {
        public XDocument ReadXml(string filePath)
        {
            var xml = XDocument.Load(filePath);

            return xml;
        }
    }
}