using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeSuccessFrontEnd.Models
{
    public class Order
    {
        public int Id { get; set; }
           [Required]
        [MaxLength(255)]
        public string City { get; set; }
           [Required]
        [MaxLength(255)]
        public string Street { get; set; }
           [Required]
        [MaxLength(255)]
        public string Country { get; set; }
           [Required]
        [MaxLength(255)]
        public string Mobile { get; set; }   
        [Required]
        [MaxLength(255)]
        public string Mobile2 { get; set; }
        [EmailAddress]
        public string Email { get; set; }  
        public bool IsPaid { get; set; }
        public bool OwnDelivery { get; set; }
        public DateTime ExpectedDateOfDelivery { get; set; }
        public DateTime DateOrdered { get; set; }
        public string  UserId { get; set; }
        public User User { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }
    }
}