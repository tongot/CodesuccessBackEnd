using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSuccessFrontEnd.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }
        public int MainCategoryId { get; set; }
        [ForeignKey(nameof(MainCategoryId))]
        public virtual MainCategory MainCategory { get; set; }
        public ICollection<ProductCategory> ProductsCategories { get; set; }
    }
}