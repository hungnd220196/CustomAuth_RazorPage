using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorPage_CRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        public int quantity { get; set; }

    }
}
