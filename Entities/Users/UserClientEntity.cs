using Entities.StoreObjects.Cart;

namespace Entities.Users
{
    public class UserClientEntity : UserEntity
    {
        public virtual ICollection<CartEntity> Carts { get; set; } = default!;
    }
}
