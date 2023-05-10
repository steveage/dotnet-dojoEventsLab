public class OrderEventArgs : EventArgs {
    public int Id { get; set; }
    public OrderEventArgs(int id) => Id = id;
}