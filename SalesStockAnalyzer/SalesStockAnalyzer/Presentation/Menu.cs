namespace SalesStockAnalyzer.Presentation
{
    public class Menu
    {
        public static int Show()
        {
            Console.WriteLine("========== Sales & Stock Analyzer ==========\n");
            Console.WriteLine("1 - Quantity of products in stock");
            Console.WriteLine("2 - Total sales value of products in stock");
            Console.WriteLine("3 - Best-selling product");
            Console.WriteLine("4 - Most profitable product");
            Console.WriteLine("5 - Products that have not been sold");
            Console.WriteLine("6 - Out-of-stock products");
            Console.WriteLine("7 - Execute all options");
            Console.WriteLine("8 - Exit");

            Console.Write("\nSelect an option: ");

            int.TryParse(Console.ReadLine(), out int option);

            return option;
        }
    }
}