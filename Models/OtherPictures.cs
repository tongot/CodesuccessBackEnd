using System.ComponentModel.DataAnnotations.Schema;

namespace CodeSuccessFrontEnd.Models
{
    public class OtherPictures
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }  
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
    }
}