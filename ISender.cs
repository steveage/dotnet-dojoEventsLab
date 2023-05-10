public interface ISender {
    void Send(object? sender, OrderEventArgs args);
}