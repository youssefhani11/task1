namespace Carpet_Cleaning_Service
{
    internal class Program
    {
        private static int largeCarpets;

        static void Main(string[] args)
        {
            int smallCarpets = int.Parse (Console.ReadLine());
            Console.WriteLine($"small carpets is :{smallCarpets}");
            int largeCarpets  = int .Parse (Console.ReadLine());
            Console.WriteLine($"large carpets is :{largeCarpets}");
            int priceSmall  = 25;
            int priceLarge = 35;

            Console.WriteLine($"price small room : $ {priceSmall}");
            Console.WriteLine($"price large room : $ {priceLarge}");

            int costsmall;
            int costlarge;
            costsmall = smallCarpets * priceSmall;
            Console.WriteLine($"cost small is {costsmall}");
            costlarge = largeCarpets * priceLarge;
            Console.WriteLine($"cost large is {costlarge}");
            int TotalCost=costsmall+costlarge;
            Console.WriteLine(TotalCost);

            Console.WriteLine(" tax : $6.6 ");
            Console.WriteLine("Total estimate: $116.6\r\nThis estimate is valid for 30 days");

            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
