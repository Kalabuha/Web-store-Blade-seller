using Entities.Base;
using Entities.Goods;

namespace Entities.StoreObjects.Cart
{
    public class CartSectionEntity : IEntity, IDateTimeCreateSaveable
    {
        public int Id { get; set; }
        public DateTime DateTimeCreate { get; set; }
        public int IdCart { get; set; }
        public virtual CartEntity Cart { get; set; } = default!;
        public int IdGood { get; set; }
        public virtual GoodEntity Good { get; set; } = default!;
        public int AmountGoods { get; set; }
    }
}
