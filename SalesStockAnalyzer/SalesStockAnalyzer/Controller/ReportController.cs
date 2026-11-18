using SalesStockAnalyzer.Enums;
using SalesStockAnalyzer.Models;
using SalesStockAnalyzer.Services.Interface;
using System.ComponentModel.Composition;

namespace SalesStockAnalyzer.Controller
{
    public class ReportController
    {
        [Import]
        public IBestSellingProductService? BestSellingProduct { get; set; }

        public void ShowReport(ProductsModel products, int option)
        {
            switch ((MenuOptionsEnum)option)
            {
                case MenuOptionsEnum.BestSellingProduct:
                    BestSellingProduct?.ShowBestSellingProduct(products);
                    break;

                case MenuOptionsEnum.QuantityOfProductsInStock:
                case MenuOptionsEnum.TotalSalesValueOfProductsInStock:
                case MenuOptionsEnum.MostProfitableProduct:
                case MenuOptionsEnum.ProductsThatHaveNotBeenSold:
                case MenuOptionsEnum.OutOfStockProducts:
                case MenuOptionsEnum.ExecuteAllOptions:
                    Console.WriteLine("This option is not implemented yet.");
                    break;

                default:
                    throw new InvalidOperationException("Invalid menu option.");
            }
        }
    }
}