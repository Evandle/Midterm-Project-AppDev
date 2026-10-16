using ExamApp.Models;   // change ExamApp to your project name

namespace ExamApp.Services;

// One line in the cart: a product and how many of it.
public class CartItem
{
    public Product Product { get; init; } = default!;
    public int Quantity { get; set; }
    public decimal LineTotal => Product.Price * Quantity;
}

// The shopping cart. Registered once in Program.cs, so every page and the header
// share the same cart. It lives in memory only: refreshing the browser empties it.
public class CartService
{
    public const int MaxPerItem = 10;

    private readonly List<CartItem> items = new();

    public IReadOnlyList<CartItem> Items => items;
    public int Count => items.Sum(i => i.Quantity);
    public decimal Subtotal => items.Sum(i => i.LineTotal);

    // Components subscribe to this to redraw themselves when the cart changes
    // (the header uses it to update the number on the cart icon).
    public event Action? OnChange;

    public void Add(Product product, int quantity = 1)
    {
        if (product.IsSoldOut || quantity < 1) return;

        var existing = items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existing is null)
            items.Add(new CartItem { Product = product, Quantity = Math.Min(quantity, MaxPerItem) });
        else
            existing.Quantity = Math.Min(existing.Quantity + quantity, MaxPerItem);

        OnChange?.Invoke();
    }

    public void SetQuantity(int productId, int quantity)
    {
        var existing = items.FirstOrDefault(i => i.Product.Id == productId);
        if (existing is null) return;

        existing.Quantity = Math.Clamp(quantity, 1, MaxPerItem);
        OnChange?.Invoke();
    }

    public void Remove(int productId)
    {
        items.RemoveAll(i => i.Product.Id == productId);
        OnChange?.Invoke();
    }

    public void Clear()
    {
        items.Clear();
        OnChange?.Invoke();
    }
}
