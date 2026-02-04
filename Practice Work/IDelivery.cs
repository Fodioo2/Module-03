using System;

public class CourierDelivery : IDelivery
{
    public void Deliver(Order order)
    {
        Console.WriteLine("Delivered by courier");
    }
}

public class PickUpDelivery : IDelivery
{
    public void Deliver(Order order)
    {
        Console.WriteLine("Picked up by customer");
    }
}
