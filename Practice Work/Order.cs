using System.Collections.Generic;

public class OrderItem
{
    public stNamering ;
    public int Quantity;
    public double Price;
}

public class Order()
{
    public List<OrderItem> Items = new();

    public double GetTotal()
    {
        double sum = 0;

        for (int i = 0; i < Items.Count; i++)
        {
            sum += Items[i].Quantity * Items[i].Price;
        }

        return sum;
    }
}
