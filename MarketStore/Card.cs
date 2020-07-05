namespace MarketStore
{
    public abstract class Card
    {
        internal int turnover;
        internal int purchaseValue;

        public Card(int turnover, int purchaseValue)
        {
            this.turnover = turnover;
            this.purchaseValue = purchaseValue;
        }

        public abstract string CalculateDiscount();
    }
}
