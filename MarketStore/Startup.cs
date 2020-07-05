using System;

namespace MarketStore
{
    public class Startup
    {
        public static void Main()
        {
            var bronzeCard = new BronzeCard(0, 150);
            var silverCard = new SilverCard(600, 850);
            var goldCard = new GoldCard(1500, 1300);

            Console.WriteLine(bronzeCard.CalculateDiscount());
            Console.WriteLine(silverCard.CalculateDiscount());
            Console.WriteLine(goldCard.CalculateDiscount());
        }
    }
}
