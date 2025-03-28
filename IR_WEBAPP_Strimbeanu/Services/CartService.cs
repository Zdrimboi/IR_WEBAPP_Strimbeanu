using IR_WEBAPP_Strimbeanu.Data;
using IR_WEBAPP_Strimbeanu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

public class CartService
{
    private readonly ApplicationDbContext _dbContext;
    private readonly UserManager<ApplicationUser> _userManager;

    public CartService(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
    {
        _dbContext = dbContext;
        _userManager = userManager;
    }

    public async Task<Cart> GetCartAsync(ApplicationUser user)
    {
        var cart = await _dbContext.Carts
            .Include(c => c.Items)
            .ThenInclude(ci => ci.Product)
            .FirstOrDefaultAsync(c => c.UserId == user.Id);

        if (cart == null)
        {
            cart = new Cart
            {
                UserId = user.Id,
                Items = new List<CartItem>()
            };
            _dbContext.Carts.Add(cart);
            await _dbContext.SaveChangesAsync();
        }

        return cart;
    }

    public async Task AddToCartAsync(ApplicationUser user, Product product, int quantity)
    {
        Console.WriteLine($"Adding product '{product.Name}' with quantity {quantity} to cart");

        var cart = await GetCartAsync(user);

        if (cart == null)
        {
            cart = new Cart { UserId = user.Id };
            _dbContext.Carts.Add(cart);
            Console.WriteLine($"Created new cart for user: {user.UserName}");
        }

        var cartItem = cart.Items.FirstOrDefault(i => i.ProductId == product.Id);

        if (cartItem == null)
        {
            cartItem = new CartItem { ProductId = product.Id, Quantity = quantity };
            cart.Items.Add(cartItem);
            Console.WriteLine($"Added new item '{product.Name}' with quantity {quantity} to cart.");
        }
        else
        {
            cartItem.Quantity += quantity;
            Console.WriteLine($"Updated existing item '{product.Name}' to quantity {cartItem.Quantity}");
        }

        await _dbContext.SaveChangesAsync();
        Console.WriteLine("Saved cart with updated quantity.");
    }

    public async Task RemoveFromCartAsync(ApplicationUser user, int productId)
    {
        var cart = await GetCartAsync(user);
        var cartItem = cart.Items.FirstOrDefault(ci => ci.ProductId == productId);
        if (cartItem != null)
        {
            cart.Items.Remove(cartItem);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<int> GetCartItemCountAsync(ApplicationUser user)
    {
        var cart = await GetCartAsync(user);
        return cart.Items.Sum(ci => ci.Quantity);
    }
}
