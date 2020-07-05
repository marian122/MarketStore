using System.Text;

namespace MarketStore
{
    public class BronzeCard : Card
    {
        private const double between100And300DiscountRate = 1;
        private const double above300DiscountRate = 2.5;

        public BronzeCard(int turnover, int purchaseValue)
            : base(turnover, purchaseValue)
        {

        }

        public override string CalculateDiscount()
        {
            var output = new StringBuilder();

            output.AppendLine($"Bronze");
            output.AppendLine();

            output.AppendLine($"Purchase value: ${this.purchaseValue}");

            if (turnover < 100)
            {
                output.AppendLine($"Discount rate: 0.0%");
                output.AppendLine($"Discount: $0.0");
                output.AppendLine($"Total: ${this.purchaseValue}");
            }
            else if (turnover >= 100 && turnover < 300)
            {
                var discount = this.purchaseValue * (between100And300DiscountRate / 100);
                var total = this.purchaseValue - (this.purchaseValue * (between100And300DiscountRate / 100));

                output.AppendLine($"Discount rate: {between100And300DiscountRate}%");
                output.AppendLine($"Discount: ${discount:f2}");
                output.AppendLine($"Total: ${total:f2}");
            }
            else
            {
                var discount = this.purchaseValue * (above300DiscountRate / 100);
                var total = this.purchaseValue - (this.purchaseValue * (above300DiscountRate / 100));

                output.AppendLine($"Discount rate: {above300DiscountRate}%");
                output.AppendLine($"Discount: ${discount:f2}");
                output.AppendLine($"Total: ${total:f2}");
            }

            output.AppendLine($"-------------------");

            return output.ToString().TrimEnd();
        }
    }
}
