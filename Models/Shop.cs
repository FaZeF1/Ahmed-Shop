using System.ComponentModel.DataAnnotations;

namespace BaseProject.Models
{
    public class Shop
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public ProductSize Size { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

    }

    public enum ProductSize
    {
        Small = 1,
        Middle = 2,
        large = 3,

    }


}
