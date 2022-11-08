```CSharp
using System;

class Program
{
    static void Main(string[] args)
    {
        double loanAmount, annualInterestRate, monthlyInterestRate, loanLength, numberOfPayments, monthlyPayment, totalAmountPaid, totalInterestPaid;

        Console.Write("Enter loan amount: ");
        loanAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (APR): ");
        annualInterestRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan length in years: ");
        loanLength = Convert.ToDouble(Console.ReadLine());

        monthlyInterestRate = annualInterestRate / 1200;
        numberOfPayments = loanLength * 12;

        monthlyPayment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments));
        totalAmountPaid = monthlyPayment * numberOfPayments;
        totalInterestPaid = totalAmountPaid - loanAmount;

        Console.WriteLine("\nMonthly Payment: " + Math.Round(monthlyPayment, 2));
        Console.WriteLine("Total Amount Paid: " + Math.Round(totalAmountPaid, 2));
        Console.WriteLine("Total Interest Paid: " + Math.Round(totalInterestPaid, 2));

        Console.ReadKey();
    }
}
```