using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Models
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}