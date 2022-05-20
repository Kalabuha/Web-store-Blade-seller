using Entities.Base;
using Entities.Users;

namespace Entities.StoreObjects.Cart
{
    public class CartEntity : IEntity, IDateTimeCreateSaveable
    {
        public int Id { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public int IdUserClient { get; set; }
        public virtual UserClientEntity UserClient { get; set; } = default!;
        public virtual ICollection<CartSectionEntity> CartSections { get; set; } = default!;
    }
}
