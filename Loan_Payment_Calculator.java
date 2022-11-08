```java
import java.util.Scanner;

public class LoanPaymentCalculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter loan amount: ");
        double loanAmount = scanner.nextDouble();

        System.out.print("Enter loan term (in years): ");
        int termInYears = scanner.nextInt();

        System.out.print("Enter interest rate: ");
        double interestRate = scanner.nextDouble();

        double monthlyRate = interestRate / 100 / 12;
        double termInMonths = termInYears * 12;
        double monthlyPayment = (loanAmount*monthlyRate) / (1-Math.pow(1+monthlyRate, -termInMonths));

        System.out.printf("Monthly payment: %.2f\n", monthlyPayment);
    }
}
```