def loan_payment_calculator():
    principal = float(input("Enter the loan amount: "))
    rate_of_interest = float(input("Enter the annual interest rate (in %): "))
    years = int(input("Enter the loan duration (in years): "))

    rate_of_interest = rate_of_interest / 100 / 12
    months = years * 12

    payment = (principal * rate_of_interest * (1 + rate_of_interest) ** months) / ((1 + rate_of_interest) ** months - 1)

    print("Your monthly payment will be: $%.2f" % payment)

loan_payment_calculator()