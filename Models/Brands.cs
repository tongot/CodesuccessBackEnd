using System.ComponentModel.DataAnnotations;

namespace CodeSuccessFrontEnd.Models
{
    public class Brands
    {
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }
    }
}