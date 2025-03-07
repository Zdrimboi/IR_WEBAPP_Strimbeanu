using IR_WEBAPP_Strimbeanu.Data;
using IR_WEBAPP_Strimbeanu.Models;

public class Cart
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public List<CartItem> Items { get; set; }
}

public class CartItem
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
