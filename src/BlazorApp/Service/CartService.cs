using Application.Products.Queries;

namespace BlazorApp.Services;

public class CartItem
{
    public ProductDto Product { get; set; } = default!;
    public int Quantity { get; set; } = 1;
}

public class CartService
{
    public List<CartItem> Items { get; private set; } = new();

    public event Action? OnChange;

    public void AddToCart(ProductDto product)
    {
        var existing = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existing != null)
        {
            existing.Quantity++;
        }
        else
        {
            Items.Add(new CartItem { Product = product, Quantity = 1 });
        }
        NotifyStateChanged();
    }

    public void RemoveFromCart(Guid productId)
    {
        Items.RemoveAll(i => i.Product.Id == productId);
        NotifyStateChanged();
    }

    public void ClearCart()
    {
        Items.Clear();
        NotifyStateChanged();
    }

    public decimal GetTotalPrice() => Items.Sum(i => i.Product.Price * i.Quantity);

    private void NotifyStateChanged() => OnChange?.Invoke();
}