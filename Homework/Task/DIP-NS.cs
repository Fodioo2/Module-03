using System;
using System.Collections.Generic;

public interface INotifier
{
    void Send(string message);
}

public class EmailSender : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("Email: " + message);
    }
}

public class SmsSender : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine("SMS: " + message);
    }
}

public class NotificationService
{
    private List<INotifier> notifiers;

    public NotificationService(List<INotifier> notifiers)
    {
        this.notifiers = notifiers;
    }

    public void NotifyAll(string message)
    {
        foreach (var notifier in notifiers)
        {
            notifier.Send(message);
        }
    }
}
