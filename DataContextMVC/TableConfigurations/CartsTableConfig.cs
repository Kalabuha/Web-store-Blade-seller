using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.StoreObjects.Cart;

namespace DataContextMVC.TableConfigurations
{
    internal class CartsTableConfig : IEntityTypeConfiguration<CartEntity>
    {
        public void Configure(EntityTypeBuilder<CartEntity> builder)
        {
            builder.ToTable("Carts");

            builder
                .HasKey(c => c.Id)
                .HasName("PK_carts");

            builder
                .Property(c => c.DateTimeCreate)
                .IsRequired()
                .HasDefaultValue(DateTime.Now)
                .HasColumnName("Date_creation");

            builder
                .Property(c => c.IdUserClient)
                .IsRequired()
                .HasColumnName("Id_user");
        }
    }
}
