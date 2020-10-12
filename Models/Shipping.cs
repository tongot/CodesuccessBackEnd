using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSuccessFrontEnd.Models
{
    public class Shipping
    {
        public int Id { get; set; }
        public DateTime ShippingDate { get; set; }
        public bool IsDelivered { get; set; }
        public string Authorizer { get; set; }
        public float RatePerKilometer { get; set; }
        public int FromLocationId { get; set; }
        public int ToLocationId { get; set; }
        public int ShippingCompanyId { get; set; }
        public int OrderId { get; set; }
        public double EstimatedDistance { get; set; }

        public virtual ShippingCompany ShippingCompany { get; set; }

        [ForeignKey(nameof(Authorizer))]
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey(nameof(FromLocationId))]
        public virtual Location FromLocation { get; set; }
        [ForeignKey(nameof(ToLocationId))]
        public virtual Location ToLocation { get; set; }

    }
}