namespace CodeSuccessFrontEnd.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int NumberOfItems { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int LocationId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
        public virtual Location Location { get; set; }
    }
}