using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IR_WEBAPP_Strimbeanu.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        // Navigation property: One category can have many products
        public List<Product> Products { get; set; } = new();
    }
}
