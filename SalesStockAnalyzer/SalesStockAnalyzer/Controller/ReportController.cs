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

                default:
                    throw new InvalidOperationException("Invalid menu option.");
            }
        }
    }
}