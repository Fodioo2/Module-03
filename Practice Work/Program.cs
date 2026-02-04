using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Order order = new Order();
        order.Items.Add(new OrderItem { Name = "Laptop", Quantity = 1, Price = 1000 });
        order.Items.Add(new OrderItem { Name = "Mouse", Quantity = 2, Price = 20 });

        double total = order.GetTotal();

        IPayment payment = new CreditCardPayment();
        payment.Pay(total);

        IDelivery delivery = new CourierDelivery();
        delivery.Deliver(order);

        List<INotification> notifications = new List<INotification>
        {
            new EmailNotification(),
            new SmsNotification()
        };

        for (int i = 0; i < notifications.Count; i++)
        {
            notifications[i].Send("Order confirmed!");
        }

        Console.WriteLine("Done.");
    }
}
