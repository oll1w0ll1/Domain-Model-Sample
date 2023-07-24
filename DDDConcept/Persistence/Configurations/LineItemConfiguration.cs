namespace Persistence.Configurations;

public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> builder)
    {
        builder.HasKey(li => li.Id);
        builder.Property(li => li.Id).HasConversion(
            li => li.Value,
            value => new LineItemId(value));
        builder.HasOne<Product>()
            .WithMany()
            .HasForeignKey(li => li.ProductId);
        builder.OwnsOne(li => li.Price);
    }
}