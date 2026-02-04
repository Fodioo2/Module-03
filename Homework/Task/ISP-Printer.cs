using System;

public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public interface IFaxable
{
    void Fax();
}

public class BasicPrinter : IPrintable
{
    public void Print(string content)
    {
        Console.WriteLine("printig"+ content);
    }
}

public class AdvancedPrinter : IPrintable, IScannable, IFaxable
{
    public void Print(string content)
    {
        Console.WriteLine("printig" + content);
    }

    public void Scan(string content)
    {
        Console.WriteLine("Scanning" + content);
    }

    public void Fax(string content)
    {
        Console.WriteLine("Faxing" + content);
    }
}