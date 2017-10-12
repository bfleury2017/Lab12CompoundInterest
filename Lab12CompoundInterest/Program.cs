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
            decimal principal = decimal.Parse(Console.ReadLine());

            Console.Write("Enter interest rate: ");
            double interestRate = double.Parse(Console.ReadLine());

            Console.Write("Enter time in years investment: ");
            int nyears = int.Parse(Console.ReadLine());

            Console.Write("Enter number of times per year\nthe interest is compounded [2,4 or 12]: ");
            int numTimes = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (double rate = interestRate; rate <= 6.25; rate+=0.25)
            {
                Console.WriteLine($"Interest Rate: {rate:F}% on amount {principal:C}");
                Console.WriteLine("Year   Current balance");

                for (int year = 1; year <= nyears; year++)
                {
                    decimal amount = principal * (decimal)Math.Pow((1 + ((rate / 100) / numTimes)), (numTimes * year));
                    Console.WriteLine($"{year,4}{amount,20:C}");
                }

                Console.WriteLine();

            }
        }
    }
}
