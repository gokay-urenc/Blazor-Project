using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string QuantityPerUnit { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        [Range(0, 10)]
        public int UnitsInStock { get; set; }
    }
}