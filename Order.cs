public class Order {
    public event EventHandler<OrderEventArgs> OnCreated = delegate{};

    public void Create() {
        Console.WriteLine("Order created");
        OnCreated(this, new OrderEventArgs(1));
    }
}