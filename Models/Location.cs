using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeSuccessFrontEnd.Models
{
    public class Location
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Shipping> Shipping { get; set; }
    }
}