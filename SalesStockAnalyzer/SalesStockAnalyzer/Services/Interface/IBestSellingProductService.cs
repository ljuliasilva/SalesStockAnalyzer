using SalesStockAnalyzer.Models;

namespace SalesStockAnalyzer.Services.Interface
{
    public interface IBestSellingProductService
    {
        void ShowBestSellingProduct(ProductsModel products);
    }
}
