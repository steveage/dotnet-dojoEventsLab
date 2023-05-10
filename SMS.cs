public class SMS : ISender
{
    public void Send(object? sender, OrderEventArgs args)
    {
        Console.WriteLine($"Send a SMS about order id: {args.Id}");
    }
}