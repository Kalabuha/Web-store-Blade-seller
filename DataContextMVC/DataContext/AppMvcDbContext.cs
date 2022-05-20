using Microsoft.EntityFrameworkCore;
using Entities.StoreObjects.Cart;
using Entities.StoreObjects.Catalog;
using Entities.StoreObjects.OtherObjects;
using Entities.Users;
using Entities.Goods.Knives;
using Entities.Goods.Knives.Materials;
using DataContextMVC.TableConfigurations;

namespace DataContextMVC.DataContext
{
    public class AppMvcDbContext : DbContext
    {
        // Корзины магазина
        DbSet<CartEntity> Carts => Set<CartEntity>();
        DbSet<CartSectionEntity> CartSections => Set<CartSectionEntity>();

        // Каталоги
        DbSet<CatalogEntity> Catalogs => Set<CatalogEntity>();

        // Отзывы о товарах
        DbSet<ProductReviewEntity> ProductReviews => Set<ProductReviewEntity>();

        // Клиенты
        DbSet<UserClientEntity> Clients => Set<UserClientEntity>();

        // Админы
        DbSet<UserAdminEntity> Admins => Set<UserAdminEntity>();

        // Ножи
        DbSet<KnifeEntity> Knives => Set<KnifeEntity>();
        DbSet<BladeFixationEntity> BladeFixations => Set<BladeFixationEntity>();
        DbSet<BladeMaterialEntity> BladeMaterials => Set<BladeMaterialEntity>();
        DbSet<HandleMaterialEntity> HandleMaterials => Set<HandleMaterialEntity>();

        public AppMvcDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartsTableConfig());
            modelBuilder.ApplyConfiguration(new CartSectionsTableConfig());
        }
    }
}
