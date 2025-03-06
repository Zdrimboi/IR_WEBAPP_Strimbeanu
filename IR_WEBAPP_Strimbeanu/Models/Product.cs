using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IR_WEBAPP_Strimbeanu.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(255)]
        public string ShortDescription { get; set; } = string.Empty;

        public string LongDescription { get; set; } = string.Empty;

        // Thumbnail for the product
        public string ThumbnailUrl { get; set; } = string.Empty;

        // Collection of images
        public List<ProductImage> Images { get; set; } = new List<ProductImage>();

        public string PdfUrl { get; set; } = string.Empty;

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation property
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
    }

    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        // Foreign key reference to the Product
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
