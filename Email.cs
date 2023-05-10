public class Email : ISender
{
    public void Send(object? sender, OrderEventArgs args)
    {
        Console.WriteLine($"Send an email with order id: {args.Id}");
    }
}