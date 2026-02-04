using System;
using System.Diagnostics;
namespace User
{
    public class Order
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

    }

    public class TPC
    {
        public double CalculateTotalPrice(Order order)
        {
            // Рассчет стоимости с учетом скидок
            return order.Quantity * order.Price * 0.9;
        }
    }
    public class PP
    {
        public void ProcessPayment(string paymentDetails)
        {
            // Логика обработки платежа
            Console.WriteLine("Payment processed using: " + paymentDetails);
        }
    }
    public class SFE
    {
        public void SendConfirmationEmail(string email)
        {
            // Логика отправки уведомления
            Console.WriteLine("Confirmation email sent to: " + email);
        }
    }
}