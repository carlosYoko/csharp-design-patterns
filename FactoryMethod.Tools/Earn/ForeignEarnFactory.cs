namespace FactoryMethod.Tools.Earn
{
    public class ForeignEarnFactory : EarnFactory
    {
        private decimal _percentage;
        private decimal _extraTax;

        public ForeignEarnFactory(decimal percentage, decimal extraTax)
        {
            _percentage = percentage;
            _extraTax = extraTax;
        }
        public override IEarn GetEarn()
        {
            return new ForeignEarn(_percentage, _extraTax);
        }
    }
}
