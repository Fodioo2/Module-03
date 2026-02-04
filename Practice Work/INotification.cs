using System;

public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Email: " + message);
    }
}

public class SmsNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("SMS: " + message);
    }
}
