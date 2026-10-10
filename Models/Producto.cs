using System.ComponentModel.DataAnnotations;

namespace MVCClase6.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        public string? Color { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public int CategoryId { get; set; }
    }
}