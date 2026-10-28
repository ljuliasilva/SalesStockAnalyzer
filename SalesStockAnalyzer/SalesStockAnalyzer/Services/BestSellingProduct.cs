using SalesStockAnalyzer.Models;

namespace SalesStockAnalyzer.Services
{
    public class BestSellingProduct
    {
        public ProductModel GetBestSellingProduct(ProductsModel product)
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
