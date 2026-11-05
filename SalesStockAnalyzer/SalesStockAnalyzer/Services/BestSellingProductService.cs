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

            Console.WriteLine($"\nBest-selling product: {bestProduct.Name}");
            Console.WriteLine($"Quantity sold: {bestProduct.SalesInfo?.SoldQuantity}");
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
