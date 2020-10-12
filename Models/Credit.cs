using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSuccessFrontEnd.Models
{
    public class Credit
    {
        public int Id { get; set; }
        [Required]
        public double MonthlyInstalment { get; set; }
        [Required]

        public double Deposit { get; set; }
        [Required]

        public double FullAmountToPay { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(StoreId))]
        public virtual Store Store { get; set; }

    }
}