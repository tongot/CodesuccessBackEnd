using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSuccessFrontEnd.Models
{
    public class OtherProductProps
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string PropertName { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
    }
}