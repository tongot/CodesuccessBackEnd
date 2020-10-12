using System.ComponentModel.DataAnnotations;

namespace CodeSuccessFrontEnd.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public float PercentageOff { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}