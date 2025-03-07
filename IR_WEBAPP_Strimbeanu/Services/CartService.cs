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

    public async Task AddToCartAsync(ApplicationUser user, Product product)
    {
        Console.WriteLine("Adding product to cart: " + product.Name);
        // Get the user's cart
        var cart = await GetCartAsync(user);

        if (cart == null)
        {
            cart = new Cart { UserId = user.Id };
            _dbContext.Carts.Add(cart);
            Console.WriteLine("Created a new cart for user: " + user.UserName);
        }

        var cartItem = cart.Items.FirstOrDefault(i => i.ProductId == product.Id);

        if (cartItem == null)
        {
            cartItem = new CartItem { ProductId = product.Id, Quantity = 1 };
            cart.Items.Add(cartItem);
            Console.WriteLine("Added new item to the cart: " + product.Name);
        }
        else
        {
            cartItem.Quantity++;
            Console.WriteLine("Updated quantity of existing item in the cart: " + product.Name);
        }

        await _dbContext.SaveChangesAsync(); // Commit changes to the database
        Console.WriteLine("Saved cart to the database.");
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
