using ExerciseTaxPay.Entities;
using System.Collections.Generic;

namespace ExerciseTaxPay
{
    class Program
    {
        public static void Main()
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"TAX PAYER #{i} DATA:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());

                    list.Add(new Individual
                    {
                        Name = name,
                        AnnualIncome = income,
                        Health = health
                    });
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());

                    list.Add(new Company
                    {
                        Name = name,
                        AnnualIncome = income,
                        Employee = emp
                    });
                }
            }
            double sum = 0;
            Console.WriteLine("\nTAXES PAID:");
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine($"{tax.Name}: {tax.PayTax():C2}");
                sum += tax.PayTax();
            }

            Console.WriteLine("\nTOTAL TAXES:");
            Console.WriteLine(sum.ToString("C2"));
        } 
    }
}
