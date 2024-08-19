namespace FactoryMethod.Tools.Earn
{
    public class ForeignEarn : IEarn
    {
        private decimal _percentage;
        private decimal _extraTax;

        public ForeignEarn(decimal percentage, decimal extraTax)
        {
            _percentage = percentage;
            _extraTax = extraTax;
        }

        public decimal Earn(decimal amount)
        {
            return (_percentage * amount) + _extraTax;
        }
    }
}
