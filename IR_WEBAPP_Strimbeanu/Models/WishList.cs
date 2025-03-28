using IR_WEBAPP_Strimbeanu.Data;

namespace IR_WEBAPP_Strimbeanu.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public List<WishlistItem> Items { get; set; } = new();
    }
}
