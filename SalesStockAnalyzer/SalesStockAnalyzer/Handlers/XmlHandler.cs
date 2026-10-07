using System.Xml.Linq;

namespace SalesStockAnalyzer.Handlers
{
    public class XmlHandler
    {
        public XDocument ReadXml(string filePath)
        {
            var xml = XDocument.Load(filePath);

            return xml;
        }
    }
}