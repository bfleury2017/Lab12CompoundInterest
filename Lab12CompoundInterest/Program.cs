using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter principal amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter time in years investment: ");
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.Write("Enter number of times per year\nthe interest is compounded [2,4 or 12]: ");
            decimal rate = decimal.Parse(Console.ReadLine());


            for (int rate = 5; rate <= 10; rate++)
            {
                double interestRate = rate / 100.00;

                Console.WriteLine($"Interest Rate: {rate:F}% on amount {principal:C}");
                Console.WriteLine("Year   Amount on deposit");


                for (int year = 1; year <= 10; ++year)
                {
                    decimal amount = principal * (decimal)Math.Pow(1.0 + interestRate, year);
                    Console.WriteLine($"{year,4}{amount,20:C}");
                }
                Console.WriteLine();
            }
        }
    }
}
