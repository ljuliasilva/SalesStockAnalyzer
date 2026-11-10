using SalesStockAnalyzer.Models;
using SalesStockAnalyzer.Services.Interface;
using System.ComponentModel.Composition;

namespace SalesStockAnalyzer.Services
{
    [Export(typeof(IBestSellingProductService))]
    public class BestSellingProductService : IBestSellingProductService
    {
        public void ShowBestSellingProduct(ProductsModel products)
        {
            var bestProduct = GetBestSellingProduct(products);

            Console.WriteLine("\n=== Best-selling Product ===");
            Console.WriteLine($"ID: {bestProduct.Id}");
            Console.WriteLine($"Name: {bestProduct.Name}");
            Console.WriteLine($"Description: {bestProduct.Details?.Description}");
            Console.WriteLine($"Price: {bestProduct.Details?.Price:C}");
            Console.WriteLine($"In Stock Quantity: {bestProduct.SalesInfo?.InStockQuantity}");
            Console.WriteLine($"Sold Quantity: {bestProduct.SalesInfo?.SoldQuantity}");
            Console.WriteLine($"Modification Date: {bestProduct.ModificationDate}");
        }

        private ProductModel GetBestSellingProduct(ProductsModel product)
        {
            ProductModel? bestSellingProduct = null;
            int highestSoldQuantity = 0;

            foreach (ProductModel productModel in product.Products)
            {
                int soldQuantity = productModel.SalesInfo!.SoldQuantity;
                
                if (bestSellingProduct == null || soldQuantity > highestSoldQuantity)
                {
                    highestSoldQuantity = soldQuantity;
                    bestSellingProduct = productModel;
                }
            }

            return bestSellingProduct;
        }
    }
}