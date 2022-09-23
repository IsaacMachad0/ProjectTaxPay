namespace ExerciseTaxPay.Entities
{
    public class Company : TaxPayer
    {
        public int Employee { get; set; }

        public override double PayTax()
        {
            return Employee > 10? AnnualIncome * 0.14 : AnnualIncome * 0.16;
        }
    }
}