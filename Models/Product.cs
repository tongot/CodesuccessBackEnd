using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeSuccessFrontEnd.Models
{
    public class Product
    {
        public int Id  { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public string CoverPictureUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
         public ICollection<ProductCategory> ProductsCategories { get; set; }
         public ICollection<OtherProductProps> OtherProperties { get; set; }
         public ICollection<OtherPictures> Pictures { get; set; }
         public ICollection<Stock> Stocks { get; set; }
         public ICollection<Promotion> Promotions { get; set; }
         public ICollection<Credit> Credits { get; set; }
          public ICollection<OrderItems> OrderItems { get; set; }
    }
}