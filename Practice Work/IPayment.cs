using System;

public class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid by credit card: " + amount);
    }
}

public class PayPalPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid by PayPal: " + amount);
    }
}
