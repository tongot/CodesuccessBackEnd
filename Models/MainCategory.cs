using System.ComponentModel.DataAnnotations;

namespace CodeSuccessFrontEnd.Models
{
    public class MainCategory
    {
        public int Id { get; set; }
           [Required]
        [MaxLength(255)]
        public string Name { get; set; }

    }
}