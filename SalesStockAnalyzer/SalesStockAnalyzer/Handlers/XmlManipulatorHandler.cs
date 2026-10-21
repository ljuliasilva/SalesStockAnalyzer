using System.Xml.Linq;
using SalesStockAnalyzer.Models;

namespace SalesStockAnalyzer.Handlers
{
    public class XmlManipulatorHandler
    {
        public ProductsModel GetProducts(XDocument xml)
        {
            ProductsModel productsModel = new ProductsModel();

            foreach (XElement node in xml.Descendants("Product"))
            {
                ProductModel product = new ProductModel();

                product.Id = int.Parse(node.Attribute("id")!.Value);

                product.Name = node.Element("Name")?.Value;

                product.Details = new DetailsModel
                {
                    Description = node.Element("Details")
                                      ?.Element("Description")
                                      ?.Value
                                      .Trim(),

                    Price = float.Parse(
                        node.Element("Details")
                            ?.Element("Price")
                            ?.Value!)
                };

                product?.SalesInfo = new SalesInformationModel
                {
                    InStockQuantity = int.Parse(
                        node.Element("SalesInformation")
                            ?.Element("InStockQuantity")
                            ?.Value!),

                    SoldQuantity = int.Parse(
                        node.Element("SalesInformation")
                            ?.Element("SoldQuantity")
                            ?.Value!)
                };

                product?.ModificationDate = DateTime.ParseExact(
                    node.Element("ModificationDate")!.Value,
                    "yyyyMMdd'T'HHmmss",
                    null);

                productsModel.Products.Add(product);
            }

            return productsModel;
        }
    }
}