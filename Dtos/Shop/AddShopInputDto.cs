using BaseProject.Models;
using System.ComponentModel.DataAnnotations;

namespace BaseProject.Dtos.Shop
{
    public class AddShopInputDto
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public decimal Price { get; set; }
        [Required]

        public ProductSize Size { get; set; }
    }
}
