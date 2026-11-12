namespace SalesStockAnalyzer.Presentation
{
    public class Menu
    {
        public static int Show()
        {
            Console.WriteLine("Type the desire option: \n");
            Console.WriteLine("1 - Quantity of products in stock");
            Console.WriteLine("2 - Total sales value of products in stock");
            Console.WriteLine("3 - Best-selling product");
            Console.WriteLine("4 - Most profitable product");
            Console.WriteLine("5 - Products that have not been sold");
            Console.WriteLine("6 - Out-of-stock products");
            Console.WriteLine("7 - Execute all options");
            Console.WriteLine("8 - Exit");

            Console.Write("\nOption: ");

            if (!int.TryParse(Console.ReadLine(), out int option))
            {
                throw new InvalidOperationException("Option must be a number.");
            }

            return option;
        }
    }
}