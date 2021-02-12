namespace Messages
{
    public class OrderRequestMessage
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return "OrderId" + this.OrderId +", CustomerId" + this.CustomerId + ", ProductId" + this.ProductId + ", Country" + this.Country;
        }
    }
}
