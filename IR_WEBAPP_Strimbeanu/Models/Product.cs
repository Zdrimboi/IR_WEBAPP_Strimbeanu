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

        public string ThumbnailUrl { get; set; } = string.Empty;
        public string PdfUrl { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int UnitsSold { get; set; }

        // REMOVE the old 'public double AverageRating' if you want a truly computed rating

        // The category relation
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // Collections
        public List<ProductImage> Images { get; set; } = new();
        public List<ProductTag> Tags { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();

        [NotMapped]
        public double AverageRating => (Reviews == null || Reviews.Count == 0)
            ? 0.0
            : Reviews.Average(r => r.Rating);
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
