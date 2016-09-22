namespace BackendModel
{
    public class Order
    {
        public virtual int OrderId { get; set; }
        public virtual string Item { get; set; }
        public virtual int Quantity { get; set; }

    }
}
