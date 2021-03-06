using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.data.configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Image).HasMaxLength(1000);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
            builder.HasOne(p => p.Brand).WithMany().HasForeignKey(p => p.BrandId);
            builder.HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId);
        }
    }
}
