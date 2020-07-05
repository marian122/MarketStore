using System.Text;

namespace MarketStore
{
    public class SilverCard : Card
    {
        private const double initialDiscountRate = 2;
        private const double above300DiscountRate = 3.5;

        public SilverCard(int turnover, int purchaseValue)
            : base(turnover, purchaseValue)
        {

        }

        public override string CalculateDiscount()
        {
            var output = new StringBuilder();

            output.AppendLine($"Silver");
            output.AppendLine();

            output.AppendLine($"Purchase value: ${this.purchaseValue:f2}");

            if (turnover < 300)
            {
                var discount = this.purchaseValue * (initialDiscountRate / 100);
                var total = this.purchaseValue - (this.purchaseValue * (initialDiscountRate / 100));


                output.AppendLine($"Discount rate: {initialDiscountRate}%");
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
