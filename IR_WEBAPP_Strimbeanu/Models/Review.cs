using IR_WEBAPP_Strimbeanu.Data;
using System.ComponentModel.DataAnnotations;

namespace IR_WEBAPP_Strimbeanu.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required, Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(1000)]
        public string? Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }

}
