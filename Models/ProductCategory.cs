using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSuccessFrontEnd.Models
{
    public class ProductCategory
    {
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [Key, Column(Order = 2)]
        public int CategotyId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}