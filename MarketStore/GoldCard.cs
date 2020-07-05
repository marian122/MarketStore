using System.Text;

namespace MarketStore
{
    public class GoldCard : Card
    {
        private const double initialDiscountRate = 2;

        public GoldCard(int turnover, int purchaseValue)
            : base(turnover, purchaseValue)
        {

        }

        public override string CalculateDiscount()
        {
            var output = new StringBuilder();

            output.AppendLine($"Gold");
            output.AppendLine();

            output.AppendLine($"Purchase value: ${this.purchaseValue}");

            var discountRate = initialDiscountRate + (turnover / 100) < 10 ? initialDiscountRate + (turnover / 100) : 10;
            var discount = this.purchaseValue * (discountRate / 100);
            var total = this.purchaseValue - (this.purchaseValue * (discountRate / 100));

            output.AppendLine($"Discount rate: {discountRate}%");
            output.AppendLine($"Discount: ${discount:f2}");
            output.AppendLine($"Total: ${total:f2}");

            output.AppendLine($"-------------------");


            return output.ToString().TrimEnd();
        }
    }
}
