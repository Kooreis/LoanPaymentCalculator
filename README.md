# Python Documentation

# Loan Payment Calculator

This Python script is a simple loan payment calculator. It calculates the monthly payment for a loan given the loan amount, annual interest rate, and loan duration in years.

## How it Works

The script prompts the user to input the loan amount, annual interest rate, and loan duration in years. It then calculates the monthly payment using the formula for an annuity:

```
payment = (principal * rate_of_interest * (1 + rate_of_interest) ** months) / ((1 + rate_of_interest) ** months - 1)
```

The script then prints the monthly payment.

## Libraries Used

This script does not use any imported libraries. It only uses built-in Python functions.

## Usage

To use this script, simply run it in a Python environment. You will be prompted to enter the loan amount, annual interest rate, and loan duration in years. The script will then calculate and print the monthly payment.

## Example

Here is an example of how to use the script:

```
Enter the loan amount: 100000
Enter the annual interest rate (in %): 5
Enter the loan duration (in years): 30
Your monthly payment will be: $536.82
```

In this example, the loan amount is $100,000, the annual interest rate is 5%, and the loan duration is 30 years. The script calculates the monthly payment to be $536.82.

---

# C# Documentation

# Loan Calculator in C#

This C# script is a simple loan calculator. It takes in three inputs from the user: the loan amount, the annual interest rate (APR), and the loan length in years. It then calculates the monthly payment, the total amount paid over the life of the loan, and the total interest paid over the life of the loan. The results are then displayed to the user.

## Code Explanation

The script begins by declaring several variables that will be used to store the user's inputs and the results of the calculations.

The `Console.Write` method is used to prompt the user for the loan amount, annual interest rate, and loan length. The `Convert.ToDouble` method is used to convert the user's input from a string to a double.

The monthly interest rate and the number of payments are then calculated based on the user's inputs.

The monthly payment, total amount paid, and total interest paid are then calculated using the formulas for these values.

Finally, the results are displayed to the user using the `Console.WriteLine` method. The `Math.Round` method is used to round the results to two decimal places.

## Imported Libraries

The script uses the `System` namespace, which provides fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for console input/output and mathematical operations.

## Usage

To use this script, simply run it in a C# environment, such as Visual Studio. When prompted, enter the loan amount, annual interest rate, and loan length. The script will then display the monthly payment, total amount paid, and total interest paid.

---

# Java Documentation

# Loan Payment Calculator

This is a simple Java program that calculates the monthly payment for a loan based on the loan amount, term (in years), and interest rate.

## How it works

The program prompts the user to input the loan amount, term (in years), and interest rate. It then calculates the monthly payment using the formula:

```
monthlyPayment = (loanAmount*monthlyRate) / (1-Math.pow(1+monthlyRate, -termInMonths));
```

The result is then displayed to the user.

## Imported Libraries

The program uses the following Java libraries:

- `java.util.Scanner`: This library is used to read the user's input from the console. In this program, it is used to read the loan amount, term, and interest rate.

## Usage

To use the program, simply run it and follow the prompts in the console. You will be asked to enter the loan amount, term (in years), and interest rate. After entering these values, the program will calculate and display the monthly payment.

## Example

Here is an example of how to use the program:

```
Enter loan amount: 10000
Enter loan term (in years): 5
Enter interest rate: 5
Monthly payment: 188.71
```

In this example, the user has a loan of $10,000 with a term of 5 years and an interest rate of 5%. The program calculates that the monthly payment for this loan would be $188.71.

---
