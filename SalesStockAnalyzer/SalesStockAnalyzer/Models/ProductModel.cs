namespace SalesStockAnalyzer.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public DetailsModel ?Details { get; set; }
        public SalesInformationModel ?SalesInfo { get; set; }
        public DateTime ModificationDate { get; set; }

        public string ToString(string serviceName)
        {
            return $"""
                === {serviceName} ===
                ID: {Id}
                Name: {Name}
                Description: {Details?.Description}
                Price: {Details?.Price:C}
                In Stock Quantity: {SalesInfo?.InStockQuantity}
                Sold Quantity: {SalesInfo?.SoldQuantity}
                Modification Date: {ModificationDate:yyyy-MM-dd HH:mm:ss}
                """;
        }
        public override string ToString()
        {
            return ToString("Product");
        }
    }
}