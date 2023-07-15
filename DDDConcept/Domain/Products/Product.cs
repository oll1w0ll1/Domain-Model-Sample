namespace Domain.Products;

public sealed class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public Money Price  { get; private set; }
    public Sku Sku { get; private set; }
    
}