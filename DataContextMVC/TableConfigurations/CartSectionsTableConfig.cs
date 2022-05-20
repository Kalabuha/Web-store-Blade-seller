using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.StoreObjects.Cart;

namespace DataContextMVC.TableConfigurations
{
    internal class CartSectionsTableConfig : IEntityTypeConfiguration<CartSectionEntity>
    {
        public void Configure(EntityTypeBuilder<CartSectionEntity> builder)
        {
            builder.ToTable("Cart_sections");

            builder
                .HasKey(s => s.Id)
                .HasName("PK_Cart_sections");

            builder
                .HasOne(c => c.Cart)
                .WithMany(s => s.CartSections)
                .HasForeignKey(c => c.IdCart)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Cart_Cart_sections");

            //builder.HasOne(g => g.Good).WithOne

            builder
                .Property(s => s.DateTimeCreate)
                .IsRequired()
                .HasDefaultValue(DateTime.Now)
                .HasColumnName("Date_creation");

        }
    }
}
