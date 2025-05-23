﻿namespace IR_WEBAPP_Strimbeanu.Models
{
    public class WishlistItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int WishlistId { get; set; }
        public Wishlist? Wishlist { get; set; }
    }
}
