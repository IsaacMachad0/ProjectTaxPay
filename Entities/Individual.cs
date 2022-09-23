namespace ExerciseTaxPay.Entities
{
    public class Individual : TaxPayer
    {
        public double Health { get; set; }

        public override double PayTax()
        {
            double sum = 0;
            sum = Health == 0? sum = 0 : sum = (Health / 2);
            
            return AnnualIncome < 20000? AnnualIncome * 0.15 - sum : AnnualIncome * 0.25 - sum;
        }
    }
}