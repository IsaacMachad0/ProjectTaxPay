namespace ExerciseTaxPay.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public abstract double PayTax();
    }
}