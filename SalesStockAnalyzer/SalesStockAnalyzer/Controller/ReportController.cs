using SalesStockAnalyzer.Models;
using SalesStockAnalyzer.Services.Interface;
using System.ComponentModel.Composition;

namespace SalesStockAnalyzer.Controller
{
    public class ReportController
    {
        [Import]
        public IBestSellingProductService? BestSellingProduct { get; set; }

        public void ShowReport(ProductsModel products)
        {
            Console.Write("\nOption: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "3":
                    BestSellingProduct?.ShowBestSellingProduct(products);
                    break;

                default:
                    Console.WriteLine("\nOption not implemented yet.");
                    break;
            }
        }
    }
}