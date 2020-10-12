using System.Collections.Generic;

namespace CodeSuccessFrontEnd.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Promotion> Promotions { get; set; }
         public ICollection<Credit> Credits { get; set; }
    }
}